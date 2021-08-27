#pragma checksum "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\Pages\FrontEndIde.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7f56f96980d34ad487f049fd9de6d0882877ada"
// <auto-generated/>
#pragma warning disable 1591
namespace VegaIDE_V2.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\_Imports.razor"
using VegaIDE_V2.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\_Imports.razor"
using VegaIDE_V2.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\_Imports.razor"
using VegaIDE_V2.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/frontendide")]
    public partial class FrontEndIde : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>

        .front-wrapper{

            height: 100vh;
            width: 100%;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .code-area {
            display: flex;
            flex-direction: column;
            width: 50%;
            border-right: 1px solid #555;
            height: 100%;                        
        }

            .code-area textarea {
                resize: none;
                outline: none;
                width: 100%;
                height: 33.33%;
                font-size: 18px;
                padding: 10px;
            }

        .preview-area {
            width: 50%;
            height: 100%;
        }

            .preview-area iframe {
                width: 100%;
                height: 100%;
                border: none;
                background:#fff;
            }

    </style>

    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "front-wrapper");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "code-area");
            __builder.OpenElement(5, "textarea");
            __builder.AddAttribute(6, "id", "htmlCode");
            __builder.AddAttribute(7, "placeholder", "HTML Code");
            __builder.AddAttribute(8, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\Pages\FrontEndIde.razor"
                                                                      showPreview

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n            ");
            __builder.OpenElement(10, "textarea");
            __builder.AddAttribute(11, "id", "cssCode");
            __builder.AddAttribute(12, "placeholder", "CSS Code");
            __builder.AddAttribute(13, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\Pages\FrontEndIde.razor"
                                                                    showPreview

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n            ");
            __builder.OpenElement(15, "textarea");
            __builder.AddAttribute(16, "id", "jsCode");
            __builder.AddAttribute(17, "placeholder", "JavaScript Code");
            __builder.AddAttribute(18, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\Pages\FrontEndIde.razor"
                                                                          showPreview

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n        ");
            __builder.AddMarkupContent(20, "<div class=\"preview-area\"><iframe id=\"preview-window\"></iframe></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\Pages\FrontEndIde.razor"
        


    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        await jsRuntime.InvokeVoidAsync("start");
    }

    private async Task showPreview()
    {
        await jsRuntime.InvokeVoidAsync("showPreview2");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591