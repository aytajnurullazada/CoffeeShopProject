#pragma checksum "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\Shop\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52af68f40dd104a485ace0ee97bb791f999e5be7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Shop), @"mvc.1.0.view", @"/Views/Shop/Shop.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52af68f40dd104a485ace0ee97bb791f999e5be7", @"/Views/Shop/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Breadcrumb", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Final layihesi\WebApplication1\WebApplication1\Views\Shop\Shop.cshtml"
  
    ViewData["Title"] = "Shop";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52af68f40dd104a485ace0ee97bb791f999e5be74281", async() => {
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
<section class=""shop_section sec_ptb_120 bg_default_gray"">
<div class=""container"">
 <ul class=""filters-button-group ul_li_center wow fadeInUp"" data-wow-delay="".1s"">
 <li><button class=""button text-uppercase active"" data-filter=""*"">all</button></li>
<li><button class=""button text-uppercase"" data-filter="".chocolate"">chocolate</button></li>
<li><button class=""button text-uppercase"" data-filter="".coffee"">coffee</button></li>
<li><button class=""button text-uppercase"" data-filter="".sandwiches"">sandwiches</button></li>
<li><button class=""button text-uppercase"" data-filter="".sweets"">sweets</button></li>
<li><button class=""button text-uppercase"" data-filter="".blacktea"">black tea</button></li>
<li><button class=""button text-uppercase"" data-filter="".greantea"">grean tea</button></li>
</ul>

<div class=""shop_filter_bar"">
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52af68f40dd104a485ace0ee97bb791f999e5be76398", async() => {
                WriteLiteral(@"
                                    <div class=""pricing_range wow fadeInUp"" data-wow-delay="".2s"">
                                        <h4 class=""item_title text-uppercase"">Price range</h4>
                                        <div class=""price-range-area"">
                                            <div id=""slider-range"" class=""slider-range""></div>
                                            <div class=""price-text d-flex align-items-center"">
                                                <span>Price:</span>
                                                <input type=""text"" id=""amount"" readonly>
                                            </div>
                                        </div>
                                    </div>
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
            WriteLiteral(@"
                            </div>

                            <div class=""col-lg-6"">
                                <div class=""shop_filter_tags wow fadeInUp"" data-wow-delay="".1s"">
                                    <h4 class=""item_title text-uppercase"">Popular tag</h4>
                                    <ul class=""ul_li"">
                                        <li><a href=""#!"">New</a></li>
                                        <li><a href=""#!"">Top</a></li>
                                        <li><a href=""#!"">Sale</a></li>
                                        <li><a href=""#!"">Coffee</a></li>
                                        <li><a href=""#!"">Beans</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""shop_filter_grid grid wow fadeInUp"" data-wow-delay="".3s"">
                        <div class=""element-item choc");
            WriteLiteral(@"olate greantea "" data-category=""chocolate"">
                            <div class=""shop_card"">
                                <a class=""wishlist_btn"" href=""#!""><i class=""fal fa-heart""></i></a>
                                <div class=""share_btns"">
                                    <button type=""button"" class=""share_btn"">
                                        <i class=""fal fa-share-alt""></i>
                                    </button>
                                    <ul class=""ul_li"">
                                        <li><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-youtube""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-instagram""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-linkedin-in""></i></a></li>
                   ");
            WriteLiteral(@"                 </ul>
                                </div>
                                <a class=""item_image"" href=""shop_details.html"">
                                    <img src=""assets/images/shop/img_01.png"" alt=""image_not_found"">
                                </a>
                                <div class=""item_content"">
                                    <h3 class=""item_title text-uppercase"">
                                        <a href=""shop_details.html"">Testy coffee stimy</a>
                                    </h3>
                                    <div class=""btns_group"">
                                        <span class=""item_price bg_default_brown"">$101</span>
                                        <a class=""btn btn_border border_black text-uppercase"" href=""#!"">Add To Cart</a>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class=""e");
            WriteLiteral(@"lement-item coffee blacktea "" data-category=""coffee"">
                            <div class=""shop_card"">
                                <a class=""wishlist_btn"" href=""#!""><i class=""fal fa-heart""></i></a>
                                <div class=""share_btns"">
                                    <button type=""button"" class=""share_btn"">
                                        <i class=""fal fa-share-alt""></i>
                                    </button>
                                    <ul class=""ul_li"">
                                        <li><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-youtube""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-instagram""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-linkedin-in""></i></a></li>
         ");
            WriteLiteral(@"                           </ul>
                                </div>
                                <a class=""item_image"" href=""shop_details.html"">
                                    <img src=""assets/images/shop/img_02.png"" alt=""image_not_found"">
                                </a>
                                <div class=""item_content"">
                                    <h3 class=""item_title text-uppercase"">
                                        <a href=""shop_details.html"">americano pure grades</a>
                                    </h3>
                                    <div class=""btns_group"">
                                        <span class=""item_price bg_default_brown"">$101</span>
                                        <a class=""btn btn_border border_black text-uppercase"" href=""#!"">Add To Cart</a>
                                    </div>
                                </div>
                            </div>
                        </div>

                        ");
            WriteLiteral(@"<div class=""element-item sandwiches sweets "" data-category=""sandwiches"">
                            <div class=""shop_card"">
                                <a class=""wishlist_btn"" href=""#!""><i class=""fal fa-heart""></i></a>
                                <div class=""share_btns"">
                                    <button type=""button"" class=""share_btn"">
                                        <i class=""fal fa-share-alt""></i>
                                    </button>
                                    <ul class=""ul_li"">
                                        <li><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-youtube""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-instagram""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-linkedin-in""></i><");
            WriteLiteral(@"/a></li>
                                    </ul>
                                </div>
                                <a class=""item_image"" href=""shop_details.html"">
                                    <img src=""assets/images/shop/img_03.png"" alt=""image_not_found"">
                                </a>
                                <div class=""item_content"">
                                    <h3 class=""item_title text-uppercase"">
                                        <a href=""shop_details.html"">indian Roasting pack</a>
                                    </h3>
                                    <div class=""btns_group"">
                                        <span class=""item_price bg_default_brown"">$101</span>
                                        <a class=""btn btn_border border_black text-uppercase"" href=""#!"">Add To Cart</a>
                                    </div>
                                </div>
                            </div>
                        </div>

      ");
            WriteLiteral(@"                  <div class=""element-item w-100"">
                            <div class=""shop_offer_banner text-white"" style=""background-image: url(assets/images/backgrounds/bg_10.jpg);"">
                                <div class=""item_content"">
                                    <h4 class=""item_title text-white text-uppercase"">Coffee Bean & Super Cup</h4>
                                    <div class=""discount_percentage"">20%</div>
                                    <p>
                                        Offer Foy Only Sunday
                                    </p>
                                </div>
                            </div>
                        </div>

                        <div class=""element-item sweets sandwiches "" data-category=""sweets"">
                            <div class=""shop_card"">
                                <a class=""wishlist_btn"" href=""#!""><i class=""fal fa-heart""></i></a>
                                <div class=""share_btns"">
                ");
            WriteLiteral(@"                    <button type=""button"" class=""share_btn"">
                                        <i class=""fal fa-share-alt""></i>
                                    </button>
                                    <ul class=""ul_li"">
                                        <li><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-youtube""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-instagram""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-linkedin-in""></i></a></li>
                                    </ul>
                                </div>
                                <a class=""item_image"" href=""shop_details.html"">
                                    <img src=""assets/images/shop/img_04.png"" alt=""image_not_found"">
                          ");
            WriteLiteral(@"      </a>
                                <div class=""item_content"">
                                    <h3 class=""item_title text-uppercase"">
                                        <a href=""shop_details.html"">bangladeshi organic grades</a>
                                    </h3>
                                    <div class=""btns_group"">
                                        <span class=""item_price bg_default_brown"">$101</span>
                                        <a class=""btn btn_border border_black text-uppercase"" href=""#!"">Add To Cart</a>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class=""element-item blacktea coffee "" data-category=""blacktea"">
                            <div class=""shop_card"">
                                <a class=""wishlist_btn"" href=""#!""><i class=""fal fa-heart""></i></a>
                                <div class=""share_btns");
            WriteLiteral(@""">
                                    <button type=""button"" class=""share_btn"">
                                        <i class=""fal fa-share-alt""></i>
                                    </button>
                                    <ul class=""ul_li"">
                                        <li><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-youtube""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-instagram""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-linkedin-in""></i></a></li>
                                    </ul>
                                </div>
                                <a class=""item_image"" href=""shop_details.html"">
                                    <img src=""assets/images/shop/img_05.png"" alt=""image_not_found"">
      ");
            WriteLiteral(@"                          </a>
                                <div class=""item_content"">
                                    <h3 class=""item_title text-uppercase"">
                                        <a href=""shop_details.html"">arvica coffee pack</a>
                                    </h3>
                                    <div class=""btns_group"">
                                        <span class=""item_price bg_default_brown"">$101</span>
                                        <a class=""btn btn_border border_black text-uppercase"" href=""#!"">Add To Cart</a>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class=""element-item greantea chocolate "" data-category=""greantea"">
                            <div class=""shop_card"">
                                <a class=""wishlist_btn"" href=""#!""><i class=""fal fa-heart""></i></a>
                                <div cl");
            WriteLiteral(@"ass=""share_btns"">
                                    <button type=""button"" class=""share_btn"">
                                        <i class=""fal fa-share-alt""></i>
                                    </button>
                                    <ul class=""ul_li"">
                                        <li><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-youtube""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-instagram""></i></a></li>
                                        <li><a href=""#""><i class=""fab fa-linkedin-in""></i></a></li>
                                    </ul>
                                </div>
                                <a class=""item_image"" href=""shop_details.html"">
                                    <img src=""assets/images/shop/img_06.png"" alt=""image_not_");
            WriteLiteral(@"found"">
                                </a>
                                <div class=""item_content"">
                                    <h3 class=""item_title text-uppercase"">
                                        <a href=""shop_details.html"">americano pure grades</a>
                                    </h3>
                                    <div class=""btns_group"">
                                        <span class=""item_price bg_default_brown"">$101</span>
                                        <a class=""btn btn_border border_black text-uppercase"" href=""#!"">Add To Cart</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <ul class=""pagination_nav ul_li_center"">
                        <li><a href=""#!""><i class=""fal fa-angle-double-left""></i></a></li>
                        <li class=""active""><a href=""#!"">1</a></li>
                     ");
            WriteLiteral(@"   <li><a href=""#!"">2</a></li>
                        <li><a href=""#!"">3</a></li>
                        <li><a href=""#!""><i class=""fal fa-angle-double-right""></i></a></li>
                    </ul>
                </div>
            </section>


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
