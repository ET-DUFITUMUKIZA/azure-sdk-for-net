// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DataMigration.Models;

namespace Azure.ResourceManager.DataMigration
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _sqlMigrationServiceClientDiagnostics;
        private SqlMigrationServicesRestOperations _sqlMigrationServiceRestClient;
        private ClientDiagnostics _resourceSkusClientDiagnostics;
        private ResourceSkusRestOperations _resourceSkusRestClient;
        private ClientDiagnostics _dataMigrationServiceServicesClientDiagnostics;
        private ServicesRestOperations _dataMigrationServiceServicesRestClient;
        private ClientDiagnostics _usagesClientDiagnostics;
        private UsagesRestOperations _usagesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics SqlMigrationServiceClientDiagnostics => _sqlMigrationServiceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DataMigration", SqlMigrationServiceResource.ResourceType.Namespace, Diagnostics);
        private SqlMigrationServicesRestOperations SqlMigrationServiceRestClient => _sqlMigrationServiceRestClient ??= new SqlMigrationServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(SqlMigrationServiceResource.ResourceType));
        private ClientDiagnostics ResourceSkusClientDiagnostics => _resourceSkusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DataMigration", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ResourceSkusRestOperations ResourceSkusRestClient => _resourceSkusRestClient ??= new ResourceSkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics DataMigrationServiceServicesClientDiagnostics => _dataMigrationServiceServicesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DataMigration", DataMigrationServiceResource.ResourceType.Namespace, Diagnostics);
        private ServicesRestOperations DataMigrationServiceServicesRestClient => _dataMigrationServiceServicesRestClient ??= new ServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DataMigrationServiceResource.ResourceType));
        private ClientDiagnostics UsagesClientDiagnostics => _usagesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DataMigration", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private UsagesRestOperations UsagesRestClient => _usagesRestClient ??= new UsagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(Core.ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Retrieve all SQL migration services in the subscriptions.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataMigration/sqlMigrationServices
        /// Operation Id: SqlMigrationServices_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlMigrationServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlMigrationServiceResource> GetSqlMigrationServicesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlMigrationServiceResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = SqlMigrationServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSqlMigrationServices");
                scope.Start();
                try
                {
                    var response = await SqlMigrationServiceRestClient.ListBySubscriptionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlMigrationServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SqlMigrationServiceResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = SqlMigrationServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSqlMigrationServices");
                scope.Start();
                try
                {
                    var response = await SqlMigrationServiceRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlMigrationServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Retrieve all SQL migration services in the subscriptions.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataMigration/sqlMigrationServices
        /// Operation Id: SqlMigrationServices_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlMigrationServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlMigrationServiceResource> GetSqlMigrationServices(CancellationToken cancellationToken = default)
        {
            Page<SqlMigrationServiceResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = SqlMigrationServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSqlMigrationServices");
                scope.Start();
                try
                {
                    var response = SqlMigrationServiceRestClient.ListBySubscription(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlMigrationServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SqlMigrationServiceResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = SqlMigrationServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSqlMigrationServices");
                scope.Start();
                try
                {
                    var response = SqlMigrationServiceRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlMigrationServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// The skus action returns the list of SKUs that DMS supports.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataMigration/skus
        /// Operation Id: ResourceSkus_ListSkus
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceSku" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceSku> GetSkusResourceSkusAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceSku>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ResourceSkusClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSkusResourceSkus");
                scope.Start();
                try
                {
                    var response = await ResourceSkusRestClient.ListSkusAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceSku>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ResourceSkusClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSkusResourceSkus");
                scope.Start();
                try
                {
                    var response = await ResourceSkusRestClient.ListSkusNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// The skus action returns the list of SKUs that DMS supports.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataMigration/skus
        /// Operation Id: ResourceSkus_ListSkus
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceSku" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceSku> GetSkusResourceSkus(CancellationToken cancellationToken = default)
        {
            Page<ResourceSku> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ResourceSkusClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSkusResourceSkus");
                scope.Start();
                try
                {
                    var response = ResourceSkusRestClient.ListSkus(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceSku> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ResourceSkusClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSkusResourceSkus");
                scope.Start();
                try
                {
                    var response = ResourceSkusRestClient.ListSkusNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// The services resource is the top-level resource that represents the Database Migration Service. This method returns a list of service resources in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataMigration/services
        /// Operation Id: Services_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataMigrationServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataMigrationServiceResource> GetDataMigrationServicesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DataMigrationServiceResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DataMigrationServiceServicesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDataMigrationServices");
                scope.Start();
                try
                {
                    var response = await DataMigrationServiceServicesRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataMigrationServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DataMigrationServiceResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = DataMigrationServiceServicesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDataMigrationServices");
                scope.Start();
                try
                {
                    var response = await DataMigrationServiceServicesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataMigrationServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// The services resource is the top-level resource that represents the Database Migration Service. This method returns a list of service resources in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataMigration/services
        /// Operation Id: Services_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataMigrationServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataMigrationServiceResource> GetDataMigrationServices(CancellationToken cancellationToken = default)
        {
            Page<DataMigrationServiceResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DataMigrationServiceServicesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDataMigrationServices");
                scope.Start();
                try
                {
                    var response = DataMigrationServiceServicesRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataMigrationServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DataMigrationServiceResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = DataMigrationServiceServicesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDataMigrationServices");
                scope.Start();
                try
                {
                    var response = DataMigrationServiceServicesRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataMigrationServiceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// This method checks whether a proposed top-level resource name is valid and available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataMigration/locations/{location}/checkNameAvailability
        /// Operation Id: Services_CheckNameAvailability
        /// </summary>
        /// <param name="location"> The Azure region of the operation. </param>
        /// <param name="nameAvailabilityRequest"> Requested name to validate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NameAvailabilityResponse>> CheckNameAvailabilityServiceAsync(AzureLocation location, NameAvailabilityRequest nameAvailabilityRequest, CancellationToken cancellationToken = default)
        {
            using var scope = DataMigrationServiceServicesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNameAvailabilityService");
            scope.Start();
            try
            {
                var response = await DataMigrationServiceServicesRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, location, nameAvailabilityRequest, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This method checks whether a proposed top-level resource name is valid and available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataMigration/locations/{location}/checkNameAvailability
        /// Operation Id: Services_CheckNameAvailability
        /// </summary>
        /// <param name="location"> The Azure region of the operation. </param>
        /// <param name="nameAvailabilityRequest"> Requested name to validate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NameAvailabilityResponse> CheckNameAvailabilityService(AzureLocation location, NameAvailabilityRequest nameAvailabilityRequest, CancellationToken cancellationToken = default)
        {
            using var scope = DataMigrationServiceServicesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNameAvailabilityService");
            scope.Start();
            try
            {
                var response = DataMigrationServiceServicesRestClient.CheckNameAvailability(Id.SubscriptionId, location, nameAvailabilityRequest, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This method returns region-specific quotas and resource usage information for the Database Migration Service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataMigration/locations/{location}/usages
        /// Operation Id: Usages_List
        /// </summary>
        /// <param name="location"> The Azure region of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Quota" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Quota> GetUsagesAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            async Task<Page<Quota>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = UsagesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetUsages");
                scope.Start();
                try
                {
                    var response = await UsagesRestClient.ListAsync(Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Quota>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = UsagesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetUsages");
                scope.Start();
                try
                {
                    var response = await UsagesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// This method returns region-specific quotas and resource usage information for the Database Migration Service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataMigration/locations/{location}/usages
        /// Operation Id: Usages_List
        /// </summary>
        /// <param name="location"> The Azure region of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Quota" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Quota> GetUsages(AzureLocation location, CancellationToken cancellationToken = default)
        {
            Page<Quota> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = UsagesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetUsages");
                scope.Start();
                try
                {
                    var response = UsagesRestClient.List(Id.SubscriptionId, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Quota> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = UsagesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetUsages");
                scope.Start();
                try
                {
                    var response = UsagesRestClient.ListNextPage(nextLink, Id.SubscriptionId, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
