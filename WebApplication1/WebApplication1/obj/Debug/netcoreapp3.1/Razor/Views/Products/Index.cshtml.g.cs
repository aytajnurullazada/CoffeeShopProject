#pragma checksum "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc96fb3ecefd384d3c9ac97dfdae6fce549641c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc96fb3ecefd384d3c9ac97dfdae6fce549641c2", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05709865ab4979dadf0ebc2d759e512fe456a304", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        private global::AspNetCore.Views_Products_Index.__Generated__RelatedProductViewComponentTagHelper __RelatedProductViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Breadcrumb", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn_secondary text-uppercase add-to-basket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cc96fb3ecefd384d3c9ac97dfdae6fce549641c25552", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<!-- details_section - start
 ================================================== -->
<section class=""details_section shop_details sec_ptb_120 bg_default_gray"">
    <div class=""container"">
        <div class=""row justify-content-lg-between justify-content-md-center justify-content-sm-center"">
            <div class=""col-lg-6 col-md-7"">
                <div class=""details_image_wrap wow fadeInUp"" data-wow-delay="".1s"">

                    <div class=""slider_item"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 604, "\"", 631, 2);
            WriteAttributeValue("", 610, "/uploads/", 610, 9, true);
#nullable restore
#line 16 "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\Products\Index.cshtml"
WriteAttributeValue("", 619, Model.Image, 619, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""image_not_found"">
                    </div>
                </div>
            </div>

            <div class=""col-lg-6 col-md-7"">
                <div class=""details_content wow fadeInUp"" data-wow-delay="".2s"">
                    <div class=""details_flex_title"">
                        <h2 class=""details_title text-uppercase"">");
#nullable restore
#line 24 "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\Products\Index.cshtml"
                                                            Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h2>
                        <div class=""details_review"">
                            <ul class=""rating_star ul_li"">
                                <li><i class=""fas fa-star""></i></li>
                                <li><i class=""fas fa-star""></i></li>
                                <li><i class=""fas fa-star""></i></li>
                                <li><i class=""fas fa-star""></i></li>
                                <li><i class=""far fa-star""></i></li>
                            </ul>
                            <span class=""review_text"">04 - Customar Review</span>
                        </div>
                    </div>
                    <p>
                        ");
#nullable restore
#line 37 "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\Products\Index.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <div class=\"details_price\">\r\n                        <strong class=\"price_text\">");
#nullable restore
#line 40 "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\Products\Index.cshtml"
                                              Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n\r\n");
#nullable restore
#line 42 "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\Products\Index.cshtml"
                         if (Model.Count != 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"in_stuck\"><i class=\"fal fa-check\"></i> In stock</span>\r\n");
#nullable restore
#line 45 "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\Products\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"in_stuck\"><i class=\"far fa-times-circle\"></i> Out of stock</span>\r\n");
#nullable restore
#line 49 "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\Products\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <ul class=""details_item_color ul_li"">
                        <li class=""bg_brown""><input type=""radio"" name=""item_color""></li>
                        <li class=""bg_browndark""><input type=""radio"" name=""item_color"" checked></li>
                        <li class=""bg_brownlight""><input type=""radio"" name=""item_color""></li>
                    </ul>
                    <ul class=""btns_group ul_li"">
                        <li>
                            <div class=""quantity_input quantity_boxed"">
                                <h4 class=""quantity_title text-uppercase"">Quantity</h4>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc96fb3ecefd384d3c9ac97dfdae6fce549641c211412", async() => {
                WriteLiteral(@"
                                    <button type=""button"" class=""input_number_decrement"">–</button>
                                    <input class=""input_number"" value=""1"">
                                    <button type=""button"" class=""input_number_increment"">+</button>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 68 "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\Products\Index.cshtml"
                         if (Model.Count != 0)
                        {   


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc96fb3ecefd384d3c9ac97dfdae6fce549641c213440", async() => {
                WriteLiteral("Add To Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\Products\Index.cshtml"
                                                                                                                                   WriteLiteral(Model.Id);

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
            WriteLiteral("</li>\r\n");
#nullable restore
#line 72 "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\Products\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a class=\"btn btn_secondary text-uppercase add-to-basket\">Notify Me</a></li>\r\n");
#nullable restore
#line 76 "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\Products\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </ul>
                    <div class=""details_wishlist_btn"">
                        <a href=""#!""><i class=""fas fa-heart mr-1""></i> Add to watch list</a>
                    </div>
                    <div class=""details_share_links"">
                        <h4 class=""list_title""><i class=""fas fa-share mr-1""></i> Share</h4>
                        <ul class=""social_links social_icons ul_li"">
                            <li><a href=""#!""><i class=""fab fa-facebook-f""></i></a></li>
                            <li><a href=""#!""><i class=""fab fa-twitter""></i></a></li>
                            <li><a href=""#!""><i class=""fab fa-instagram""></i></a></li>
                            <li><a href=""#!""><i class=""fab fa-youtube""></i></a></li>
                            <li><a href=""#!""><i class=""fab fa-behance""></i></a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>





        <div class=""product_descrip");
            WriteLiteral(@"tion_wrap wow fadeInUp"" data-wow-delay="".3s"">
            <ul class=""tabs_nav ul_li nav"" role=""tablist"">
                <li>
                    <button class=""active"" data-bs-toggle=""tab"" data-bs-target=""#product_description"" type=""button"" role=""tab"" aria-selected=""true"">Product Details</button>
                </li>
                <li>
                    <button data-bs-toggle=""tab"" data-bs-target=""#product_additional_info"" type=""button"" role=""tab"" aria-selected=""false"">Additionnal Imformation</button>
                </li>
                <li>
                    <button data-bs-toggle=""tab"" data-bs-target=""#product_review"" type=""button"" role=""tab"" aria-selected=""false"">Review (3)</button>
                </li>
            </ul>
            <div class=""tab-content"">
                <div class=""tab-pane fade show active"" id=""product_description"" role=""tabpanel"">
                    <p class=""mb-0"">
                        Rorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiu");
            WriteLiteral(@"smod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nost exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proideny.mco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate  cupidaey.
                    </p>
                </div>
                <div class=""tab-pane fade"" id=""product_additional_info"" role=""tabpanel"">
                    <p class=""mb-0"">
                        Rorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nost exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proideny.mco laboris n");
            WriteLiteral(@"isi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate  cupidaey.
                    </p>
                </div>
                <div class=""tab-pane fade"" id=""product_review"" role=""tabpanel"">
                    <p class=""mb-0"">
                        Rorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nost exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proideny.mco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate  cupidaey.
                    </p>
                </div>
            </div>
        </div>

        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:related-product", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc96fb3ecefd384d3c9ac97dfdae6fce549641c220801", async() => {
            }
            );
            __RelatedProductViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Products_Index.__Generated__RelatedProductViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__RelatedProductViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n</section>\r\n<!-- details_section - end\r\n================================================== -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:related-product")]
        public class __Generated__RelatedProductViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__RelatedProductViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("RelatedProduct", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
