#pragma checksum "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\ViewProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "384840686240a27816ce5b1d91aeb19e0b65254e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ViewProducts), @"mvc.1.0.view", @"/Views/Product/ViewProducts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/ViewProducts.cshtml", typeof(AspNetCore.Views_Product_ViewProducts))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"384840686240a27816ce5b1d91aeb19e0b65254e", @"/Views/Product/ViewProducts.cshtml")]
    public class Views_Product_ViewProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-gray-100 float-sm-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Product/New"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 39, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(55, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14a1bb98f4134bd799d188ef1ada36f6", async() => {
                BeginContext(61, 46, true);
                WriteLiteral("\r\n    <title>Pita Pit - Products</title>\r\n    ");
                EndContext();
                BeginContext(108, 42, false);
#line 8 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\ViewProducts.cshtml"
Write(Html.Partial("~/Views/Shared/Header.html"));

#line default
#line hidden
                EndContext();
                BeginContext(150, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(159, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(163, 5129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acb39d00755c460cbd54fd86e03c9e56", async() => {
                BeginContext(183, 89, true);
                WriteLiteral("\r\n\r\n    <!-- Page Wrapper -->\r\n    <div id=\"wrapper\">\r\n        <!-- Sidebar -->\r\n        ");
                EndContext();
                BeginContext(273, 39, false);
#line 16 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\ViewProducts.cshtml"
   Write(Html.Partial("~/Views/Shared/Nav.html"));

#line default
#line hidden
                EndContext();
                BeginContext(312, 252, true);
                WriteLiteral("\r\n\r\n        <!-- End of Sidebar -->\r\n        <!-- Content Wrapper -->\r\n        <div id=\"content-wrapper\" class=\"d-flex flex-column\">\r\n\r\n            <!-- Main Content -->\r\n            <div id=\"content\">\r\n                <!-- Topbar -->\r\n                ");
                EndContext();
                BeginContext(565, 45, false);
#line 25 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\ViewProducts.cshtml"
           Write(Html.Partial("~/Views/Shared/StatusBar.html"));

#line default
#line hidden
                EndContext();
                BeginContext(610, 454, true);
                WriteLiteral(@"
                <!-- End of Topbar -->
                <!-- Begin Page Content -->
                <div class=""container-fluid"">

                    <!-- Content Row -->

                    <h1 class=""h3 mb-2 text-gray-800"">Products</h1>                   

                    <!-- DataTales Example -->
                    <div class=""card shadow mb-4"">
                        <div class=""card-header py-1"">
                            ");
                EndContext();
                BeginContext(1064, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8115a8a7ce742d8a79c7e9002ec39ed", async() => {
                    BeginContext(1141, 9, true);
                    WriteLiteral("+ ADD NEW");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1154, 1772, true);
                WriteLiteral(@"
                        </div>
                        <div class=""card-body"">
                            <div class=""table-responsive"">
                                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                    <thead>
                                        <tr>
                                            <th>SKU</th>
                                            <th>Name</th>
                                            <th>Price</th>
                                            <th>Pack Size</th>
                                            <th>Qty In Pack</th>
                                            <th>Location</th>
                                            <th>Group</th>
                                            <th>Perishable</th>
                                            <th></th>
                                        </tr>
                                    </thead>
                                 ");
                WriteLiteral(@"   <tfoot>
                                        <tr>
                                            <th>SKU</th>
                                            <th>Name</th>
                                            <th>Price</th>
                                            <th>Pack Size</th>
                                            <th>Qty In Pack</th>
                                            <th>Location</th>
                                            <th>Group</th>
                                            <th>Perishable</th>
                                            <th></th>
                                        </tr>
                                    </tfoot>
                                    <tbody>

");
                EndContext();
#line 70 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\ViewProducts.cshtml"
                                         foreach (var item in Model.Products)
                                        {
                                            var id = @item.Id;
                                            

#line default
#line hidden
                BeginContext(3156, 58, true);
                WriteLiteral("<tr>\r\n                                                <td>");
                EndContext();
                BeginContext(3215, 8, false);
#line 74 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\ViewProducts.cshtml"
                                               Write(item.Sku);

#line default
#line hidden
                EndContext();
                BeginContext(3223, 59, true);
                WriteLiteral("</td>\r\n                                                <td>");
                EndContext();
                BeginContext(3283, 9, false);
#line 75 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\ViewProducts.cshtml"
                                               Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(3292, 59, true);
                WriteLiteral("</td>\r\n                                                <td>");
                EndContext();
                BeginContext(3352, 10, false);
#line 76 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\ViewProducts.cshtml"
                                               Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(3362, 59, true);
                WriteLiteral("</td>\r\n                                                <td>");
                EndContext();
                BeginContext(3422, 13, false);
#line 77 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\ViewProducts.cshtml"
                                               Write(item.PackSize);

#line default
#line hidden
                EndContext();
                BeginContext(3435, 59, true);
                WriteLiteral("</td>\r\n                                                <td>");
                EndContext();
                BeginContext(3495, 14, false);
#line 78 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\ViewProducts.cshtml"
                                               Write(item.QtyInPack);

#line default
#line hidden
                EndContext();
                BeginContext(3509, 59, true);
                WriteLiteral("</td>\r\n                                                <td>");
                EndContext();
                BeginContext(3569, 13, false);
#line 79 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\ViewProducts.cshtml"
                                               Write(item.Location);

#line default
#line hidden
                EndContext();
                BeginContext(3582, 59, true);
                WriteLiteral("</td>\r\n                                                <td>");
                EndContext();
                BeginContext(3642, 10, false);
#line 80 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\ViewProducts.cshtml"
                                               Write(item.Group);

#line default
#line hidden
                EndContext();
                BeginContext(3652, 59, true);
                WriteLiteral("</td>\r\n                                                <td>");
                EndContext();
                BeginContext(3712, 17, false);
#line 81 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\ViewProducts.cshtml"
                                               Write(item.IsPerishable);

#line default
#line hidden
                EndContext();
                BeginContext(3729, 115, true);
                WriteLiteral("</td>\r\n                                                <td>\r\n                                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3844, "\"", 3871, 2);
                WriteAttributeValue("", 3851, "View/EditProduct/", 3851, 17, true);
#line 83 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\ViewProducts.cshtml"
WriteAttributeValue("", 3868, id, 3868, 3, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3872, 253, true);
                WriteLiteral(" class=\"btn btn-info float-sm-left btn-circle btn-sm\">\r\n                                                        <i class=\"fas fa-edit\"></i>\r\n                                                    </a>\r\n                                                    <a");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 4125, "\"", 4147, 3);
                WriteAttributeValue("", 4135, "Confirm(", 4135, 8, true);
#line 86 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\ViewProducts.cshtml"
WriteAttributeValue("", 4143, id, 4143, 3, false);

#line default
#line hidden
                WriteAttributeValue("", 4146, ")", 4146, 1, true);
                EndWriteAttribute();
                BeginContext(4148, 310, true);
                WriteLiteral(@" class=""btn btn-danger float-sm-right btn-circle btn-sm"">
                                                        <i class=""fas fa-trash""></i>
                                                    </a>
                                                </td>
                                             </tr>
");
                EndContext();
#line 91 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\ViewProducts.cshtml"
                                         }

#line default
#line hidden
                BeginContext(4502, 357, true);
                WriteLiteral(@"                                        </tbody>
                                </table>
                            </div>
                        </div>
                    </div>

                    <!-- /.container-fluid -->
                </div>
                <!-- End of Main Content -->
                <!-- Footer -->
                ");
                EndContext();
                BeginContext(4860, 42, false);
#line 102 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\ViewProducts.cshtml"
           Write(Html.Partial("~/Views/Shared/footer.html"));

#line default
#line hidden
                EndContext();
                BeginContext(4902, 334, true);
                WriteLiteral(@"
                <!-- End of Footer -->

            </div>
            <!-- End of Content Wrapper -->

        </div>
        <!-- End of Page Wrapper -->
        <!-- Scroll to Top Button-->
        <a class=""scroll-to-top rounded"" href=""#page-top"">
            <i class=""fas fa-angle-up""></i>
        </a>


        ");
                EndContext();
                BeginContext(5237, 44, false);
#line 116 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\ViewProducts.cshtml"
   Write(Html.Partial("~/Views/Shared/FooterJS.html"));

#line default
#line hidden
                EndContext();
                BeginContext(5281, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5292, 875, true);
            WriteLiteral(@"

</html>

<script>
    function Confirm(deleteId) {
        Swal.fire({
            title: 'Delete product?',
            text: ""You won't be able to recover this!"",
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes, delete it'
        }).then((result) => {
            if (result.value) {
                $.get(""View/DeleteProduct/"" + deleteId, function (data, status) {
                    swal({
                        title: ""Deleted!"",
                        text: ""Product has been deleted."",
                        type: ""success""
                    }).then(function () {
                        location.reload();
                    });
                });
            }
        });
    }
</script>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
