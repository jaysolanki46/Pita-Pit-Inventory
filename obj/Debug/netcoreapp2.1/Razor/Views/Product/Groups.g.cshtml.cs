#pragma checksum "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f91e2231d227019ef54d6ae03b3d982857458e1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Groups), @"mvc.1.0.view", @"/Views/Product/Groups.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Groups.cshtml", typeof(AspNetCore.Views_Product_Groups))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91e2231d227019ef54d6ae03b3d982857458e1c", @"/Views/Product/Groups.cshtml")]
    public class Views_Product_Groups : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml"
   
    string GroupId = "";
    string GroupName = "";

    if(Model.Group != null)
    {
        foreach(Pita_Pit_Inventory.Models.Groups item in Model.Group)
        {
            GroupId = item.GroupId.ToString();
            GroupName = item.GroupName;
        }
    }

#line default
#line hidden
            BeginContext(305, 39, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(344, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "628669cc938548b387ede27c6adcda33", async() => {
                BeginContext(350, 44, true);
                WriteLiteral("\r\n    <title>Pita Pit - Groups</title>\r\n    ");
                EndContext();
                BeginContext(395, 42, false);
#line 21 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml"
Write(Html.Partial("~/Views/Shared/Header.html"));

#line default
#line hidden
                EndContext();
                BeginContext(437, 2, true);
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
            BeginContext(446, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(450, 6306, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fdf4f2c709246439e2c6f105cc9dfb4", async() => {
                BeginContext(470, 89, true);
                WriteLiteral("\r\n\r\n    <!-- Page Wrapper -->\r\n    <div id=\"wrapper\">\r\n        <!-- Sidebar -->\r\n        ");
                EndContext();
                BeginContext(560, 39, false);
#line 29 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml"
   Write(Html.Partial("~/Views/Shared/Nav.html"));

#line default
#line hidden
                EndContext();
                BeginContext(599, 252, true);
                WriteLiteral("\r\n\r\n        <!-- End of Sidebar -->\r\n        <!-- Content Wrapper -->\r\n        <div id=\"content-wrapper\" class=\"d-flex flex-column\">\r\n\r\n            <!-- Main Content -->\r\n            <div id=\"content\">\r\n                <!-- Topbar -->\r\n                ");
                EndContext();
                BeginContext(852, 45, false);
#line 38 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml"
           Write(Html.Partial("~/Views/Shared/StatusBar.html"));

#line default
#line hidden
                EndContext();
                BeginContext(897, 1239, true);
                WriteLiteral(@"
                <!-- End of Topbar -->
                <!-- Begin Page Content -->
                <div class=""container-fluid"">
                    <form name=""group-form"" id=""group-form"" action=""Groups/AddGroup"" method=""post"">
                        <!-- Content Row -->

                        <h1 class=""h3 mb-2 text-gray-800"">Group</h1>

                        <div class=""mb-4"">
                            <div class=""row"">
                                <div class=""col-lg-12"">
                                    <div class=""card o-hidden border-0 shadow-lg my-0"">
                                        <div class=""card-body p-0"">
                                            <!-- Nested Row within Card Body -->
                                            <div class=""row"">
                                                <div class=""col-lg-12"">
                                                    <div class=""p-lg-3"">
                                                        <b><label>Group");
                WriteLiteral("</label></b><hr />\r\n                                                        <div class=\"form-group mr-2\">\r\n                                                            <input type=\"hidden\" id=\"groupId\" name=\"groupId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2136, "\"", 2152, 1);
#line 58 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml"
WriteAttributeValue("", 2144, GroupId, 2144, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2153, 272, true);
                WriteLiteral(@">
                                                            <label for=""groupName"">Name</label> &nbsp;&nbsp;
                                                            <input type=""text"" class=""form-control"" id=""groupName"" name=""groupName"" placeholder=""Ex. Beverages""");
                EndContext();
                BeginWriteAttribute("value", "\r\n                                                                   value=\"", 2425, "\"", 2511, 1);
#line 61 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml"
WriteAttributeValue("", 2501, GroupName, 2501, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2512, 298, true);
                WriteLiteral(@">
                                                        </div>

                                                        <button type=""submit"" class=""btn btn-primary"">ADD</button> &nbsp;&nbsp;
                                                        <button type=""button"" class=""btn btn-danger""");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 2810, "\"", 2868, 3);
                WriteAttributeValue("", 2820, "location.href=\'", 2820, 15, true);
#line 65 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml"
WriteAttributeValue("", 2835, Url.Action("Groups", "Product"), 2835, 32, false);

#line default
#line hidden
                WriteAttributeValue("", 2867, "\'", 2867, 1, true);
                EndWriteAttribute();
                BeginContext(2869, 468, true);
                WriteLiteral(@" >CANCEL</button>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </form>

                    <!-- DataTales Example -->
");
                EndContext();
#line 78 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml"
                     if (Model.Groups != null && Model.Group == null)
                    {

#line default
#line hidden
                BeginContext(3431, 1295, true);
                WriteLiteral(@"                        <div class=""card shadow mb-4"">
                            <div class=""card-header py-3"">
                                <h6 class=""m-0 font-weight-bold text-primary"">Group List</h6>
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
 ");
                WriteLiteral(@"                                               <th>Name</th>
                                                <th></th>
                                            </tr>
                                        </tfoot>
                                        <tbody>
");
                EndContext();
#line 102 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml"
                                             foreach (var item in Model.Groups)
                                            {
                                                var id = @item.GroupId;
                                                

#line default
#line hidden
                BeginContext(4975, 62, true);
                WriteLiteral("<tr>\r\n                                                    <td>");
                EndContext();
                BeginContext(5038, 2, false);
#line 106 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml"
                                                   Write(id);

#line default
#line hidden
                EndContext();
                BeginContext(5040, 63, true);
                WriteLiteral("</td>\r\n                                                    <td>");
                EndContext();
                BeginContext(5104, 14, false);
#line 107 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml"
                                                   Write(item.GroupName);

#line default
#line hidden
                EndContext();
                BeginContext(5118, 123, true);
                WriteLiteral("</td>\r\n                                                    <td>\r\n                                                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5241, "\"", 5264, 2);
                WriteAttributeValue("", 5248, "Groups/Group/", 5248, 13, true);
#line 109 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml"
WriteAttributeValue("", 5261, id, 5261, 3, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5265, 265, true);
                WriteLiteral(@" class=""btn btn-info float-sm-left btn-circle btn-sm"">
                                                            <i class=""fas fa-edit""></i>
                                                        </a>
                                                        <a");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 5530, "\"", 5552, 3);
                WriteAttributeValue("", 5540, "Confirm(", 5540, 8, true);
#line 112 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml"
WriteAttributeValue("", 5548, id, 5548, 3, false);

#line default
#line hidden
                WriteAttributeValue("", 5551, ")", 5551, 1, true);
                EndWriteAttribute();
                BeginContext(5553, 325, true);
                WriteLiteral(@" class=""btn btn-danger float-sm-right btn-circle btn-sm"">
                                                            <i class=""fas fa-trash""></i>
                                                        </a>
                                                    </td>
                                                </tr>
");
                EndContext();
#line 117 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml"
                                            }

#line default
#line hidden
                BeginContext(5925, 204, true);
                WriteLiteral("                                        </tbody>\r\n                                    </table>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
                EndContext();
#line 123 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml"
                    }

#line default
#line hidden
                BeginContext(6152, 171, true);
                WriteLiteral("\r\n\r\n                    <!-- /.container-fluid -->\r\n                </div>\r\n                <!-- End of Main Content -->\r\n                <!-- Footer -->\r\n                ");
                EndContext();
                BeginContext(6324, 42, false);
#line 130 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml"
           Write(Html.Partial("~/Views/Shared/footer.html"));

#line default
#line hidden
                EndContext();
                BeginContext(6366, 334, true);
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
                BeginContext(6701, 44, false);
#line 144 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml"
   Write(Html.Partial("~/Views/Shared/FooterJS.html"));

#line default
#line hidden
                EndContext();
                BeginContext(6745, 4, true);
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
            BeginContext(6756, 914, true);
            WriteLiteral(@"

</html>

<script>
    function Confirm(deleteId) {
        Swal.fire({
            title: 'Delete group?',
            text: ""You won't be able to recover this!"",
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes, delete it'
        }).then((result) => {
            if (result.value) {
                $.get(""/Product/Groups/DeleteGroup/"" + deleteId, function (data, status) {
                        swal({
                            title: ""Deleted!"",
                            text: ""Group has been deleted."",
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
#line 176 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml"
 if (ViewData["Status"] != null)
{

#line default
#line hidden
            BeginContext(7707, 36, true);
            WriteLiteral("    <script>\r\n        var status = \"");
            EndContext();
            BeginContext(7744, 18, false);
#line 179 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml"
                 Write(ViewData["Status"]);

#line default
#line hidden
            EndContext();
            BeginContext(7762, 1095, true);
            WriteLiteral(@""";

        window.onload = function ()
        {
            ShowMessage();
        };

        function ShowMessage()
        {
            if (status == ""Success"")
            {
                swal({
                    title: ""Good job!"",
                    text: ""Group has been added"",
                    type: ""success"",
                    confirmButtonClass: ""btn btn-success mt-2""
                });
            }
            else if (status == ""Error"") {
                swal({
                    title: ""Whoops!"",
                    text: ""An error has occurred"",
                    type: ""error"",
                    confirmButtonClass: ""btn btn-danger btn-sm"",
                    footer: ""<a>Please try Again</a>""
                });
            }
            else {
                swal({
                    title: ""Uh oh!"",
                    text: ""Something happened?"",
                    type: ""warning"",
                    confirmButtonClass: ""btn btn-warning ");
            WriteLiteral("btn-sm\"\r\n                });\r\n            }\r\n        }\r\n    </script>\r\n");
            EndContext();
#line 216 "C:\Users\jayso\source\repos\Pita Pit Inventory\Views\Product\Groups.cshtml"
}

#line default
#line hidden
            BeginContext(8860, 2, true);
            WriteLiteral("\r\n");
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
