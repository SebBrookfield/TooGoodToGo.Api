using System;

namespace TGTG.Api.Core.Internal.Common
{
    internal class Token
    {
        private readonly DateTime _issueDate;
        private readonly TimeSpan _tokenDuration = TimeSpan.FromHours(1);

        public string AccessToken { get; }
        public string RefreshToken { get; }
        public string UserId { get; }
        internal bool IsExpired => DateTime.Now >= _issueDate.Add(_tokenDuration);

        internal Token(string accessToken, string refreshToken, string userId)
        {
            // Set the issue date to be 5 minutes in the future to ensure our token has a buffer window.
            _issueDate = DateTime.Now.Add(TimeSpan.FromMinutes(5));
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            UserId = userId;
        }
    }
}