#pragma checksum "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b8a14faca4ccc646e664030ebe1ffea4ea1fc89"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b8a14faca4ccc646e664030ebe1ffea4ea1fc89", @"/Areas/Admin/Views/Category/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Category_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Core.Domain.Entities.Category>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: flex;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b8a14faca4ccc646e664030ebe1ffea4ea1fc896360", async() => {
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
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b8a14faca4ccc646e664030ebe1ffea4ea1fc898207", async() => {
                WriteLiteral("\r\n                                <div>\r\n                                    <input id=\"myInput\" type=\"text\" name=\"s\" class=\"form-control\" placeholder=\"Search Here\"");
                BeginWriteAttribute("value", " value=\"", 1475, "\"", 1493, 1);
#nullable restore
#line 25 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
WriteAttributeValue("", 1483, ViewBag.s, 1483, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                                <div>
                                    <input type=""submit"" class=""btn btn-success"" value=""Tìm kiếm"" style=""padding: 12px; margin-left: 2px;"">
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""btn-group"">
                            <button type=""button"" class=""btn btn-light""><i class=""mdi mdi-cloud""></i></button>
                            <button type=""button"" class=""btn btn-light""><i class=""mdi mdi-dots-vertical""></i></button>
                        </div>
                    </div>
                    <div class=""table-responsive"">
                        <table class=""table mt-3 border-top"">
                            <thead>
                                <tr>
");
            WriteLiteral(@"                                    <th>
                                        Id
                                    </th>
                                    <th>
                                        Tên danh mục
                                    </th>
                                    <th>
                                        Mô tả danh mục
                                    </th>

                                </tr>
                            </thead>
                            <tbody id=""myTable"">
");
#nullable restore
#line 57 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n");
            WriteLiteral("                                        <td>\r\n                                            <div");
            BeginWriteAttribute("class", " class=\"", 3481, "\"", 3510, 1);
#nullable restore
#line 64 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
WriteAttributeValue("", 3489, item.uuid.ToString(), 3489, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none;\">");
#nullable restore
#line 64 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
                                                                                                 Write(item.uuid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 3604, "\"", 3655, 3);
            WriteAttributeValue("", 3614, "copyToClipboard(\'.", 3614, 18, true);
#nullable restore
#line 65 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
WriteAttributeValue("", 3632, item.uuid.ToString(), 3632, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3653, "\')", 3653, 2, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"background: transparent; border: none;\"><i class=\"icon-docs menu-icon\"></i></button>\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 68 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"text\">\r\n                                            ");
#nullable restore
#line 71 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b8a14faca4ccc646e664030ebe1ffea4ea1fc8914865", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
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
            WriteLiteral("|\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b8a14faca4ccc646e664030ebe1ffea4ea1fc8917334", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
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
            WriteLiteral("|\r\n                                            <button id=\"deleted\" type=\"button\" class=\"text-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4587, "\"", 4621, 3);
            WriteAttributeValue("", 4597, "deleteItem(\'", 4597, 12, true);
#nullable restore
#line 77 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
WriteAttributeValue("", 4609, item.uuid, 4609, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4619, "\')", 4619, 2, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"background: transparent; border: none; font-weight: 700; \">Delete</button>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 80 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
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
#line 104 "E:\19. PROJECTDEMOSOLUTION\NinePlus.Blogs\WebApp\Areas\Admin\Views\Category\GetAll.cshtml"
   await Html.RenderPartialAsync("_ValidationScriptsPartial"); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
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

        // Copy uuid to clipboard
        function copyToClipboard(element) {
            var $temp = $(""<input>"");
            $(""body"").append($temp);
           ");
                WriteLiteral(@" $temp.val($(element).text()).select();
            document.execCommand(""copy"");
            $temp.remove();
            showSuccessToast('Copy uuid thành công!')

        }
    </script>

    <script>
        $(document).ready(function () {
            $(""#myInput"").on(""keyup"", function () {
                var value = $(this).val().toLowerCase();
                $(""#myTable tr"").filter(function () {
                    $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                });
            });
        });
    </script>

    <script>
        (function ($) {
            showSuccessToast = function (title) {
                'use strict';
                resetToastPosition();
                $.toast({
                    heading: 'Success',
                    text: title,
                    showHideTransition: 'slide',
                    icon: 'success',
                    loaderBg: '#f96868',
                    position: 'top-right'
                ");
                WriteLiteral(@"})
            };
            showDangerToast = function () {
                'use strict';
                resetToastPosition();
                $.toast({
                    heading: 'Danger',
                    text: 'And these were just the basic demos! Scroll down to check further details on how to customize the output.',
                    showHideTransition: 'slide',
                    icon: 'error',
                    loaderBg: '#f2a654',
                    position: 'top-right'
                })
            };
            resetToastPosition = function () {
                $('.jq-toast-wrap').removeClass('bottom-left bottom-right top-left top-right mid-center'); // to remove previous position class
                $("".jq-toast-wrap"").css({ ""top"": """", ""left"": """", ""bottom"": """", ""right"": """" }); //to remove previous position style
            }

        })(jQuery);
    </script>
");
            }
            );
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
