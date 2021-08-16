// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Delivery.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/catalog")]
    public partial class Catalog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Catalog.razor"
       
    private IEnumerable<ProductModel> _products;
    private CartModel _cart;
    private IEnumerable<CategoryModel> _categories;

    private int? _selectedCategoryId;

    protected override async Task OnInitializedAsync()
    {
        _products = await _productDataProvider.GetProducts();
        _cart = await _cartDataProvider.GetCart();
        _categories = await _categoryDataProvider.GetCategories();
    }

    private async Task AddProductToCart(ProductModel product)
    {
        if (product != null)
        {
            await _cartDataProvider.AddItem("", product.Id);
        }
    }

    private async Task RemoveProductFromCart(CartItemModel cartItem)
    {
        if (cartItem != null)
        {
            await _cartDataProvider.RemoveItem(_cart.Id, cartItem.Id);
        }
    }

    private string GetProductLink(ProductModel product)
    {
        return "ProductDetail/" + product.Name;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryDataProvider _categoryDataProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartDataProvider _cartDataProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductDataProvider _productDataProvider { get; set; }
    }
}
#pragma warning restore 1591
