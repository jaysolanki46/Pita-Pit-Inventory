#pragma checksum "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Supplier\ViewSuppliers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d45863efd163071535bbd1ce9fde18ebe057484"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Supplier_ViewSuppliers), @"mvc.1.0.view", @"/Views/Supplier/ViewSuppliers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Supplier/ViewSuppliers.cshtml", typeof(AspNetCore.Views_Supplier_ViewSuppliers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d45863efd163071535bbd1ce9fde18ebe057484", @"/Views/Supplier/ViewSuppliers.cshtml")]
    public class Views_Supplier_ViewSuppliers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-gray-100 float-sm-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Supplier/New"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(37, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "796602fd00ec4454a2f68a7d050d589b", async() => {
                BeginContext(43, 47, true);
                WriteLiteral("\r\n    <title>Pita Pit - Suppliers</title>\r\n    ");
                EndContext();
                BeginContext(91, 42, false);
#line 6 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Supplier\ViewSuppliers.cshtml"
Write(Html.Partial("~/Views/Shared/Header.html"));

#line default
#line hidden
                EndContext();
                BeginContext(133, 2, true);
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
            BeginContext(142, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(146, 4739, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ba5a8e64d2e475788ba235b87fa9abe", async() => {
                BeginContext(166, 89, true);
                WriteLiteral("\r\n\r\n    <!-- Page Wrapper -->\r\n    <div id=\"wrapper\">\r\n        <!-- Sidebar -->\r\n        ");
                EndContext();
                BeginContext(256, 39, false);
#line 14 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Supplier\ViewSuppliers.cshtml"
   Write(Html.Partial("~/Views/Shared/Nav.html"));

#line default
#line hidden
                EndContext();
                BeginContext(295, 252, true);
                WriteLiteral("\r\n\r\n        <!-- End of Sidebar -->\r\n        <!-- Content Wrapper -->\r\n        <div id=\"content-wrapper\" class=\"d-flex flex-column\">\r\n\r\n            <!-- Main Content -->\r\n            <div id=\"content\">\r\n                <!-- Topbar -->\r\n                ");
                EndContext();
                BeginContext(548, 45, false);
#line 23 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Supplier\ViewSuppliers.cshtml"
           Write(Html.Partial("~/Views/Shared/StatusBar.html"));

#line default
#line hidden
                EndContext();
                BeginContext(593, 436, true);
                WriteLiteral(@"
                <!-- End of Topbar -->
                <!-- Begin Page Content -->
                <div class=""container-fluid"">

                    <!-- Content Row -->

                    <h1 class=""h3 mb-2 text-gray-800"">Suppliers</h1>

                    <!-- DataTales Example -->
                    <div class=""card shadow mb-4"">
                        <div class=""card-header py-1"">
                            ");
                EndContext();
                BeginContext(1029, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6c3ced77d3b468393597b326afbcc5d", async() => {
                    BeginContext(1107, 9, true);
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
                BeginContext(1120, 3322, true);
                WriteLiteral(@"
                        </div>
                        <div class=""card-body"">
                            <div class=""table-responsive"">
                                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                    <thead>
                                        <tr>
                                            <th>Code</th>
                                            <th>Name</th>
                                            <th>Product List</th>
                                            <th></th>
                                        </tr>
                                    </thead>
                                    <tfoot>
                                        <tr>

                                            <th>Code</th>
                                            <th>Name</th>
                                            <th>Product List</th>
                                            <th></th>
          ");
                WriteLiteral(@"                              </tr>
                                    </tfoot>
                                    <tbody>
                                        <tr>
                                            <td>02145</td>
                                            <td>John Tailor</td>
                                            <td>Chicken, Coc, Mango Juice...</td>
                                            <td>
                                                <a href=""#"" class=""btn btn-info float-sm-left btn-circle btn-sm"">
                                                    <i class=""fas fa-edit""></i>
                                                </a>
                                                <a href=""#"" class=""btn btn-danger float-sm-right btn-circle btn-sm"">
                                                    <i class=""fas fa-trash""></i>
                                                </a>
                                            </td>
                                    ");
                WriteLiteral(@"    </tr>
                                        <tr>
                                            <td>9512</td>
                                            <td>Manish Manhotra</td>
                                            <td>Latus, Tomatoes, Banana...</td>
                                            <td>
                                                <a href=""#"" class=""btn btn-info float-sm-left btn-circle btn-sm"">
                                                    <i class=""fas fa-edit""></i>
                                                </a>
                                                <a href=""#"" class=""btn btn-danger float-sm-right btn-circle btn-sm"">
                                                    <i class=""fas fa-trash""></i>
                                                </a>
                                            </td>
                                        </tr>

                                    </tbody>
                                </table>
               ");
                WriteLiteral("             </div>\r\n                        </div>\r\n                    </div>\r\n\r\n                    <!-- /.container-fluid -->\r\n                </div>\r\n                <!-- End of Main Content -->\r\n                <!-- Footer -->\r\n                ");
                EndContext();
                BeginContext(4443, 42, false);
#line 95 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Supplier\ViewSuppliers.cshtml"
           Write(Html.Partial("~/Views/Shared/footer.html"));

#line default
#line hidden
                EndContext();
                BeginContext(4485, 344, true);
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
    </div>

        ");
                EndContext();
                BeginContext(4830, 44, false);
#line 109 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Supplier\ViewSuppliers.cshtml"
   Write(Html.Partial("~/Views/Shared/FooterJS.html"));

#line default
#line hidden
                EndContext();
                BeginContext(4874, 4, true);
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
            BeginContext(4885, 17, true);
            WriteLiteral("\r\n\r\n</html>\r\n\r\n\r\n");
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
