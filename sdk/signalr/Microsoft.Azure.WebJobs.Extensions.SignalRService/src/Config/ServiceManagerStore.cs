﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.SignalR;
using Microsoft.Azure.SignalR.Management;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Microsoft.Azure.WebJobs.Extensions.SignalRService
{
    internal sealed class ServiceManagerStore : IServiceManagerStore
    {
        private readonly ILoggerFactory _loggerFactory;
        private readonly AzureComponentFactory _azureComponentFactory;
        private readonly SignalROptions _options;
        private readonly IConfiguration _configuration;
        private readonly IEndpointRouter _router;
        private readonly ConcurrentDictionary<string, IInternalServiceHubContextStore> _store = new();

        public ServiceManagerStore(IConfiguration configuration, ILoggerFactory loggerFactory, AzureComponentFactory azureComponentFactory, IOptions<SignalROptions> options, IEndpointRouter router = null)
        {
            _loggerFactory = loggerFactory;
            _azureComponentFactory = azureComponentFactory;
            _options = options.Value;
            _configuration = configuration;
            _router = router;
        }

        public IInternalServiceHubContextStore GetOrAddByConnectionStringKey(string connectionStringKey)
        {
            if (string.IsNullOrWhiteSpace(connectionStringKey))
            {
                throw new ArgumentException($"'{nameof(connectionStringKey)}' cannot be null or whitespace", nameof(connectionStringKey));
            }
            return _store.GetOrAdd(connectionStringKey, CreateHubContextStore);
        }

        //test only
        public IInternalServiceHubContextStore GetByConfigurationKey(string connectionStringKey)
        {
            return _store.ContainsKey(connectionStringKey) ? _store[connectionStringKey] : null;
        }

        private IInternalServiceHubContextStore CreateHubContextStore(string connectionStringKey)
        {
            var services = new ServiceCollection()
                .Configure<ServiceManagerOptions>(o =>
                {
                    o.ServiceTransportType = _options.ServiceTransportType;
                    o.ServiceEndpoints = _options.ServiceEndpoints?.ToArray();
                    o.UseJsonObjectSerializer(_options.JsonObjectSerializer);
                })
                .SetupOptions<ServiceManagerOptions, OptionsSetup>(new OptionsSetup(_configuration, _azureComponentFactory, connectionStringKey))
                .AddSignalRServiceManager()
                .AddSingleton(sp => (ServiceManager)sp.GetService<IServiceManager>())
                .AddSingleton(_loggerFactory)
                .AddSingleton<IInternalServiceHubContextStore, ServiceHubContextStore>();
            if (_router != null)
            {
                services.AddSingleton(_router);
            }
            services.AddSingleton(services.ToList() as IReadOnlyCollection<ServiceDescriptor>);
            return services.BuildServiceProvider()
               .GetRequiredService<IInternalServiceHubContextStore>();
        }

        public async ValueTask DisposeAsync()
        {
            foreach (var hubContextStore in _store.Values)
            {
                await hubContextStore.DisposeAsync().ConfigureAwait(false);
            }
        }

        public void Dispose()
        {
#pragma warning disable AZC0102 // Do not use GetAwaiter().GetResult().
            DisposeAsync().GetAwaiter().GetResult();
#pragma warning restore AZC0102 // Do not use GetAwaiter().GetResult().
        }
    }
}