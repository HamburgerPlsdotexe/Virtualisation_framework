// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace VFrameworkBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\CGU\source\repos\Virtualisation_framework\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CGU\source\repos\Virtualisation_framework\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CGU\source\repos\Virtualisation_framework\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CGU\source\repos\Virtualisation_framework\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CGU\source\repos\Virtualisation_framework\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CGU\source\repos\Virtualisation_framework\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\CGU\source\repos\Virtualisation_framework\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\CGU\source\repos\Virtualisation_framework\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\CGU\source\repos\Virtualisation_framework\_Imports.razor"
using VFrameworkBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\CGU\source\repos\Virtualisation_framework\_Imports.razor"
using VFrameworkBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\CGU\source\repos\Virtualisation_framework\_Imports.razor"
using HashiCorp.Cdktf;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\CGU\source\repos\Virtualisation_framework\_Imports.razor"
using HashiCorp.Cdktf.Providers.Azurerm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CGU\source\repos\Virtualisation_framework\Pages\Index.razor"
using Blazority;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CGU\source\repos\Virtualisation_framework\Pages\Index.razor"
using VFrameworkBlazor.Terraform;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\CGU\source\repos\Virtualisation_framework\Pages\Index.razor"
      
    async Task SynthDefault()
    {
        TfLogic.init();
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "The Terraform files have been generated");
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\CGU\source\repos\Virtualisation_framework\Pages\Index.razor"
       
    async Task warning()
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure?"); // Confirm

        if (confirmed)
        {
            string prompted = await JsRuntime.InvokeAsync<string>("prompt", "thanks"); // Prompt

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
