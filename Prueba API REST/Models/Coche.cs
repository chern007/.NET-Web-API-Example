using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba_API_REST.Models
{
    public class Coche
    {     
        public string marca { get; set; }
        public string modelo { get; set; }
        public string matricula { get; set; }
        public string color { get; set; }
        public string dueño { get; set; }     
        

        public Coche() { }

        public Coche(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;

        }

        public override string ToString() => marca + "  " + modelo;

    }

}