using BrgyMs.backend.models.base_model;
using Isopoh.Cryptography.Argon2;
using Microsoft.IdentityModel.Tokens;
using MimeKit.Encodings;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;



namespace BrgyMs.backend.utils {


    public class AuthUtils {
        private readonly Settings settings = new Settings();
        public string hashedPassword(string plainPassword) {
            return Argon2.Hash(plainPassword);
        }

        public bool verifyHashedPassword(string plainPassword, string hashedPassword) {


            if (string.IsNullOrEmpty(hashedPassword) ||
                string.IsNullOrEmpty(plainPassword)) {
                return false;
            }


            return Argon2.Verify(hashedPassword, plainPassword);

        }

        public string GenerateToken(Dictionary<string, string> data) {

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(settings.TOKEN_SECRET_KEY));
            var credentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha512);

            var claims = new[] {
                new Claim(
                    ClaimTypes.NameIdentifier,data["userId"]
                ),
                new Claim(ClaimTypes.Role,data["role"]),
                new Claim(ClaimTypes.NameIdentifier,data["username"]),
            };

            var token = new JwtSecurityToken(
                issuer: "shisharp",
                audience: "c# dev",
                claims: claims,
                signingCredentials: credentials
            );

            string encode = new JwtSecurityTokenHandler().WriteToken(token);

            return encode;
        }
    }
}