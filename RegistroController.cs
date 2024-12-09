using Microsoft.AspNetCore.Mvc;

namespace SofCaps.Controllers
{
    public class RegistroController : Controller
    {
        // Acción para mostrar el formulario
        public IActionResult Registro()
        {
            return View();
        }

        // Acción para procesar los datos enviados
        [HttpPost]
        public IActionResult Guardar(string Nombres, string Apellidos, string Correo, string Telefono)
        {
            // Aquí puedes guardar los datos en la base de datos si es necesario

            // Pasar el mensaje de éxito a la vista
            ViewData["Mensaje"] = "¡Registro exitoso! Gracias por registrarte.";

            // Volver a la vista de registro con el mensaje
            return View("Registro");
        }
    }
}

