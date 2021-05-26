using bronzetti.christian._4h.XamAzure.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bronzetti.christian._4H.XamAzureAPI.Controllers
{   //Decoratore
    [ApiController]
    [Route("[controller]")]
    public class StudentiController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Studente> Get()
        {
            List<Studente> studenti = new List<Studente>();

            studenti.Add(new Studente { Nome = "Christian", Cognome = "Bronzetti", Immagine = "christian.bronzetti.jpg" });
            studenti.Add(new Studente { Nome = "Giammarco", Cognome = "Savini", Immagine = "giammarco.savini.jpg" });

            return studenti;
        }
    }
}