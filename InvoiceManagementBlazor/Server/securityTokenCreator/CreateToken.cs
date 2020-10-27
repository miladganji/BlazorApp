using InvoiceManagementBlazor.Server.Interfaceas;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementBlazor.securityTokenCreator
{
    public  class CreateToken
    {
        private readonly IUserRepository userRepository;

        public  string encrypKey { get; set; }
        public string SecurityKey { get; set; }

        public CreateToken(string SecurityKey,string encrypKey, IUserRepository userRepository)
        {
            this.SecurityKey = SecurityKey;
            this.encrypKey = encrypKey;
            this.userRepository = userRepository;
        }

       

        public string Execute(string username,string password)
        {


            if (userRepository.GetUser(username, password)!=null)
            {
                var secretKey = Encoding.UTF8.GetBytes(SecurityKey); // must be 16 character or longer
                var signingCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKey), SecurityAlgorithms.HmacSha256Signature);

                var encryptionkey = Encoding.UTF8.GetBytes(encrypKey); //must be 16 character
                var encryptingCredentials = new EncryptingCredentials(new SymmetricSecurityKey(encryptionkey), SecurityAlgorithms.Aes128KW, SecurityAlgorithms.Aes128CbcHmacSha256);

                var claims = new List<Claim>
                {
                   new Claim(ClaimTypes.Name, username), //user.UserName
                   new Claim(ClaimTypes.NameIdentifier, username), //user.Id
                   new Claim(ClaimTypes.Role,"Admin"),
                   new Claim("Password",password)


                };

                var descriptor = new SecurityTokenDescriptor
                {
                    Issuer = "milad ganji",
                    Audience = "readers",
                    EncryptingCredentials = encryptingCredentials,
                    Expires = DateTime.Now.AddHours(1),
                    IssuedAt = DateTime.Now,
                    SigningCredentials = signingCredentials,
                    Subject = new ClaimsIdentity(claims),

                };

                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(descriptor);
                string encryptedJwt = tokenHandler.WriteToken(securityToken);
                return encryptedJwt;
            }

            else {
                throw new Exception("User not found");
            }

            
        }
    }
}
