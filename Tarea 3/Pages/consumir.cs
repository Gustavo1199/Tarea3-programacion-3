using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Tarea_3.Pages
{
    public class consumir
    {

        public Root traer(string cedula)
        {
            try
            {
                WebClient cliente = new WebClient();
                string api = $"https://api.adamix.net/apec/cedula/{cedula}";
                string datos = cliente.DownloadString(api);
                var resultado = JsonConvert.DeserializeObject<Root>(datos);
                return resultado;

            }
            catch (Exception)
            {

                throw;
            }
               
           
        }

    }
}
