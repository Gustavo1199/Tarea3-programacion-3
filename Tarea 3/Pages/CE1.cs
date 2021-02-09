using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Tarea_3.Pages
{
    public class CE1
    {
        public Root traerDato( string cedula)
        {
            WebClient cliente = new WebClient();
            var api = $"https://api.adamix.net/apec/cedula/{cedula}";
            var datos = cliente.DownloadString(api);
            var resultado = JsonConvert.DeserializeObject<Root>(datos);

            return resultado;
        }
    }
}
