﻿using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace PianoMentor.BLL.TokenService
{
	public interface ITokenService
	{
		public (string token, DateTime accessTokenExpiry) CreateAccessToken(DAL.Domain.Identity.PianoMentorUser user, IEnumerable<string> userRoles);
		public string CreateRefreshToken();
		public ClaimsPrincipal? GetPrincipalFromExpiredToken(string? accessToken);

		bool IsCurrentUserActiveToken();
		void DeactivateCurrentUserToken();
		bool IsActiveUserToken(string token);
		void DeactivateUserToken(string token);
	}
}