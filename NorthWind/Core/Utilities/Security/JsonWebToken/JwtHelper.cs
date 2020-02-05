using Core.Entity.Concrete;
using Core.Utilities.Security.Encyption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Core.Utilities.Security.JsonWebToken
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration configuration { get; }
        private TokenOptions tokenOptions;
        DateTime accessTokenExpiration;

        public JwtHelper(IConfiguration _configuration)
        {
            configuration = _configuration;
            tokenOptions = configuration.GetSection(key: "TokenOptions").Get<TokenOptions>();
            accessTokenExpiration = DateTime.Now.AddMinutes(tokenOptions.AccessTokenExpiration);
        }

        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            var securityKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);

        }

        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user, SigningCredentials signingCredentials, List<OperationClaim> operationClaims)
        {
            var jwt = new JwtSecurityToken(issuer: tokenOptions.Issuer, audience: tokenOptions.Audience, expires: accessTokenExpiration, notBefore: DateTime.Now, claims: operationClaims, signingCredentials: signingCredentials);
        }

        private IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim(type: "role", value: user.Email));
        }
    }
}
