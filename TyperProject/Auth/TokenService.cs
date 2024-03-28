using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;

namespace TyperProject.Auth
{
    public class TokenService : ITokenService
    {
        private TimeSpan _expiryDuration = TimeSpan.FromHours(1);

        public string GenerateToken(string issuer, string audience, string key, User user)
        {
            var claims = new List<Claim> { new Claim("UserId", user.Id.ToString()) };
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                signingCredentials: signingCredentials,
                expires: DateTime.Now.Add(_expiryDuration));

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
