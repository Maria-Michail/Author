#pragma checksum "C:\Users\maria\OneDrive\Documents\Rider\293100-Exam-A20\AuthorAPI\AuthorBlazor\Pages\CreateAuthor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81e656073ac5aaa8cb2bd468b1268164b7f6ca79"
// <auto-generated/>
#pragma warning disable 1591
namespace AuthorBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\maria\OneDrive\Documents\Rider\293100-Exam-A20\AuthorAPI\AuthorBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maria\OneDrive\Documents\Rider\293100-Exam-A20\AuthorAPI\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\maria\OneDrive\Documents\Rider\293100-Exam-A20\AuthorAPI\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\maria\OneDrive\Documents\Rider\293100-Exam-A20\AuthorAPI\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\maria\OneDrive\Documents\Rider\293100-Exam-A20\AuthorAPI\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\maria\OneDrive\Documents\Rider\293100-Exam-A20\AuthorAPI\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\maria\OneDrive\Documents\Rider\293100-Exam-A20\AuthorAPI\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\maria\OneDrive\Documents\Rider\293100-Exam-A20\AuthorAPI\AuthorBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\maria\OneDrive\Documents\Rider\293100-Exam-A20\AuthorAPI\AuthorBlazor\_Imports.razor"
using AuthorBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\maria\OneDrive\Documents\Rider\293100-Exam-A20\AuthorAPI\AuthorBlazor\_Imports.razor"
using AuthorBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maria\OneDrive\Documents\Rider\293100-Exam-A20\AuthorAPI\AuthorBlazor\Pages\CreateAuthor.razor"
using AuthorAPI.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\maria\OneDrive\Documents\Rider\293100-Exam-A20\AuthorAPI\AuthorBlazor\Pages\CreateAuthor.razor"
using AuthorBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addAuthor")]
    public partial class CreateAuthor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CreateAuthor</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\maria\OneDrive\Documents\Rider\293100-Exam-A20\AuthorAPI\AuthorBlazor\Pages\CreateAuthor.razor"
                  newAuthor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\maria\OneDrive\Documents\Rider\293100-Exam-A20\AuthorAPI\AuthorBlazor\Pages\CreateAuthor.razor"
                                             HandleValid

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\maria\OneDrive\Documents\Rider\293100-Exam-A20\AuthorAPI\AuthorBlazor\Pages\CreateAuthor.razor"
                                                                            HandleInvalid

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n            ");
                __builder2.AddMarkupContent(10, "<h3 class=\"sectionHeader\">Add Author Information</h3>\r\n            \r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group mx-5");
                __builder2.AddMarkupContent(13, "<label>First Name:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "placeholder", "First Name");
                __builder2.AddAttribute(17, "aria-label", "First Name");
                __builder2.AddAttribute(18, "aria-describedby", "basic-addon1");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\maria\OneDrive\Documents\Rider\293100-Exam-A20\AuthorAPI\AuthorBlazor\Pages\CreateAuthor.razor"
                                                                                                                                              newAuthor.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAuthor.FirstName = __value, newAuthor.FirstName))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAuthor.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group mx-5");
                __builder2.AddMarkupContent(25, "<label>Last Name:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "placeholder", "Last Name");
                __builder2.AddAttribute(29, "aria-label", "Last Name");
                __builder2.AddAttribute(30, "aria-describedby", "basic-addon1");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\maria\OneDrive\Documents\Rider\293100-Exam-A20\AuthorAPI\AuthorBlazor\Pages\CreateAuthor.razor"
                                                                                                                                            newAuthor.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAuthor.LastName = __value, newAuthor.LastName))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAuthor.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.AddMarkupContent(35, "<p class=\"actions \"><button class=\"btn btn-primary registerBtn\" type=\"submit\">Add</button></p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\maria\OneDrive\Documents\Rider\293100-Exam-A20\AuthorAPI\AuthorBlazor\Pages\CreateAuthor.razor"
       
    private string errorMessage;

    private Author newAuthor = new Author();

    public async Task HandleValid()
    {
        errorMessage = "";
        try
        {
            await AuthorService.AddAuthor(newAuthor);
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }

    public async Task HandleInvalid()
    {
        Console.WriteLine("Invalid");
    }

    protected override async Task OnInitializedAsync()
    {
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthorService AuthorService { get; set; }
    }
}
#pragma warning restore 1591
