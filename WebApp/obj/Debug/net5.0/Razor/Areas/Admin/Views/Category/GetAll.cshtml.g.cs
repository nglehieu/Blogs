#pragma checksum "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4450225ed7b602353155913517d63a6dde345c7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_GetAll), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/GetAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4450225ed7b602353155913517d63a6dde345c7a", @"/Areas/Admin/Views/Category/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Category_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Core.Domain.Entities.Category>>
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
#nullable restore
#line 2 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
  
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4450225ed7b602353155913517d63a6dde345c7a4827", async() => {
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
");
            WriteLiteral("                                    <th>\r\n                                        ");
#nullable restore
#line 38 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
                                   Write(Html.DisplayNameFor(model => model.uuid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 41 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
                                   Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 44 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
                                   Write(Html.DisplayNameFor(model => model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 50 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n");
            WriteLiteral("                                        <td>\r\n                                            ");
#nullable restore
#line 57 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
                                       Write(item.uuid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 60 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 63 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4450225ed7b602353155913517d63a6dde345c7a10535", async() => {
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
#line 67 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
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
            WriteLiteral("\r\n                                            <button id=\"deleted\" type=\"button\" class=\"text-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3790, "\"", 3824, 3);
            WriteAttributeValue("", 3800, "deleteItem(\'", 3800, 12, true);
#nullable restore
#line 68 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
WriteAttributeValue("", 3812, item.uuid, 3812, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3822, "\')", 3822, 2, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"background: transparent; border: none; font-weight: 700; \">Delete</button>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 71 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
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
#line 95 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Core.Domain.Entities.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591