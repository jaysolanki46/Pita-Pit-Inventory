#pragma checksum "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Locations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "554d82eadad3eb8c94a7cfadc8b185304555b0cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Locations), @"mvc.1.0.view", @"/Views/Product/Locations.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Locations.cshtml", typeof(AspNetCore.Views_Product_Locations))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"554d82eadad3eb8c94a7cfadc8b185304555b0cf", @"/Views/Product/Locations.cshtml")]
    public class Views_Product_Locations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(37, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc7bfb831d984fae8035f6d00b1ee772", async() => {
                BeginContext(43, 47, true);
                WriteLiteral("\r\n    <title>Pita Pit - Locations</title>\r\n    ");
                EndContext();
                BeginContext(91, 42, false);
#line 6 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Locations.cshtml"
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
            BeginContext(146, 6076, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f6c0c2027d645f9b2b735d229e94bd5", async() => {
                BeginContext(166, 89, true);
                WriteLiteral("\r\n\r\n    <!-- Page Wrapper -->\r\n    <div id=\"wrapper\">\r\n        <!-- Sidebar -->\r\n        ");
                EndContext();
                BeginContext(256, 39, false);
#line 14 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Locations.cshtml"
   Write(Html.Partial("~/Views/Shared/Nav.html"));

#line default
#line hidden
                EndContext();
                BeginContext(295, 252, true);
                WriteLiteral("\r\n\r\n        <!-- End of Sidebar -->\r\n        <!-- Content Wrapper -->\r\n        <div id=\"content-wrapper\" class=\"d-flex flex-column\">\r\n\r\n            <!-- Main Content -->\r\n            <div id=\"content\">\r\n                <!-- Topbar -->\r\n                ");
                EndContext();
                BeginContext(548, 45, false);
#line 23 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Locations.cshtml"
           Write(Html.Partial("~/Views/Shared/StatusBar.html"));

#line default
#line hidden
                EndContext();
                BeginContext(593, 5196, true);
                WriteLiteral(@"
                <!-- End of Topbar -->
                <!-- Begin Page Content -->
                <div class=""container-fluid"">

                    <!-- Content Row -->

                    <h1 class=""h3 mb-2 text-gray-800"">Location</h1>

                    <div class=""mb-4"">
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <div class=""card o-hidden border-0 shadow-lg my-0"">
                                    <div class=""card-body p-0"">
                                        <!-- Nested Row within Card Body -->
                                        <div class=""row"">
                                            <div class=""col-lg-12"">
                                                <div class=""p-lg-5"">
                                                    <form class=""form-inline"">
                                                        <div class=""form-group mr-2"">
                                            ");
                WriteLiteral(@"                <label for=""groupName"">Name</label> &nbsp;&nbsp;
                                                            <input type=""text"" class=""form-control"" id=""groupName"" placeholder=""Ex. Chiller"">
                                                        </div>
                                                        <button type=""submit"" class=""btn btn-primary"">ADD</button> &nbsp;&nbsp;
                                                        <button type=""reset"" class=""btn btn-danger"">CANCEL</button>
                                                    </form>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>

                    <!-- DataTales Example -->
                    <div class=""card shadow mb-4"">
    ");
                WriteLiteral(@"                    <div class=""card-header py-3"">
                            <h6 class=""m-0 font-weight-bold text-primary"">Location List</h6>
                        </div>
                        <div class=""card-body"">
                            <div class=""table-responsive"">
                                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                    <thead>
                                        <tr>
                                            <th>#</th>
                                            <th>Name</th>
                                            <th></th>
                                        </tr>
                                    </thead>
                                    <tfoot>
                                        <tr>
                                            <th>#</th>
                                            <th>Name</th>
                                            <th></th>
        ");
                WriteLiteral(@"                                </tr>
                                    </tfoot>
                                    <tbody>
                                        <tr>
                                            <td>9854</td>
                                            <td>Chiller</td>
                                            <td>
                                                <a href=""#"" class=""btn btn-info float-sm-left btn-circle btn-sm"">
                                                    <i class=""fas fa-edit""></i>
                                                </a>
                                                <a href=""#"" class=""btn btn-danger float-sm-right btn-circle btn-sm"">
                                                    <i class=""fas fa-trash""></i>
                                                </a>
                                            </td>
                                        </tr>
                                        <tr>
                             ");
                WriteLiteral(@"               <td>8547</td>
                                            <td>Fridge</td>
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
                            </div>
                        </div>
                    </div>

                    <!-- /.container-fluid -->
                </div>
                <!-");
                WriteLiteral("- End of Main Content -->\r\n                <!-- Footer -->\r\n                ");
                EndContext();
                BeginContext(5790, 42, false);
#line 118 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Locations.cshtml"
           Write(Html.Partial("~/Views/Shared/footer.html"));

#line default
#line hidden
                EndContext();
                BeginContext(5832, 334, true);
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
                BeginContext(6167, 44, false);
#line 132 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Locations.cshtml"
   Write(Html.Partial("~/Views/Shared/FooterJS.html"));

#line default
#line hidden
                EndContext();
                BeginContext(6211, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6222, 17, true);
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
