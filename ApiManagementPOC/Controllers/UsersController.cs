using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiManagementPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUser(int id)
        {
            return Ok("User ID was " + id);
        }

        [HttpGet("/{id}/details")]
        public IActionResult GetUserDetails(int id)
        {
            return Ok("Detailed ID " + id);
        }

        [HttpPut]
        public IActionResult CreateUser(User user)
        {
            return Ok("User Created was: " + JsonConvert.SerializeObject(user));
        }
    }

    public class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}