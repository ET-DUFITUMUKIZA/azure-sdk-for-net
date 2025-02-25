// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary>
    /// A class representing a collection of <see cref="AppConfigurationKeyValueResource" /> and their operations.
    /// Each <see cref="AppConfigurationKeyValueResource" /> in the collection will belong to the same instance of <see cref="AppConfigurationStoreResource" />.
    /// To get an <see cref="AppConfigurationKeyValueCollection" /> instance call the GetAppConfigurationKeyValues method from an instance of <see cref="AppConfigurationStoreResource" />.
    /// </summary>
    public partial class AppConfigurationKeyValueCollection : ArmCollection, IEnumerable<AppConfigurationKeyValueResource>, IAsyncEnumerable<AppConfigurationKeyValueResource>
    {
        private readonly ClientDiagnostics _appConfigurationKeyValueKeyValuesClientDiagnostics;
        private readonly KeyValuesRestOperations _appConfigurationKeyValueKeyValuesRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppConfigurationKeyValueCollection"/> class for mocking. </summary>
        protected AppConfigurationKeyValueCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppConfigurationKeyValueCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppConfigurationKeyValueCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appConfigurationKeyValueKeyValuesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppConfiguration", AppConfigurationKeyValueResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppConfigurationKeyValueResource.ResourceType, out string appConfigurationKeyValueKeyValuesApiVersion);
            _appConfigurationKeyValueKeyValuesRestClient = new KeyValuesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appConfigurationKeyValueKeyValuesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppConfigurationStoreResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppConfigurationStoreResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a key-value.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues/{keyValueName}
        /// Operation Id: KeyValues_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="keyValueName"> Identifier of key and label combination. Key and label are joined by $ character. Label is optional. </param>
        /// <param name="data"> The parameters for creating a key-value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyValueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyValueName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppConfigurationKeyValueResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string keyValueName, AppConfigurationKeyValueData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyValueName, nameof(keyValueName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appConfigurationKeyValueKeyValuesClientDiagnostics.CreateScope("AppConfigurationKeyValueCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appConfigurationKeyValueKeyValuesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyValueName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppConfigurationArmOperation<AppConfigurationKeyValueResource>(Response.FromValue(new AppConfigurationKeyValueResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a key-value.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues/{keyValueName}
        /// Operation Id: KeyValues_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="keyValueName"> Identifier of key and label combination. Key and label are joined by $ character. Label is optional. </param>
        /// <param name="data"> The parameters for creating a key-value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyValueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyValueName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppConfigurationKeyValueResource> CreateOrUpdate(WaitUntil waitUntil, string keyValueName, AppConfigurationKeyValueData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyValueName, nameof(keyValueName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appConfigurationKeyValueKeyValuesClientDiagnostics.CreateScope("AppConfigurationKeyValueCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appConfigurationKeyValueKeyValuesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyValueName, data, cancellationToken);
                var operation = new AppConfigurationArmOperation<AppConfigurationKeyValueResource>(Response.FromValue(new AppConfigurationKeyValueResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified key-value.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues/{keyValueName}
        /// Operation Id: KeyValues_Get
        /// </summary>
        /// <param name="keyValueName"> Identifier of key and label combination. Key and label are joined by $ character. Label is optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyValueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyValueName"/> is null. </exception>
        public virtual async Task<Response<AppConfigurationKeyValueResource>> GetAsync(string keyValueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyValueName, nameof(keyValueName));

            using var scope = _appConfigurationKeyValueKeyValuesClientDiagnostics.CreateScope("AppConfigurationKeyValueCollection.Get");
            scope.Start();
            try
            {
                var response = await _appConfigurationKeyValueKeyValuesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyValueName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppConfigurationKeyValueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified key-value.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues/{keyValueName}
        /// Operation Id: KeyValues_Get
        /// </summary>
        /// <param name="keyValueName"> Identifier of key and label combination. Key and label are joined by $ character. Label is optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyValueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyValueName"/> is null. </exception>
        public virtual Response<AppConfigurationKeyValueResource> Get(string keyValueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyValueName, nameof(keyValueName));

            using var scope = _appConfigurationKeyValueKeyValuesClientDiagnostics.CreateScope("AppConfigurationKeyValueCollection.Get");
            scope.Start();
            try
            {
                var response = _appConfigurationKeyValueKeyValuesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyValueName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppConfigurationKeyValueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the key-values for a given configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues
        /// Operation Id: KeyValues_ListByConfigurationStore
        /// </summary>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppConfigurationKeyValueResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppConfigurationKeyValueResource> GetAllAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<AppConfigurationKeyValueResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _appConfigurationKeyValueKeyValuesClientDiagnostics.CreateScope("AppConfigurationKeyValueCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appConfigurationKeyValueKeyValuesRestClient.ListByConfigurationStoreAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppConfigurationKeyValueResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AppConfigurationKeyValueResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _appConfigurationKeyValueKeyValuesClientDiagnostics.CreateScope("AppConfigurationKeyValueCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appConfigurationKeyValueKeyValuesRestClient.ListByConfigurationStoreNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppConfigurationKeyValueResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists the key-values for a given configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues
        /// Operation Id: KeyValues_ListByConfigurationStore
        /// </summary>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppConfigurationKeyValueResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppConfigurationKeyValueResource> GetAll(string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<AppConfigurationKeyValueResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _appConfigurationKeyValueKeyValuesClientDiagnostics.CreateScope("AppConfigurationKeyValueCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appConfigurationKeyValueKeyValuesRestClient.ListByConfigurationStore(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppConfigurationKeyValueResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AppConfigurationKeyValueResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _appConfigurationKeyValueKeyValuesClientDiagnostics.CreateScope("AppConfigurationKeyValueCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appConfigurationKeyValueKeyValuesRestClient.ListByConfigurationStoreNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppConfigurationKeyValueResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues/{keyValueName}
        /// Operation Id: KeyValues_Get
        /// </summary>
        /// <param name="keyValueName"> Identifier of key and label combination. Key and label are joined by $ character. Label is optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyValueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyValueName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string keyValueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyValueName, nameof(keyValueName));

            using var scope = _appConfigurationKeyValueKeyValuesClientDiagnostics.CreateScope("AppConfigurationKeyValueCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appConfigurationKeyValueKeyValuesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyValueName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/keyValues/{keyValueName}
        /// Operation Id: KeyValues_Get
        /// </summary>
        /// <param name="keyValueName"> Identifier of key and label combination. Key and label are joined by $ character. Label is optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyValueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyValueName"/> is null. </exception>
        public virtual Response<bool> Exists(string keyValueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyValueName, nameof(keyValueName));

            using var scope = _appConfigurationKeyValueKeyValuesClientDiagnostics.CreateScope("AppConfigurationKeyValueCollection.Exists");
            scope.Start();
            try
            {
                var response = _appConfigurationKeyValueKeyValuesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyValueName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppConfigurationKeyValueResource> IEnumerable<AppConfigurationKeyValueResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppConfigurationKeyValueResource> IAsyncEnumerable<AppConfigurationKeyValueResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
