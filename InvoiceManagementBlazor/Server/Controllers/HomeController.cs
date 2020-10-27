using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using InvoiceManagementBlazor.securityTokenCreator;
using InvoiceManagementBlazor.Server.Interfaceas;
using InvoiceManagementBlazor.Shared.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace InvoiceManagementBlazor.Server.Controllers
{


    public class LoginData
    {
        public string username { get; set; }
        public string Password { get; set; }

    }
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IUserRepository userRepository;

        public HomeController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePerson(User user)
        {
           
            try
            {
                Claim
                var res =await userRepository.CreateUser(user);
                return Ok(res);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }


        [HttpPost]
        public IActionResult CreateToken( LoginData input)
        {

            try
            {
                var Token = new CreateToken("LongerThan-16Char-SecretKey", "16CharEncryptKey", userRepository).Execute(input.username, input.Password);



                return Ok(Token);
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }

        }

    }
}
