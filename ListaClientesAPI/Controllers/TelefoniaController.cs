using ListaClientesAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ListaClientesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelefoniaController : ControllerBase
    {
        private static List<Telefonia> _telefonia = new List<Telefonia>
        {
            new Telefonia
            {
               Id = 1,
               Nombre = "Claro",
               Servicios = ServiciosAOfrecer.MinutosMegasInternet
            },
            new Telefonia
            {
               Id = 2,
               Nombre = "Movistar",
               Servicios = ServiciosAOfrecer.MinutosMegasInternetServiciosAdicionales
            },
            new Telefonia
            {
               Id = 3,
               Nombre = "Tuenti",
               Servicios = ServiciosAOfrecer.MinutosMegas
            }
        };
        [HttpGet]
        public IEnumerable<Telefonia> GetAllTelefonia()
        {
            return _telefonia;
        }

    }
    
}
