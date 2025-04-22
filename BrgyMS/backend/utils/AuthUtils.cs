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
        private string fileDirectory = "";
        private string filename = "/users.token";
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
        //Generate token
        public string GenerateToken(Dictionary<string, string> data) {
            try {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(settings.TOKEN_SECRET_KEY));
                var credentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha512);

                var claims = new[] {
                new Claim( ClaimTypes.NameIdentifier,data["userId"]

                ),
                new Claim(ClaimTypes.Role,data["role"]),
                new Claim("username",data["username"]),
            };

                var token = new JwtSecurityToken(
                    issuer: settings.ISSUER,
                    audience: settings.AUDIENCE,
                    claims: claims,
                    signingCredentials: credentials
                );

                string encode = new JwtSecurityTokenHandler().WriteToken(token);

                PutTokenInFile(encode);

                return encode;
            }
            catch (Exception e) {
                throw;
            }
          
        }

        //validate Token
        public ClaimsPrincipal ValidateToken(string token) {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(settings.TOKEN_SECRET_KEY);

            var validateTokenParam = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidIssuer = settings.ISSUER,
                ValidAudience = settings.AUDIENCE,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuerSigningKey = true,
                ValidateLifetime = false
            };

            try {
                var principal = tokenHandler.ValidateToken(token, validateTokenParam, out SecurityToken validatedToken);
                return principal;
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }

            return null;
        }

        private void PutTokenInFile(String token) {
            //get the curr directory and add info directory
            fileDirectory = Path.Combine(Directory.GetCurrentDirectory(), "../../../info");

            //check if not exist, then create
            if (!Directory.Exists(fileDirectory)) {
                Directory.CreateDirectory(fileDirectory);
            }
            // check if not exist, then create
            String filepath = fileDirectory + filename;
            if (!File.Exists(filepath)) {
                File.Create(filepath);

            }

            using (FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write)) {
                using (StreamWriter writer = new StreamWriter(fs)) {

                    writer.Write(token);
                }
            }

        }

        public string ReadTokenInFile() {
            string token = "";
            fileDirectory = Path.Combine(Directory.GetCurrentDirectory(), "../../../info");
            string fileLocation = fileDirectory + filename;


            //then read
            using (var fs = new FileStream(fileLocation, FileMode.Open, FileAccess.Read)) {
                using (var reader = new StreamReader(fs)) {
                    token = reader.ReadToEnd();
                }
            }

                return token;
        }

        public void DeleteTokeAfterLogoutOrCloseTheFrom() {
            fileDirectory = Path.Combine(Directory.GetCurrentDirectory(), "../../../info");
            string fileLocation = fileDirectory + filename;

            File.Delete(fileLocation);
        }
    }
}