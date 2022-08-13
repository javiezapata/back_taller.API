using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;



namespace back_taller.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {

        [HttpGet(Name = "GetProfesor")]
        public ActionResult GetProfesor(string name)
        {
            return  Ok(new
            {
                hola = $"Hola mundo, {name}"
            });
        }
    }
}
