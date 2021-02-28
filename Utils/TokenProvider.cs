using System;
using System.Threading.Tasks;
using TGTG.Api.Core.Internal.Common;
using TGTG.Api.Core.Internal.Requests;
using TGTG.Api.Core.Internal.Responses;

namespace TGTG.Api.Core.Utils
{
    internal class TokenProvider : IDisposable
    {
        private readonly InternalHttpClient _httpClient;
        private readonly string _email;
        private readonly string _password;
        private Token _token;

        internal TokenProvider(InternalHttpClient internalHttpClient, string email, string password)
        {
            _httpClient = internalHttpClient;
            _email = email;
            _password = password;
        }

        internal async Task<Token> GetToken()
        {
            if (_token == null)
                _token = await FetchToken();

            if (_token.IsExpired)
                _token = await RefreshToken();

            return _token;
        }

        private async Task<Token> FetchToken()
        {
            var loginRequest = new LoginRequest(_email, _password);
            var response = await _httpClient.PostAsync<LoginResponse, LoginRequest>(Urls.Login(), loginRequest, null);

            return new Token(response.AccessToken, response.RefreshToken, response.Data.User.UserId);
        }

        private async Task<Token> RefreshToken()
        {
            var response = await _httpClient.PostAsync<TokenResponse, RefreshTokenRequest>(Urls.Refresh(), _token.RefreshToken, _token.AccessToken);

            return new Token(response.AccessToken, response.RefreshToken, _token.UserId);
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}