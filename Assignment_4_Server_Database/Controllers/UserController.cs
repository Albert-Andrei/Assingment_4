using System;
using System.Threading.Tasks;
using Assignment_4_Server_Database.Data;
using Assignment_4_Server_Database.DataAccess;
using Assignment_4_Server_Database.Model;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_4_Server_Database.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetResponse([FromQuery] string? username, [FromQuery] string? password)
        {
            try
            {
                userService.ValidateUser(username,password);
                return Ok(userService.ValidateUser(username,password));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}