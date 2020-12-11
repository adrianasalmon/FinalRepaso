using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiOperacion.Controllers
{
    public class OperacionController : ApiController
    {
        // GET api/values/5
        // GET api/values/5
        /*public string Get(int id)
        {
            return "value";
        }*/
        public string Get(int id)
        {
            
            if (id < 0)
            {
                return "Error";
            }
            if(id == 0)
            {
                return "Realizado por Adriana";
            }
            return "Usted ingreso el numero:" + id.ToString();
        }
    }
}
