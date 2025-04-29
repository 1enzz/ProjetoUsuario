using Microsoft.AspNetCore.Mvc;
using ProjetoUsuarios.Services;
using ProjetoUsuarios.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjetoUsuarios.Controllers
{
    
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;

        public UserController(UserService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _service.GetAllUsers();
            return Ok(users);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var users = _service.GetUserById(id);

            if (users == null) return NotFound();

            return Ok(users);
        }


        [HttpPost]
        public IActionResult Create([FromBody] User user)
        {
            _service.CreateUser(user);
            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] User user)
        {
            if(id != user.Id)
            {
                return BadRequest("Ids não correspondentes");
            }

            var existingUser = _service.GetUserById(id);
            if(existingUser == null)
            {
                return NotFound();
            }
            _service.UpdateUser(user);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _service.GetUserById(id);
            if (user == null) return NotFound();

            _service.DeleteUser(id);
            return NoContent();
        }
    }
}
