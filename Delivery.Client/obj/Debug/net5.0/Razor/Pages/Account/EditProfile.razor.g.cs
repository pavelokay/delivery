#pragma checksum "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cdafa52aacfdcc0cced4b48d65ee60a76845e63"
// <auto-generated/>
#pragma warning disable 1591
namespace Delivery.Client.Pages.Account
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
#line 3 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor"
using Application.Models.Account;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/account/editProfile")]
    public partial class EditProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Profile</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-4");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor"
                         _editUserModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor"
                                                        HandleUpdateUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "class", "card card-body bg-light mt-5");
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group row");
                __builder2.AddMarkupContent(16, "<label for=\"username\" class=\"col-md-2 col-form-label\">Имя пользователя:</label>\r\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "disabled", true);
                __builder2.AddAttribute(21, "type", "text");
                __builder2.AddAttribute(22, "id", "username");
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor"
                                                                                                    _editUserModel.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _editUserModel.UserName = __value, _editUserModel.UserName))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _editUserModel.UserName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\r\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group row");
                __builder2.AddMarkupContent(30, "<label for=\"password\" class=\"col-md-2 col-form-label\">Пароль:</label>\r\n                ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "type", "password");
                __builder2.AddAttribute(35, "id", "password");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor"
                                                                                               _editUserModel.OldPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _editUserModel.OldPassword = __value, _editUserModel.OldPassword))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _editUserModel.OldPassword));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n            ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group row");
                __builder2.AddMarkupContent(43, "<label for=\"change-password\" class=\"col-md-2 col-form-label\">Изменить пароль?</label>\r\n                ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "type", "checkbox");
                __builder2.AddAttribute(48, "id", "change-password");
                __builder2.AddAttribute(49, "class", "form-control");
                __builder2.AddAttribute(50, "onactivate", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor"
                                                                                                         e => _editUserModel.ChangePassword = true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ondeactivate", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor"
                                                                                                                                                                       e => _editUserModel.ChangePassword = false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 35 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor"
             if (_editUserModel.ChangePassword)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group row");
                __builder2.AddMarkupContent(54, "<label for=\"new-password\" class=\"col-md-2 col-form-label\">Новый пароль:</label>\r\n                    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(57);
                __builder2.AddAttribute(58, "type", "password");
                __builder2.AddAttribute(59, "id", "new-password");
                __builder2.AddAttribute(60, "class", "form-control");
                __builder2.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor"
                                                                                                       _editUserModel.NewPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _editUserModel.NewPassword = __value, _editUserModel.NewPassword))));
                __builder2.AddAttribute(63, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _editUserModel.NewPassword));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group row");
                __builder2.AddMarkupContent(66, "<label for=\"confirm\" class=\"col-md-2 col-form-label\">Подтверждение пароля:</label>\r\n                    ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(69);
                __builder2.AddAttribute(70, "type", "password");
                __builder2.AddAttribute(71, "id", "confirm");
                __builder2.AddAttribute(72, "class", "form-control");
                __builder2.AddAttribute(73, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor"
                                                                                                  _editUserModel.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _editUserModel.ConfirmPassword = __value, _editUserModel.ConfirmPassword))));
                __builder2.AddAttribute(75, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _editUserModel.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 50 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "form-group row");
                __builder2.AddMarkupContent(78, "<label for=\"firstname\" class=\"col-md-2 col-form-label\">Имя:</label>\r\n                ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(81);
                __builder2.AddAttribute(82, "id", "firstname");
                __builder2.AddAttribute(83, "class", "form-control");
                __builder2.AddAttribute(84, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor"
                                                                                _editUserModel.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _editUserModel.FirstName = __value, _editUserModel.FirstName))));
                __builder2.AddAttribute(86, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _editUserModel.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n\r\n            ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "form-group row");
                __builder2.AddMarkupContent(90, "<label for=\"lastname\" class=\"col-md-2 col-form-label\">Фамилия:</label>\r\n                ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(93);
                __builder2.AddAttribute(94, "id", "lastname");
                __builder2.AddAttribute(95, "class", "form-control");
                __builder2.AddAttribute(96, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor"
                                                                               _editUserModel.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(97, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _editUserModel.LastName = __value, _editUserModel.LastName))));
                __builder2.AddAttribute(98, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _editUserModel.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n\r\n            ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "form-group row");
                __builder2.AddMarkupContent(102, "<label for=\"email\" class=\"col-md-2 col-form-label\">Email:</label>\r\n                ");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(105);
                __builder2.AddAttribute(106, "disabled", true);
                __builder2.AddAttribute(107, "type", "email");
                __builder2.AddAttribute(108, "id", "email");
                __builder2.AddAttribute(109, "class", "form-control");
                __builder2.AddAttribute(110, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 69 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor"
                                                                                                  _editUserModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(111, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _editUserModel.Email = __value, _editUserModel.Email))));
                __builder2.AddAttribute(112, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _editUserModel.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n\r\n            ");
                __builder2.OpenElement(114, "div");
                __builder2.AddAttribute(115, "class", "form-group row");
                __builder2.AddMarkupContent(116, "<label for=\"phone\" class=\"col-md-2 col-form-label\">Телефон:</label>\r\n                ");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(119);
                __builder2.AddAttribute(120, "type", "phone");
                __builder2.AddAttribute(121, "id", "phone");
                __builder2.AddAttribute(122, "class", "form-control");
                __builder2.AddAttribute(123, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 76 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor"
                                                                                         _editUserModel.Phone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(124, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _editUserModel.Phone = __value, _editUserModel.Phone))));
                __builder2.AddAttribute(125, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _editUserModel.Phone));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\r\n\r\n            ");
                __builder2.OpenElement(127, "div");
                __builder2.AddAttribute(128, "class", "form-group row");
                __builder2.AddMarkupContent(129, "<label for=\"city\" class=\"col-md-2 col-form-label\">Город:</label>\r\n                ");
                __builder2.OpenElement(130, "div");
                __builder2.AddAttribute(131, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(132);
                __builder2.AddAttribute(133, "id", "city");
                __builder2.AddAttribute(134, "class", "form-control");
                __builder2.AddAttribute(135, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 83 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor"
                                                                           _editUserModel.Address.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(136, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _editUserModel.Address.City = __value, _editUserModel.Address.City))));
                __builder2.AddAttribute(137, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _editUserModel.Address.City));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n\r\n            ");
                __builder2.OpenElement(139, "div");
                __builder2.AddAttribute(140, "class", "form-group row");
                __builder2.AddMarkupContent(141, "<label for=\"address\" class=\"col-md-2 col-form-label\">Адрес:</label>\r\n                ");
                __builder2.OpenElement(142, "div");
                __builder2.AddAttribute(143, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(144);
                __builder2.AddAttribute(145, "id", "address");
                __builder2.AddAttribute(146, "class", "form-control");
                __builder2.AddAttribute(147, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 90 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor"
                                                                              _editUserModel.Address.AddressLine

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(148, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _editUserModel.Address.AddressLine = __value, _editUserModel.Address.AddressLine))));
                __builder2.AddAttribute(149, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _editUserModel.Address.AddressLine));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(150, "\r\n\r\n            ");
                __builder2.OpenElement(151, "div");
                __builder2.AddAttribute(152, "class", "form-group row");
                __builder2.AddMarkupContent(153, "<label for=\"company\" class=\"col-md-2 col-form-label\">Компания:</label>\r\n                ");
                __builder2.OpenElement(154, "div");
                __builder2.AddAttribute(155, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(156);
                __builder2.AddAttribute(157, "id", "company");
                __builder2.AddAttribute(158, "class", "form-control");
                __builder2.AddAttribute(159, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 97 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor"
                                                                              _editUserModel.Address.CompanyName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(160, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _editUserModel.Address.CompanyName = __value, _editUserModel.Address.CompanyName))));
                __builder2.AddAttribute(161, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _editUserModel.Address.CompanyName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(162, "\r\n\r\n            ");
                __builder2.OpenElement(163, "div");
                __builder2.AddAttribute(164, "class", "form-group row");
                __builder2.AddMarkupContent(165, "<label for=\"zip\" class=\"col-md-2 col-form-label\">Почтовый индекс:</label>\r\n                ");
                __builder2.OpenElement(166, "div");
                __builder2.AddAttribute(167, "class", "col-md-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(168);
                __builder2.AddAttribute(169, "type", "text");
                __builder2.AddAttribute(170, "id", "zip");
                __builder2.AddAttribute(171, "class", "form-control");
                __builder2.AddAttribute(172, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 104 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor"
                                                                                      _editUserModel.Address.ZipCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(173, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _editUserModel.Address.ZipCode = __value, _editUserModel.Address.ZipCode))));
                __builder2.AddAttribute(174, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _editUserModel.Address.ZipCode));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(175, "\r\n\r\n            ");
                __builder2.AddMarkupContent(176, "<div><div class=\"col-md-12 text-right\"><button type=\"submit\" class=\"btn btn-success\">Редактировать</button></div></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 118 "C:\Users\Pavel\source\repos\Delivery\Delivery.Client\Pages\Account\EditProfile.razor"
       
    private EditUserModel _editUserModel = new EditUserModel();

    public async Task HandleUpdateUser()
    {
        await _authenticationDataProvider.UpdateUser(_editUserModel);
        _navigationManager.NavigateTo("/account/profile");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationDataProvider _authenticationDataProvider { get; set; }
    }
}
#pragma warning restore 1591