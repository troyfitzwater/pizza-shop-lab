#pragma checksum "C:\Users\troyf\Desktop\pizza-shop-lab\PizzaShop\Pages\Admin\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6503b7f9cabe154d59f604010dd4e3c9a0b6fbed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PizzaShop.Pages.Admin.Pages_Admin_Orders), @"mvc.1.0.razor-page", @"/Pages/Admin/Orders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Orders.cshtml", typeof(PizzaShop.Pages.Admin.Pages_Admin_Orders), null)]
namespace PizzaShop.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\troyf\Desktop\pizza-shop-lab\PizzaShop\Pages\_ViewImports.cshtml"
using PizzaShop;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6503b7f9cabe154d59f604010dd4e3c9a0b6fbed", @"/Pages/Admin/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"344d68855a4c7246ddce598105fafac098250e1e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Orders : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\troyf\Desktop\pizza-shop-lab\PizzaShop\Pages\Admin\Orders.cshtml"
  
    ViewData["Title"] = "Orders";

#line default
#line hidden
            BeginContext(91, 56, true);
            WriteLiteral("\r\n<h1>Orders</h1>\r\n<br />\r\n<h2>Incomplete</h2>\r\n<hr />\r\n");
            EndContext();
#line 11 "C:\Users\troyf\Desktop\pizza-shop-lab\PizzaShop\Pages\Admin\Orders.cshtml"
 foreach (var order in Model.PizzaOrders.Where(order => order.IsComplete == false))
{

#line default
#line hidden
            BeginContext(235, 114, true);
            WriteLiteral("    <div class=\"card order-card order-card-incomplete\">\r\n        <div class=\"card-body\">\r\n            <h4>Order: #");
            EndContext();
            BeginContext(350, 8, false);
#line 15 "C:\Users\troyf\Desktop\pizza-shop-lab\PizzaShop\Pages\Admin\Orders.cshtml"
                   Write(order.Id);

#line default
#line hidden
            EndContext();
            BeginContext(358, 28, true);
            WriteLiteral("</h4>\r\n            <p>Size: ");
            EndContext();
            BeginContext(387, 10, false);
#line 16 "C:\Users\troyf\Desktop\pizza-shop-lab\PizzaShop\Pages\Admin\Orders.cshtml"
                Write(order.Size);

#line default
#line hidden
            EndContext();
            BeginContext(397, 31, true);
            WriteLiteral("</p>\r\n            <p>Toppings: ");
            EndContext();
            BeginContext(429, 14, false);
#line 17 "C:\Users\troyf\Desktop\pizza-shop-lab\PizzaShop\Pages\Admin\Orders.cshtml"
                    Write(order.Toppings);

#line default
#line hidden
            EndContext();
            BeginContext(443, 31, true);
            WriteLiteral("</p>\r\n            <p>Quantity: ");
            EndContext();
            BeginContext(475, 14, false);
#line 18 "C:\Users\troyf\Desktop\pizza-shop-lab\PizzaShop\Pages\Admin\Orders.cshtml"
                    Write(order.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(489, 30, true);
            WriteLiteral("</p>\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(519, 169, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6503b7f9cabe154d59f604010dd4e3c9a0b6fbed6735", async() => {
                BeginContext(539, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(553, 118, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6503b7f9cabe154d59f604010dd4e3c9a0b6fbed7130", async() => {
                    BeginContext(649, 13, true);
                    WriteLiteral("Mark Complete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 21 "C:\Users\troyf\Desktop\pizza-shop-lab\PizzaShop\Pages\Admin\Orders.cshtml"
                                                                                     WriteLiteral(order.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(671, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(688, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 24 "C:\Users\troyf\Desktop\pizza-shop-lab\PizzaShop\Pages\Admin\Orders.cshtml"
}

#line default
#line hidden
            BeginContext(705, 42, true);
            WriteLiteral("<br /><br />\r\n<h2>Completed</h2>\r\n<hr />\r\n");
            EndContext();
#line 28 "C:\Users\troyf\Desktop\pizza-shop-lab\PizzaShop\Pages\Admin\Orders.cshtml"
 foreach (var order in Model.PizzaOrders.Where(order => order.IsComplete == true))
{

#line default
#line hidden
            BeginContext(834, 112, true);
            WriteLiteral("    <div class=\"card order-card order-card-complete\">\r\n        <div class=\"card-body\">\r\n            <h4>Order: #");
            EndContext();
            BeginContext(947, 8, false);
#line 32 "C:\Users\troyf\Desktop\pizza-shop-lab\PizzaShop\Pages\Admin\Orders.cshtml"
                   Write(order.Id);

#line default
#line hidden
            EndContext();
            BeginContext(955, 28, true);
            WriteLiteral("</h4>\r\n            <p>Size: ");
            EndContext();
            BeginContext(984, 10, false);
#line 33 "C:\Users\troyf\Desktop\pizza-shop-lab\PizzaShop\Pages\Admin\Orders.cshtml"
                Write(order.Size);

#line default
#line hidden
            EndContext();
            BeginContext(994, 31, true);
            WriteLiteral("</p>\r\n            <p>Toppings: ");
            EndContext();
            BeginContext(1026, 14, false);
#line 34 "C:\Users\troyf\Desktop\pizza-shop-lab\PizzaShop\Pages\Admin\Orders.cshtml"
                    Write(order.Toppings);

#line default
#line hidden
            EndContext();
            BeginContext(1040, 31, true);
            WriteLiteral("</p>\r\n            <p>Quantity: ");
            EndContext();
            BeginContext(1072, 14, false);
#line 35 "C:\Users\troyf\Desktop\pizza-shop-lab\PizzaShop\Pages\Admin\Orders.cshtml"
                    Write(order.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1086, 34, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 38 "C:\Users\troyf\Desktop\pizza-shop-lab\PizzaShop\Pages\Admin\Orders.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaShop.Pages.Admin.OrdersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PizzaShop.Pages.Admin.OrdersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PizzaShop.Pages.Admin.OrdersModel>)PageContext?.ViewData;
        public PizzaShop.Pages.Admin.OrdersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
