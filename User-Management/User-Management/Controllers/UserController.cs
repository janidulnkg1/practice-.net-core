using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using User_Management.Models;

namespace User_Management.Controllers
{

    [ApiController]
    public class UserController : ControllerBase
    {
        private static List<UserDto> listUsers = new List<UserDto>()
        {
            new UserDto()
            {
                firstName = "Janidu",
                lastName  = "Lankage",
                email = "janidulnkg1@gmail.com",
                phone = "0762200954",
                address = "Colombo, Sri Lanka"
            },
            new UserDto()
            {
                firstName = "Dinushika",
                lastName  = "Samarasingha",
                email = "sdinushika99@gmail.com",
                phone = "0742146066",
                address = "Colombo, Sri Lanka"
            }


        };

        [HttpGet("/users")]
        public IActionResult GetUsers()
        {
            if(listUsers.Count > 0)
            {
                return Ok(listUsers);
            }
            return NoContent();
        }

        [HttpGet("/user/get/{id}")]
        public IActionResult GetUser(int id)
        {
            if (id >= 0 && id < listUsers.Count)
            {
                return Ok(listUsers[id]);
            }
            return NotFound();
        }

        [HttpPost("/user/create")]
        public IActionResult AddUser(UserDto user)
        {
            if( user.email.Equals("user@example.com"))
            {
                ModelState.AddModelError("Email", "This Email is not authorized");
                return BadRequest(ModelState);
            }

            listUsers.Add(user);
            return Ok();
        }

        [HttpPut("/user/update/{id}")]
        public IActionResult UpdateUser(int id, UserDto user)
        {
            if (user.email.Equals("user@example.com"))
            {
                ModelState.AddModelError("Email", "This Email is not authorized");
                return BadRequest(ModelState);
            }

            if (id >= 0 && id <= listUsers.Count)
            {
                listUsers[id] = user;
            }
            return Ok();
        }

        [HttpDelete("/user/delete/{id}")]
        public IActionResult DeleteUser(int id) { 
            if(id >= 0 && id < listUsers.Count)
            {
                listUsers.RemoveAt(id);
            }

            return NoContent();
        }
    }
}
