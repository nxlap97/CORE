#pragma checksum "D:\Project\CORE\CORE.Website\Areas\Admin\Views\Pricing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48332ea4afb89795c89bb37c9e633bcc0535ec92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Pricing_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Pricing/Index.cshtml")]
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
#line 4 "D:\Project\CORE\CORE.Website\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Project\CORE\CORE.Website\Areas\Admin\Views\_ViewImports.cshtml"
using CORE.Website.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Project\CORE\CORE.Website\Areas\Admin\Views\_ViewImports.cshtml"
using CORE.Service.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48332ea4afb89795c89bb37c9e633bcc0535ec92", @"/Areas/Admin/Views/Pricing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab3f532bc42019116256ea8f833ca43e84d7ffb4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Pricing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PricingModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Project\CORE\CORE.Website\Areas\Admin\Views\Pricing\Index.cshtml"
  
    ViewBag.Title = "DANH SÁCH BẢNG GIÁ";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-body"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-sm-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h5>DANH SÁCH BẢNG GIÁ</h5>
                    </div>
                    <div class=""table-responsive"">
                        <div class=""div-control-table"">
                            <a class=""btn btn-sm btn-primary"" href=""/Admin/Pricing/AddOrUpdate""><i class=""icon-plus""></i></a>
                        </div>
                        <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                    <th scope=""col"" width=""3%"">STT</th>
                                    <th scope=""col"" width=""25%"">TÊN BẢNG GIÁ</th>
                                    <th scope=""col"" width=""5%"">AVATAR</th>
                                    <th scope=""col"" width=""10%"">TRẠNG THÁI</th>
                ");
            WriteLiteral("                    <th scope=\"col\" width=\"15%\">#</th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 29 "D:\Project\CORE\CORE.Website\Areas\Admin\Views\Pricing\Index.cshtml"
                                 foreach (var item in Model)
                                {
                                    var indexOf = Model.IndexOf(item) + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th scope=\"row\">");
#nullable restore
#line 33 "D:\Project\CORE\CORE.Website\Areas\Admin\Views\Pricing\Index.cshtml"
                                                   Write(indexOf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <td>");
#nullable restore
#line 34 "D:\Project\CORE\CORE.Website\Areas\Admin\Views\Pricing\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><img width=\"50\"");
            BeginWriteAttribute("src", " src=\"", 1677, "\"", 1697, 1);
#nullable restore
#line 35 "D:\Project\CORE\CORE.Website\Areas\Admin\Views\Pricing\Index.cshtml"
WriteAttributeValue("", 1683, item.ImageUrl, 1683, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                                        <td style=\"text-align:center\">");
#nullable restore
#line 36 "D:\Project\CORE\CORE.Website\Areas\Admin\Views\Pricing\Index.cshtml"
                                                                 Write(Html.Raw(!item.Published ? "<b class='text-danger' ><i class='icon-lock'><i></b>" : "<b class='text-primary'><i class='icon-unlock'><i></b>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"tbl-action\">\r\n                                            <a class=\"btn btn-sm btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 2069, "\"", 2111, 2);
            WriteAttributeValue("", 2076, "/Admin/Pricing/AddOrUpdate/", 2076, 27, true);
#nullable restore
#line 38 "D:\Project\CORE\CORE.Website\Areas\Admin\Views\Pricing\Index.cshtml"
WriteAttributeValue("", 2103, item.Id, 2103, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-pencil-alt\"></i></a>\r\n                                            &nbsp;\r\n                                            <a class=\"btn btn-sm btn-danger btn-remove\" data-id=\"");
#nullable restore
#line 40 "D:\Project\CORE\CORE.Website\Areas\Admin\Views\Pricing\Index.cshtml"
                                                                                            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"icon-trash\"></i></a>\r\n");
            WriteLiteral("                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 45 "D:\Project\CORE\CORE.Website\Areas\Admin\Views\Pricing\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        function SaveData() {
            var model = {
                Id: $('#txtId').val(),
                Name: $('#txtName').val(),
                ImageId: $('#txtImageId').val(),
                ShortDescription: $('#txtShortDescription').val(),
                Description: CKEDITOR.instances['txtDescription'].getData(),
                Published: $('#chkPublished').is("":checked""),
            };
            var dataJson = JSON.stringify(model);

            $.ajax({
                type: ""POST"",
                url: '/Admin/Pricing/AddOrUpdateBlog',
                data: { dataJson: dataJson },
                success: function (res) {
                    if (res.status) {
                        alertify.success(res.message);
                        setTimeout(() => {
                            window.location.href = '/Admin/Pricing';
                        }, 1000)
                    }
                    else {
                        alertify.error(res.");
                WriteLiteral(@"message);
                    }
                },
                dataType: 'JSON'
            });
        }

        function RemoveData(selector) {
            var id = selector.data('id');
            var lstId = [];
            lstId.push(id);
            var ids = JSON.stringify(lstId);
            $.ajax({
                type: ""POST"",
                url: '/Admin/Pricing/Delete',
                data: { ids: ids },
                success: function (res) {
                    if (res.status) {
                        alertify.success(res.message);
                        selector.parent().parent().remove();
                    }
                    else
                        alertify.error(res.message);
                },
                dataType: 'JSON'
            });
        }

        $(document).ready(function () {
            $('.btn-remove').click(function (e) {
                e.preventDefault();
                var selector = $(this);
                alertify");
                WriteLiteral(".confirm(\'Thông báo\', \'Chắc chắn muốn xóa dữ liệu này ?\', function () {\r\n                    RemoveData(selector);\r\n                }, function () { });\r\n            });\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PricingModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
