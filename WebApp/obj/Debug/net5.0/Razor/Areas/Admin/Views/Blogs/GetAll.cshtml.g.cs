#pragma checksum "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Blogs\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8d073394febdb2ccb0dec78079a8274e75266a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blogs_GetAll), @"mvc.1.0.view", @"/Areas/Admin/Views/Blogs/GetAll.cshtml")]
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
#line 1 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8d073394febdb2ccb0dec78079a8274e75266a9", @"/Areas/Admin/Views/Blogs/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Blogs_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Core.Domain.Entities.Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Blogs\GetAll.cshtml"
  
    ViewData["Title"] = "GetAll";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-wrapper"">
    <div class=""row grid-margin"">
        <div class=""col-12"">
            <div class=""card"">
                <div class=""card-body"">
                    <h6 class=""card-title"">Order status</h6>
                    <div class=""d-flex table-responsive"">
                        <div class=""btn-group mr-2"">
                            <button class=""btn btn-sm btn-info""><i class=""mdi mdi-plus-circle-outline""></i> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8d073394febdb2ccb0dec78079a8274e75266a94840", async() => {
                WriteLiteral("Add");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</button>
                        </div>
                        <div class=""btn-group mr-2"">
                            <button type=""button"" class=""btn btn-light""><i class=""mdi mdi-alert-circle-outline""></i></button>
                            <button type=""button"" class=""btn btn-light""><i class=""mdi mdi-delete-empty""></i></button>
                        </div>
                        <div class=""btn-group mr-2"">
                            <button type=""button"" class=""btn btn-light""><i class=""mdi mdi-printer""></i></button>
                        </div>
                        <div class=""btn-group ml-auto mr-2 border-0"">
                            <input type=""text"" class=""form-control"" placeholder=""Search Here"">
                        </div>
                        <div class=""btn-group"">
                            <button type=""button"" class=""btn btn-light""><i class=""mdi mdi-cloud""></i></button>
                            <button type=""button"" class=""btn btn-light""><i class=""mdi mdi");
            WriteLiteral(@"-dots-vertical""></i></button>
                        </div>
                    </div>
                    <div class=""table-responsive"">
                        <table class=""table mt-3 border-top"">
                            <thead>
                                <tr>
                                    <td>
                                        Id
                                    </td>
                                    <th>
                                        ");
#nullable restore
#line 39 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Blogs\GetAll.cshtml"
                                   Write(Html.DisplayNameFor(model => model.title));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 42 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Blogs\GetAll.cshtml"
                                   Write(Html.DisplayNameFor(model => model.content));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                                    </th>\r\n");
            WriteLiteral("                                    <th>\r\n                                        ");
#nullable restore
#line 48 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Blogs\GetAll.cshtml"
                                   Write(Html.DisplayNameFor(model => model.image));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 51 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Blogs\GetAll.cshtml"
                                   Write(Html.DisplayNameFor(model => model.author));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 54 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Blogs\GetAll.cshtml"
                                   Write(Html.DisplayNameFor(model => model.categoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                                    </th>\r\n");
            WriteLiteral("                                    <th></th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 63 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Blogs\GetAll.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 67 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Blogs\GetAll.cshtml"
                                   Write(item.uuid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 70 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Blogs\GetAll.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 73 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Blogs\GetAll.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n");
            WriteLiteral("                                    <td>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 4239, "\"", 4292, 2);
            WriteAttributeValue("", 4245, "https://localhost:5001/upload/posts/", 4245, 36, true);
#nullable restore
#line 79 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Blogs\GetAll.cshtml"
WriteAttributeValue("", 4281, item.image, 4281, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 40px\" />\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 82 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Blogs\GetAll.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 85 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Blogs\GetAll.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.categoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n");
            WriteLiteral("                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8d073394febdb2ccb0dec78079a8274e75266a913008", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Blogs\GetAll.cshtml"
                                                                                           WriteLiteral(item.uuid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <button id=\"deleted\" type=\"button\" class=\"text-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5139, "\"", 5173, 3);
            WriteAttributeValue("", 5149, "deleteItem(\'", 5149, 12, true);
#nullable restore
#line 92 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Blogs\GetAll.cshtml"
WriteAttributeValue("", 5161, item.uuid, 5161, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5171, "\')", 5171, 2, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"background: transparent; border: none; font-weight: 700; \">Delete</button>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 95 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Blogs\GetAll.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                    <div class=""d-flex align-items-center justify-content-between flex-column flex-sm-row mt-4"">
                        <p class=""mb-3 mb-sm-0"">Showing 1 to 20 of 20 entries</p>
                        <nav>
                            <ul class=""pagination pagination-info mb-0"">
                                <li class=""page-item""><a class=""page-link""><i class=""mdi mdi-chevron-left""></i></a></li>
                                <li class=""page-item active""><a class=""page-link"">1</a></li>
                                <li class=""page-item""><a class=""page-link"">2</a></li>
                                <li class=""page-item""><a class=""page-link"">3</a></li>
                                <li class=""page-item""><a class=""page-link"">4</a></li>
                                <li class=""page-item""><a class=""page-link""><i class=""mdi mdi-chevron-right""></i></a></li>
                      ");
            WriteLiteral("      </ul>\r\n                        </nav>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 119 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Blogs\GetAll.cshtml"
   await Html.RenderPartialAsync("_ValidationScriptsPartial"); 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    function deleteItem(uuid) {
        Swal.fire({
            title: 'Xác nhận xóa?',
            text: ""Bạn có chắc sẽ xóa danh mục này?"",
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Xóa!'
        }).then((result) => {
            if (result.isConfirmed) {
                window.location.href = '/admin/category/delete-category/' + uuid;
                Swal.fire(
                    'Xóa thành công!',
                    '',
                    'success'
                )
                setTimeout(function () {
                    $(""#deleted"").submit();
                }, 2000);
            }
        })
    }
</script>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Core.Domain.Entities.Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
