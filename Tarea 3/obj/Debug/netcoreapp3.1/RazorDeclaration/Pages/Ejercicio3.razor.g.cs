// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea_3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Pamela Hernandez\Desktop\Tarea 3\Tarea 3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pamela Hernandez\Desktop\Tarea 3\Tarea 3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pamela Hernandez\Desktop\Tarea 3\Tarea 3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Pamela Hernandez\Desktop\Tarea 3\Tarea 3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Pamela Hernandez\Desktop\Tarea 3\Tarea 3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Pamela Hernandez\Desktop\Tarea 3\Tarea 3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Pamela Hernandez\Desktop\Tarea 3\Tarea 3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Pamela Hernandez\Desktop\Tarea 3\Tarea 3\_Imports.razor"
using Tarea_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Pamela Hernandez\Desktop\Tarea 3\Tarea 3\_Imports.razor"
using Tarea_3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pamela Hernandez\Desktop\Tarea 3\Tarea 3\Pages\Ejercicio3.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pamela Hernandez\Desktop\Tarea 3\Tarea 3\Pages\Ejercicio3.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio3")]
    public partial class Ejercicio3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\Pamela Hernandez\Desktop\Tarea 3\Tarea 3\Pages\Ejercicio3.razor"
       string translation = "";
    string word = "";
    bool d = false;
    public async Task GetTraduccion()
    {
        if (!String.IsNullOrEmpty(word))
        {
            var url = String.Format("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}", "es", "en", Uri.EscapeUriString(word));
            var result = await Http.GetStringAsync(url);
            if (!String.IsNullOrEmpty(result))
            {
                var jsonData = JsonConvert.DeserializeObject<dynamic>(result);
                var translationItems = jsonData[0];
                foreach (object item in translationItems)
                {
                    IEnumerable translationLineObject = item as IEnumerable;
                    IEnumerator translationLineString = translationLineObject.GetEnumerator();
                    translationLineString.MoveNext();
                    translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
                }
                if (translation.Length > 1) { translation = translation.Substring(1); };
            }
        }
        d = true;
    }
    public void limpiar()
    {
        d = false;
        word = "";
        translation = "";
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
