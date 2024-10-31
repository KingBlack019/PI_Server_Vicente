using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PI_Vicente.Services;
using PI_Vicente.ViewModels;
using ProyectoIntegradoVMS.Models;

namespace PI_Vicente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context) { 
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] Usuario usuario)
        {
            // Simulamos la validación del usuario.
            if (usuario.Nombre == "v" && usuario.Contrasena == "v")
            {
                // Devuelve un token simulado
                return Ok(new { Token = "fake-jwt-token" });
            }

            return Unauthorized();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Verificar si el usuario ya existe
            if (await _context.Usuarios.AnyAsync(u => u.Nombre == viewModel.Username))
            {
                return Conflict("El nombre de usuario ya está en uso.");
            }

            // Crear el nuevo usuario
            var user = new Usuario
            {
                Nombre = viewModel.Username,
                Apellido1 = viewModel.Apellido1,
                Apellido2 = viewModel.Apellido2,
                Email = viewModel.Email,
                NumTelefono = viewModel.NumTelefono,
                Contrasena = viewModel.Password // Aquí deberías aplicar hashing a la contraseña en producción
            };

            _context.Usuario.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Register), new { id = user.Id }, user);
        }
    }
    }
}
