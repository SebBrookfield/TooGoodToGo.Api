using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGTG.Api.Core.Internal.Common;
using TGTG.Api.Core.Internal.Requests;
using TGTG.Api.Core.Internal.Responses;
using TGTG.Api.Core.Utils;

namespace TGTG.Api.Core
{
    public class TooGoodToGoClient : IDisposable
    {
        private readonly InternalHttpClient _httpClient;
        private readonly TokenProvider _tokenProvider;

        public TimeSpan Timeout
        {
            get => _httpClient.Timeout;
            set => _httpClient.Timeout = value;
        }

        public TooGoodToGoClient(string email, string password)
        {
            _httpClient = new InternalHttpClient();
            _tokenProvider = new TokenProvider(_httpClient, email, password);
        }

        public async Task<List<Location>> FindLocationsAsync(string location)
        {
            var response = await PostAsync<LocationResponse, LocationRequest>(Urls.Locations, new LocationRequest(location));
            return response.Locations
                .Select(ConvertToLocation)
                .ToList();
        }

        public async Task<List<Store>> FindStoresAsync(Coordinates geoLocation, double radius)
        {
            var token = await _tokenProvider.GetToken();
            var storeRequest = new StoreRequest
            {
                UserId = token.UserId,
                LocationCoordinates = new LocationCoordinates(geoLocation.Latitude, geoLocation.Longitude),
                Radius = radius
            };

            var response = await PostAsync<StoreResponse, StoreRequest>(Urls.Stores, storeRequest);

            return response.Containers
                .Select(ConvertToStore)
                .ToList();
        }

        private static Location ConvertToLocation(LocationResult location)
        {
            return new Location
            {
                Name = location.Name,
                Coordinates = new Coordinates(location.Coordinates.Latitude, location.Coordinates.Longitude)
            };
        }

        private static Store ConvertToStore(StoreContainer container)
        {
            var storePickupLocation = container.PickupLocation;

            return new Store
            {
                Id = container.Store.Id,
                ItemId = container.Item.Id,
                Name = container.Store.Name,
                Description = container.Item.Description,
                Website = container.Store.Website,
                Distance = container.Distance,
                Favourited = container.Favorited,
                Address = new Address
                {
                    AddressLine = storePickupLocation.Address.AddressLine,
                    City = storePickupLocation.Address.City,
                    Postcode = storePickupLocation.Address.Postcode,
                    GeoLocation = new Coordinates(storePickupLocation.LocationCoordinates.Latitude, storePickupLocation.LocationCoordinates.Longitude)
                }
            };
        }

        private async Task<TResponse> PostAsync<TResponse, TRequest>(string url, TRequest request)
        {
            var token = await _tokenProvider.GetToken();
            return await _httpClient.PostAsync<TResponse, TRequest>(url, request, token.AccessToken);
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
            _tokenProvider?.Dispose();
        }
    }
}