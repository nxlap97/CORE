#pragma checksum "D:\Project\CORE\CORE.Website\Areas\Admin\Views\Shared\Components\HeaderAdmin\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21b4afcab977e0ad3f3ee0b50af858c9e8129c50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_HeaderAdmin_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/HeaderAdmin/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21b4afcab977e0ad3f3ee0b50af858c9e8129c50", @"/Areas/Admin/Views/Shared/Components/HeaderAdmin/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab3f532bc42019116256ea8f833ca43e84d7ffb4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_HeaderAdmin_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline search-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin-site/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"page-header\">\r\n    <div class=\"header-wrapper row m-0\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21b4afcab977e0ad3f3ee0b50af858c9e8129c505870", async() => {
                WriteLiteral(@"
            <div class=""form-group w-100"">
                <div class=""Typeahead Typeahead--twitterUsers"">
                    <div class=""u-posRelative"">
                        <input class=""demo-input Typeahead-input form-control-plaintext w-100"" type=""text"" placeholder=""Search Cuba .."" name=""q""");
                BeginWriteAttribute("title", " title=\"", 445, "\"", 453, 0);
                EndWriteAttribute();
                WriteLiteral(@" autofocus>
                        <div class=""spinner-border Typeahead-spinner"" role=""status""><span class=""sr-only"">Loading...</span></div><i class=""close-search"" data-feather=""x""></i>
                    </div>
                    <div class=""Typeahead-menu""></div>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"header-logo-wrapper\">\r\n            <div class=\"logo-wrapper\"><a href=\"index.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "21b4afcab977e0ad3f3ee0b50af858c9e8129c508382", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a></div>
            <div class=""toggle-sidebar""><i class=""status_toggle middle sidebar-toggle"" data-feather=""sliders""></i></div>
        </div>
        <div class=""left-header col horizontal-wrapper pl-0"">
            <ul class=""horizontal-menu"">
                <li class=""mega-menu outside"">
                    <a class=""nav-link"" href=""#!""><i data-feather=""layers""></i><span>Bonus Ui</span></a>
                    <div class=""mega-menu-container nav-submenu menu-to-be-close"">
                        <div class=""container-fluid"">
                            <div class=""row"">
                                <div class=""col mega-box"">
                                    <div class=""mobile-title d-none"">
                                        <h5>Mega menu</h5><i data-feather=""x""></i>
                                    </div>
                                    <div class=""link-section icon"">
                                        <div>
                                            <h6>Error ");
            WriteLiteral(@"Page</h6>
                                        </div>
                                        <ul>
                                            <li><a href=""error-400.html"">Error page 400</a></li>
                                            <li><a href=""error-401.html"">Error page 401</a></li>
                                            <li><a href=""error-403.html"">Error page 403</a></li>
                                            <li><a href=""error-404.html"">Error page 404</a></li>
                                            <li><a href=""error-500.html"">Error page 500</a></li>
                                            <li><a href=""error-503.html"">Error page 503</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class=""col mega-box"">
                                    <div class=""link-section doted"">
                                        <div>
                       ");
            WriteLiteral(@"                     <h6> Authentication</h6>
                                        </div>
                                        <ul>
                                            <li><a href=""login.html"">Login</a></li>
                                            <li><a href=""login_one.html"">Login with image</a></li>
                                            <li><a href=""login-bs-validation.html"">Login with validation</a></li>
                                            <li><a href=""sign-up.html"">Sign Up</a></li>
                                            <li><a href=""sign-up-one.html"">SignUp with image</a></li>
                                            <li><a href=""sign-up-two.html"">SignUp with image</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class=""col mega-box"">
                                    <div class=""link-section dashed-links"">
                    ");
            WriteLiteral(@"                    <div>
                                            <h6>Usefull Pages</h6>
                                        </div>
                                        <ul>
                                            <li><a href=""search.html"">Search Website</a></li>
                                            <li><a href=""unlock.html"">Unlock User</a></li>
                                            <li><a href=""forget-password.html"">Forget Password</a></li>
                                            <li><a href=""reset-password.html"">Reset Password</a></li>
                                            <li><a href=""maintenance.html"">Maintenance</a></li>
                                            <li><a href=""login-sa-validation"">Login validation</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class=""col mega-box"">
                                    <div class=");
            WriteLiteral(@"""link-section"">
                                        <div>
                                            <h6>Email templates</h6>
                                        </div>
                                        <ul>
                                            <li class=""pl-0""><a href=""basic-template.html"">Basic Email</a></li>
                                            <li class=""pl-0""><a href=""email-header.html"">Basic With Header</a></li>
                                            <li class=""pl-0""><a href=""template-email.html"">Ecomerce Template</a></li>
                                            <li class=""pl-0""><a href=""template-email-2.html"">Email Template 2</a></li>
                                            <li class=""pl-0""><a href=""ecommerce-templates.html"">Ecommerce Email</a></li>
                                            <li class=""pl-0""><a href=""email-order-success.html"">Order Success</a></li>
                                        </ul>
                                    </");
            WriteLiteral(@"div>
                                </div>
                                <div class=""col mega-box"">
                                    <div class=""link-section"">
                                        <div>
                                            <h6>Coming Soon</h6>
                                        </div>
                                        <ul class=""svg-icon"">
                                            <li><a href=""comingsoon.html""> <i data-feather=""file""> </i>Coming-soon</a></li>
                                            <li><a href=""comingsoon-bg-video.html""> <i data-feather=""film""> </i>Coming-video</a></li>
                                            <li><a href=""comingsoon-bg-img.html""><i data-feather=""image""> </i>Coming-Image</a></li>
                                        </ul>
                                        <div>
                                            <h6>Other Soon</h6>
                                        </div>
                              ");
            WriteLiteral(@"          <ul class=""svg-icon"">
                                            <li><a class=""txt-primary"" href=""landing-page.html""> <i data-feather=""cast""></i>Landing Page</a></li>
                                            <li><a class=""txt-secondary"" href=""sample-page.html""> <i data-feather=""airplay""></i>Sample Page</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </li>
                <li class=""level-menu outside"">
                    <a class=""nav-link"" href=""#!""><i data-feather=""inbox""></i><span>Level Menu</span></a>
                    <ul class=""header-level-menu menu-to-be-close"">
                        <li><a href=""file-manager.html"" data-original-title=""""");
            BeginWriteAttribute("title", " title=\"", 7982, "\"", 7990, 0);
            EndWriteAttribute();
            WriteLiteral(">                               <i data-feather=\"git-pull-request\"></i><span>File manager    </span></a></li>\r\n                        <li>\r\n                            <a href=\"#!\" data-original-title=\"\"");
            BeginWriteAttribute("title", " title=\"", 8195, "\"", 8203, 0);
            EndWriteAttribute();
            WriteLiteral(">                               <i data-feather=\"users\"></i><span>Users</span></a>\r\n                            <ul class=\"header-level-sub-menu\">\r\n                                <li><a href=\"file-manager.html\" data-original-title=\"\"");
            BeginWriteAttribute("title", " title=\"", 8438, "\"", 8446, 0);
            EndWriteAttribute();
            WriteLiteral(">                               <i data-feather=\"user\"></i><span>User Profile</span></a></li>\r\n                                <li><a href=\"file-manager.html\" data-original-title=\"\"");
            BeginWriteAttribute("title", " title=\"", 8628, "\"", 8636, 0);
            EndWriteAttribute();
            WriteLiteral(">                               <i data-feather=\"user-minus\"></i><span>User Edit</span></a></li>\r\n                                <li><a href=\"file-manager.html\" data-original-title=\"\"");
            BeginWriteAttribute("title", " title=\"", 8821, "\"", 8829, 0);
            EndWriteAttribute();
            WriteLiteral(">                               <i data-feather=\"user-check\"></i><span>Users Cards</span></a></li>\r\n                            </ul>\r\n                        </li>\r\n                        <li><a href=\"kanban.html\" data-original-title=\"\"");
            BeginWriteAttribute("title", " title=\"", 9068, "\"", 9076, 0);
            EndWriteAttribute();
            WriteLiteral(">                               <i data-feather=\"airplay\"></i><span>Kanban Board</span></a></li>\r\n                        <li><a href=\"bookmark.html\" data-original-title=\"\"");
            BeginWriteAttribute("title", " title=\"", 9249, "\"", 9257, 0);
            EndWriteAttribute();
            WriteLiteral(">                               <i data-feather=\"heart\"></i><span>Bookmark</span></a></li>\r\n                        <li><a href=\"social-app.html\" data-original-title=\"\"");
            BeginWriteAttribute("title", " title=\"", 9426, "\"", 9434, 0);
            EndWriteAttribute();
            WriteLiteral(@">                               <i data-feather=""zap""></i><span>Social App                     </span></a></li>
                    </ul>
                </li>
            </ul>
        </div>
        <div class=""nav-right col-8 pull-right right-header p-0"">
            <ul class=""nav-menus"">
                <li class=""language-nav"">
                    <div class=""translate_wrapper"">
                        <div class=""current_lang"">
                            <div class=""lang""><i class=""flag-icon flag-icon-us""></i><span class=""lang-txt"">EN                               </span></div>
                        </div>
                        <div class=""more_lang"">
                            <div class=""lang selected"" data-value=""en""><i class=""flag-icon flag-icon-us""></i><span class=""lang-txt"">English<span> (US)</span></span></div>
                            <div class=""lang"" data-value=""de""><i class=""flag-icon flag-icon-de""></i><span class=""lang-txt"">Deutsch</span></div>
                      ");
            WriteLiteral(@"      <div class=""lang"" data-value=""es""><i class=""flag-icon flag-icon-es""></i><span class=""lang-txt"">Español</span></div>
                            <div class=""lang"" data-value=""fr""><i class=""flag-icon flag-icon-fr""></i><span class=""lang-txt"">Français</span></div>
                            <div class=""lang"" data-value=""pt""><i class=""flag-icon flag-icon-pt""></i><span class=""lang-txt"">Português<span> (BR)</span></span></div>
                            <div class=""lang"" data-value=""cn""><i class=""flag-icon flag-icon-cn""></i><span class=""lang-txt"">简体中文</span></div>
                            <div class=""lang"" data-value=""ae""><i class=""flag-icon flag-icon-ae""></i><span class=""lang-txt"">لعربية <span> (ae)</span></span></div>
                        </div>
                    </div>
                </li>
                <li>                         <span class=""header-search""><i data-feather=""search""></i></span></li>
                <li class=""onhover-dropdown"">
                    <div class=""notific");
            WriteLiteral(@"ation-box""><i data-feather=""bell""> </i><span class=""badge badge-pill badge-secondary"">4                                </span></div>
                    <ul class=""notification-dropdown onhover-show-div"">
                        <li>
                            <i data-feather=""bell""></i>
                            <h6 class=""f-18 mb-0"">Notitications</h6>
                        </li>
                        <li>
                            <p><i class=""fa fa-circle-o mr-3 font-primary""> </i>Delivery processing <span class=""pull-right"">10 min.</span></p>
                        </li>
                        <li>
                            <p><i class=""fa fa-circle-o mr-3 font-success""></i>Order Complete<span class=""pull-right"">1 hr</span></p>
                        </li>
                        <li>
                            <p><i class=""fa fa-circle-o mr-3 font-info""></i>Tickets Generated<span class=""pull-right"">3 hr</span></p>
                        </li>
                        <li>
 ");
            WriteLiteral(@"                           <p><i class=""fa fa-circle-o mr-3 font-danger""></i>Delivery Complete<span class=""pull-right"">6 hr</span></p>
                        </li>
                        <li><a class=""btn btn-primary"" href=""#"">Check all notification</a></li>
                    </ul>
                </li>
                <li class=""onhover-dropdown"">
                    <div class=""notification-box""><i data-feather=""star""></i></div>
                    <div class=""onhover-show-div bookmark-flip"">
                        <div class=""flip-card"">
                            <div class=""flip-card-inner"">
                                <div class=""front"">
                                    <ul class=""droplet-dropdown bookmark-dropdown"">
                                        <li class=""gradient-primary"">
                                            <i data-feather=""star""></i>
                                            <h6 class=""f-18 mb-0"">Bookmark</h6>
                                        <");
            WriteLiteral(@"/li>
                                        <li>
                                            <div class=""row"">
                                                <div class=""col-4 text-center""><i data-feather=""file-text""></i></div>
                                                <div class=""col-4 text-center""><i data-feather=""activity""></i></div>
                                                <div class=""col-4 text-center""><i data-feather=""users""></i></div>
                                                <div class=""col-4 text-center""><i data-feather=""clipboard""></i></div>
                                                <div class=""col-4 text-center""><i data-feather=""anchor""></i></div>
                                                <div class=""col-4 text-center""><i data-feather=""settings""></i></div>
                                            </div>
                                        </li>
                                        <li class=""text-center"">
                                       ");
            WriteLiteral(@"     <button class=""flip-btn"" id=""flip-btn"">Add New Bookmark</button>
                                        </li>
                                    </ul>
                                </div>
                                <div class=""back"">
                                    <ul>
                                        <li>
                                            <div class=""droplet-dropdown bookmark-dropdown flip-back-content"">
                                                <input type=""text"" placeholder=""search..."">
                                            </div>
                                        </li>
                                        <li>
                                            <button class=""d-block flip-back"" id=""flip-back"">Back</button>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>");
            WriteLiteral(@"
                </li>
                <li>
                    <div class=""mode""><i class=""fa fa-moon-o""></i></div>
                </li>
                <li class=""cart-nav onhover-dropdown"">
                    <div class=""cart-box""><i data-feather=""shopping-cart""></i><span class=""badge badge-pill badge-primary"">2</span></div>
                    <ul class=""cart-dropdown onhover-show-div"">
                        <li>
                            <h6 class=""mb-0 f-20"">Shoping Bag</h6><i data-feather=""shopping-cart""></i>
                        </li>
                        <li class=""mt-0"">
                            <div class=""media"">
                                <img class=""img-fluid rounded-circle mr-3 img-60"" src=""../assets/images/ecommerce/01.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 16360, "\"", 16366, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""media-body"">
                                    <span>V-Neck Shawl Collar Woman's Solid T-Shirt</span>
                                    <p>Yellow(#fcb102)</p>
                                    <div class=""qty-box"">
                                        <div class=""input-group"">
                                            <span class=""input-group-prepend"">
                                                <button class=""btn quantity-left-minus"" type=""button"" data-type=""minus"" data-field=""""><i data-feather=""minus""></i></button>
                                            </span>
                                            <input class=""form-control input-number"" type=""text"" name=""quantity"" value=""1""><span class=""input-group-prepend"">
                                                <button class=""btn quantity-right-plus"" type=""button"" data-type=""plus"" data-field=""""><i data-feather=""plus""></i></button>
                                            </spa");
            WriteLiteral(@"n>
                                        </div>
                                    </div>
                                    <h6 class=""text-right text-muted"">$299.00</h6>
                                </div>
                                <div class=""close-circle""><a href=""#""><i data-feather=""x""></i></a></div>
                            </div>
                        </li>
                        <li class=""mt-0"">
                            <div class=""media"">
                                <img class=""img-fluid rounded-circle mr-3 img-60"" src=""../assets/images/ecommerce/03.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 17997, "\"", 18003, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""media-body"">
                                    <span>V-Neck Shawl Collar Woman's Solid T-Shirt</span>
                                    <p>Yellow(#fcb102)</p>
                                    <div class=""qty-box"">
                                        <div class=""input-group"">
                                            <span class=""input-group-prepend"">
                                                <button class=""btn quantity-left-minus"" type=""button"" data-type=""minus"" data-field=""""><i data-feather=""minus""></i></button>
                                            </span>
                                            <input class=""form-control input-number"" type=""text"" name=""quantity"" value=""1""><span class=""input-group-prepend"">
                                                <button class=""btn quantity-right-plus"" type=""button"" data-type=""plus"" data-field=""""><i data-feather=""plus""></i></button>
                                            </spa");
            WriteLiteral(@"n>
                                        </div>
                                    </div>
                                    <h6 class=""text-right text-muted"">$299.00</h6>
                                </div>
                                <div class=""close-circle""><a href=""#""><i data-feather=""x""></i></a></div>
                            </div>
                        </li>
                        <li>
                            <div class=""total"">
                                <h6 class=""mb-2 mt-0 text-muted"">Order Total : <span class=""f-right f-20"">$598.00</span></h6>
                            </div>
                        </li>
                        <li><a class=""btn btn-block btn-primary view-cart"" href=""cart.html"">Go to shoping bag</a><a class=""btn btn-block btn-secondary view-cart"" href=""checkout.html"">Checkout</a></li>
                    </ul>
                </li>
                <li class=""onhover-dropdown"">
                    <i data-feather=""message-square""></i>
");
            WriteLiteral(@"                    <ul class=""chat-dropdown onhover-show-div"">
                        <li>
                            <i data-feather=""message-square""></i>
                            <h6 class=""f-18 mb-0"">Message Box                                    </h6>
                        </li>
                        <li>
                            <div class=""media"">
                                <img class=""img-fluid rounded-circle mr-3"" src=""../assets/images/user/1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 20536, "\"", 20542, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""status-circle online""></div>
                                <div class=""media-body"">
                                    <span>Erica Hughes</span>
                                    <p>Lorem Ipsum is simply dummy...</p>
                                </div>
                                <p class=""f-12 font-success"">58 mins ago</p>
                            </div>
                        </li>
                        <li>
                            <div class=""media"">
                                <img class=""img-fluid rounded-circle mr-3"" src=""../assets/images/user/2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 21188, "\"", 21194, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""status-circle online""></div>
                                <div class=""media-body"">
                                    <span>Kori Thomas</span>
                                    <p>Lorem Ipsum is simply dummy...</p>
                                </div>
                                <p class=""f-12 font-success"">1 hr ago</p>
                            </div>
                        </li>
                        <li>
                            <div class=""media"">
                                <img class=""img-fluid rounded-circle mr-3"" src=""../assets/images/user/4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 21836, "\"", 21842, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""status-circle offline""></div>
                                <div class=""media-body"">
                                    <span>Ain Chavez</span>
                                    <p>Lorem Ipsum is simply dummy...</p>
                                </div>
                                <p class=""f-12 font-danger"">32 mins ago</p>
                            </div>
                        </li>
                        <li class=""text-center""> <a class=""btn btn-primary"" href=""#"">View All     </a></li>
                    </ul>
                </li>
                <li class=""maximize""><a class=""text-dark"" href=""#!"" onclick=""javascript:toggleFullScreen()""><i data-feather=""maximize""></i></a></li>
                <li class=""profile-nav onhover-dropdown p-0 mr-0"">
                    <div class=""media profile-media"">
                        <img class=""b-r-10"" src=""../assets/images/dashboard/profile.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 22819, "\"", 22825, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""media-body"">
                            <span>Emay Walter</span>
                            <p class=""mb-0 font-roboto"">Admin <i class=""middle fa fa-angle-down""></i></p>
                        </div>
                    </div>
                    <ul class=""profile-dropdown onhover-show-div"">
                        <li><a href=""#""><i data-feather=""user""></i><span>Account </span></a></li>
                        <li><a href=""#""><i data-feather=""mail""></i><span>Inbox</span></a></li>
                        <li><a href=""#""><i data-feather=""file-text""></i><span>Taskboard</span></a></li>
                        <li><a href=""#""><i data-feather=""settings""></i><span>Settings</span></a></li>
                        <li><a href=""#""><i data-feather=""log-in""> </i><span>Log in</span></a></li>
                    </ul>
                </li>
            </ul>
        </div>
        <script class=""result-template"" type=""text/x-handlebars-template"">
            <div c");
            WriteLiteral(@"lass=""ProfileCard u-cf"">
                <div class=""ProfileCard-avatar""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-airplay m-0""><path d=""M5 17H4a2 2 0 0 1-2-2V5a2 2 0 0 1 2-2h16a2 2 0 0 1 2 2v10a2 2 0 0 1-2 2h-1""></path><polygon points=""12 15 17 21 7 21 12 15""></polygon></svg></div>
                <div class=""ProfileCard-details"">
                    <div class=""ProfileCard-realName"">{{name}}</div>
                </div>
            </div>
        </script>
        <script class=""empty-template"" type=""text/x-handlebars-template"">
            <div class=""EmptyMessage"">Your search turned up 0 results. This most likely means the backend is down, yikes!</div>
        </script>
    </div>
</div>
");
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
