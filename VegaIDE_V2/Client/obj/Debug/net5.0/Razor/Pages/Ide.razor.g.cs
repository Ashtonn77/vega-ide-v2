#pragma checksum "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\Pages\Ide.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4bd222b611c9133277cc03aa28cb74b839bd1fa"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ide")]
    public partial class Ide : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main-container");
            __builder.AddMarkupContent(2, "<h3 class=\"question-name\">Question Name</h3>\r\n\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "top");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\Pages\Ide.razor"
                          editor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\Pages\Ide.razor"
                                                 runCode

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "class", "ide-container");
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(10);
                __builder2.AddAttribute(11, "class", "ide");
                __builder2.AddAttribute(12, "spellcheck", "false");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\Pages\Ide.razor"
                                         editor.Code

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editor.Code = __value, editor.Code))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => editor.Code));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n\r\n            ");
                __builder2.AddMarkupContent(17, "<div class=\"ide-btns\"><button type=\"submit\" class=\"btn btn-primary btn-sm\">Run</button>\r\n                <button type=\"submit\" class=\"btn btn-success btn-sm\">Submit</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n\r\n        ");
            __builder.AddMarkupContent(19, @"<div class=""question-container""><div class=""question"">

                Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
                when an unknown printer took a galley of type and scrambled it to make a type
                specimen book. It has survived not only five centuries, but also the leap into
                electronic typesetting, remaining essentially unchanged. It was popularised in the
                1960s with the release of Letraset sheets containing Lorem Ipsum passages,
                and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.

            </div>

            <div class=""output""><p>Test 1 - OK</p>
                <p>Test 2 - OK</p>
                <p>Test 3 - OK</p>
                <p>Test 4 - OK</p>
                <p>Test 5 - OK</p>
                <p>100% PASSED</p></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n    ");
            __builder.AddMarkupContent(21, "<div class=\"bottom\"><button class=\"btn btn-primary btn-md\">Previous</button>\r\n        <button class=\"btn btn-success btn-md\">Next</button></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\Ashton\OneDrive - Nebula\course-work\VegaIDE_V2\VegaIDE_V2\Client\Pages\Ide.razor"
       

    Editor editor = new Editor();
   
    private async Task runCode()
    {

        await HttpClient.PostAsJsonAsync("api/editor", editor);        
        NavigationManager.NavigateTo("/result");

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
