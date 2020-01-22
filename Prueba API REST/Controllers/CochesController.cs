using Newtonsoft.Json.Linq;
using Prueba_API_REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba_API_REST.Controllers
{
    public class CochesController : ApiController
    {

        // GET api/values
        [HttpGet]
        public IEnumerable<Coche> dameCoches()
        {
            return fabricaCoches();
        }

        // GET api/values/5
        [HttpGet]
        [Route("api/coches/{id?}")]
        public string Get(int id)
        {
            return id.ToString();
        }

        //// POST api/values
        //[HttpPost]
        //[Route("api/coches")]
        //public string dameCochesPost([FromBody]string json)
        //{

        //    /*OBJETO PARA PROBAR DESDE POSTMAN

        //    {
        //     modelo: "mazda 3",
        //     objeto: {clave1: "esta es la clave 1"}
        //    }

        //    */

        //    JObject jObject = JObject.Parse(json);

        //    return (string)jObject["modelo"];

        //}

        // POST api/values
        [HttpPost]
        [Route("api/coches")]
        public string dameCochesPost([FromBody]JObject json)
        {

            /*OBJETO PARA PROBAR DESDE POSTMAN

            "{
                modelo: \"mazda 3\",
                objeto: {clave1: \"esta es la clave 1\"}
            }"
            */

            return (string)json["modelo"];

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/values/5
        public void Delete(int id)
        {

        }

        private IEnumerable<Coche> fabricaCoches()
        {
            List<Coche> coches = new List<Coche>();

            coches.Add(new Coche { marca = "peugeot", modelo = "308" });
            coches.Add(new Coche { marca = "renault", modelo = "megane" });
            coches.Add(new Coche { marca = "seat", modelo = "ibiza" });
            coches.Add(new Coche { marca = "mazda", modelo = "3" });

            return coches;
        }



    }
}
