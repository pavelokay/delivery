#pragma checksum "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Admin\AdminPanel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6dd8bf7b566a2736599b06bb16dd276eb919354"
// <auto-generated/>
#pragma warning disable 1591
namespace Delivery.Client.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\_Imports.razor"
using Delivery.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\_Imports.razor"
using Delivery.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\_Imports.razor"
using Delivery.Application.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\_Imports.razor"
using Delivery.Client.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\_Imports.razor"
using Delivery.Client.CustomComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\_Imports.razor"
using Delivery.Client.Services.Account.Base;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Admin\AdminPanel.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Admin\AdminPanel.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class AdminPanel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Администрирование</h3>\r\n\r\n");
            __builder.OpenElement(1, "ul");
            __builder.AddAttribute(2, "class", "nav");
            __builder.OpenElement(3, "li");
            __builder.AddAttribute(4, "class", "nav-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(5);
            __builder.AddAttribute(6, "class", "nav-link");
            __builder.AddAttribute(7, "href", "adminCatalog");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "<span>Просмотр товаров</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "li");
            __builder.AddAttribute(12, "class", "nav-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(13);
            __builder.AddAttribute(14, "class", "nav-link");
            __builder.AddAttribute(15, "href", "addProduct");
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(17, "<span>Добавить товар в каталог</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "li");
            __builder.AddAttribute(20, "class", "nav-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(21);
            __builder.AddAttribute(22, "class", "nav-link");
            __builder.AddAttribute(23, "href", "manageUsers");
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span>Управление пользователями</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591