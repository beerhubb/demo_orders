#pragma checksum "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5da66c2d282f871beb6b1cc659d6e68c2088b293"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ACER\Desktop\demo_\demo_\Views\_ViewImports.cshtml"
using demo_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\Desktop\demo_\demo_\Views\_ViewImports.cshtml"
using demo_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5da66c2d282f871beb6b1cc659d6e68c2088b293", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ac3fb6af5f1957fa5ffa4f870f8856025e68d33", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<demo_.Models.Orders>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" type=""text/css"" href=""//cdn.datatables.net/1.10.20/css/dataTables.bootstrap4.min.css"" />
<link rel=""stylesheet"" type=""text/css"" href=""//cdn.datatables.net/fixedheader/3.1.6/css/fixedHeader.bootstrap4.min.css"" />

<h1>OrderList</h1>

<p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5da66c2d282f871beb6b1cc659d6e68c2088b2934218", async() => {
                WriteLiteral("Order New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table id=\"dataTable\" class=\"table table-striped table-bordered dt-responsive nowrap\" width=\"100%\" cellspacing=\"0\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Orders_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Orderdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
           Write(Html.DisplayName("Freight"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Orders_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 40 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
                     if (item.Customers == "1") { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
                                             Write(Html.DisplayName("Customer ID"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
                                                                                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
                     if (item.Customers == "2") { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
                                             Write(Html.DisplayName("Company Name"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
                                                                                   }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
                     if (item.Customers == "3") { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
                                             Write(Html.DisplayName("Contact Name"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
                                                                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Orderdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
               Write(Html.ActionLink("Update", "Edit", new {  id=item.Orders_ID },new { @Class="btn btn-warning"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 49 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new {  id=item.Orders_ID },new { @Class="btn btn-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\ACER\Desktop\demo_\demo_\Views\Orders\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script type=""text/javascript"" src=""//cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js""></script>
    <script type=""text/javascript"" src=""//cdn.datatables.net/1.10.20/js/dataTables.bootstrap4.min.js""></script>
    <script>
        $(document).ready(function () {
            $(""#dataTable"").dataTable({
                ""searching"": true,
                ""ordering"": true,
                ""paging"": true,
                ""pagingType"": ""full_numbers"",
                ""pageLength"": 10,
                ""responsive"": true,
                ""columnDefs"": [{
                    ""targets"": 3,
                    ""orderable"": false
                }]
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<demo_.Models.Orders>> Html { get; private set; }
    }
}
#pragma warning restore 1591
