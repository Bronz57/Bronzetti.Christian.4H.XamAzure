using System;
using System.Collections.Generic;
using System.Text;

namespace bronzetti.christian._4h.XamAzure.Models
{
    public class Studente
    {
        public string Nome { get; set; }

        public string Cognome { get; set; }

        public string NomeCognome
        {
            get
            {
                return $"{Nome} {Cognome}";
            }
        }

        public string Dettagli { get; set; }

        public string Immagine { get; set; }
        public string URLImmagine
        {
            get
            {
                return @"https://bronzetti-christian-4h-xamazureapi.conveyor.cloud/Images/" + Immagine;
            }
        }
    }
}
