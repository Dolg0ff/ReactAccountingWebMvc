#pragma checksum "C:\Users\Юрий\Projects\ReactAccountingWebMvc\ReactAccountingWebMvc\Views\Shared\_Master.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c615b8bb8c4201e286b7db70ef6eb09fba560f43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Master), @"mvc.1.0.view", @"/Views/Shared/_Master.cshtml")]
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
#line 1 "C:\Users\Юрий\Projects\ReactAccountingWebMvc\ReactAccountingWebMvc\Views\_ViewImports.cshtml"
using ReactAccountingWebMvc.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Юрий\Projects\ReactAccountingWebMvc\ReactAccountingWebMvc\Views\_ViewImports.cshtml"
using ReactAccountingWebMvc.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Юрий\Projects\ReactAccountingWebMvc\ReactAccountingWebMvc\Views\_ViewImports.cshtml"
using ReactAccountingWebMvc.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Юрий\Projects\ReactAccountingWebMvc\ReactAccountingWebMvc\Views\_ViewImports.cshtml"
using ReactAccountingWebMvc.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Юрий\Projects\ReactAccountingWebMvc\ReactAccountingWebMvc\Views\_ViewImports.cshtml"
using ReactAccountingWebMvc.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Юрий\Projects\ReactAccountingWebMvc\ReactAccountingWebMvc\Views\_ViewImports.cshtml"
using ReactAccountingWebMvc.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Юрий\Projects\ReactAccountingWebMvc\ReactAccountingWebMvc\Views\_ViewImports.cshtml"
using ReactAccountingWebMvc.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Юрий\Projects\ReactAccountingWebMvc\ReactAccountingWebMvc\Views\_ViewImports.cshtml"
using ReactAccountingWebMvc.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c615b8bb8c4201e286b7db70ef6eb09fba560f43", @"/Views/Shared/_Master.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4deed976d3d7f0c235bb5edbf6f775d316b39e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Master : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c615b8bb8c4201e286b7db70ef6eb09fba560f435001", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 193, "\"", 203, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 230, "\"", 240, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <title>Creative - Start Bootstrap Theme</title>
    <!-- Font Awesome Icons -->
    <link href=""vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">
    <!-- Google Fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Merriweather+Sans:400,700"" rel=""stylesheet"">
    <link href='https://fonts.googleapis.com/css?family=Merriweather:400,300,300italic,400italic,700,700italic' rel='stylesheet' type='text/css'>
    <!-- Plugin CSS -->
    <link href=""vendor/magnific-popup/magnific-popup.css"" rel=""stylesheet"">
    <!-- Theme CSS - Includes Bootstrap -->
    <link href=""css/creative.min.css"" rel=""stylesheet"">
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c615b8bb8c4201e286b7db70ef6eb09fba560f437149", async() => {
                WriteLiteral(@"
    <!-- Navigation -->
    <nav class=""navbar navbar-expand-lg navbar-light fixed-top py-3"" id=""mainNav"">
        <div class=""container"">
            <a class=""navbar-brand js-scroll-trigger"" href=""#page-top"">Accounting Web</a>
            <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
            <ul class=""navbar-nav ml-auto my-2 my-lg-0"">
                    <li class=""nav-item"">
                        <a class=""nav-link js-scroll-trigger"" href=""#about"">About</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link js-scroll-trigger"" href=""#services"">Services</a>
                    </li>
                    <l");
                WriteLiteral(@"i class=""nav-item"">
                        <a class=""nav-link js-scroll-trigger"" href=""#portfolio"">Portfolio</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link js-scroll-trigger"" href=""#contact"">Contact</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <div>
        ");
#nullable restore
#line 47 "C:\Users\Юрий\Projects\ReactAccountingWebMvc\ReactAccountingWebMvc\Views\Shared\_Master.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n    </div>\r\n        <!-- Masthead -->\r\n");
                WriteLiteral("        <!-- About Section -->\r\n");
                WriteLiteral("        <!-- Services Section -->\r\n");
                WriteLiteral("        <!-- Portfolio Section -->\r\n");
                WriteLiteral("        <!-- Call to Action Section -->\r\n");
                WriteLiteral(@"        <!-- Contact Section -->
        <section class=""page-section"" id=""contact"">
            <div class=""container"">
                <div class=""row justify-content-center"">
                    <div class=""col-lg-8 text-center"">
                        <h2 class=""mt-0"">Let's Get In Touch!</h2>
                        <hr class=""divider my-4"">
                        <p class=""text-muted mb-5"">Ready to start your next project with us? Give us a call or send us an email and we will get back to you as soon as possible!</p>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-4 ml-auto text-center"">
                        <i class=""fas fa-phone fa-3x mb-3 text-muted""></i>
                        <div>+7 (981) 860-9906</div>
                    </div>
                    <div class=""col-lg-4 mr-auto text-center"">
                        <i class=""fas fa-envelope fa-3x mb-3 text-muted""></i>
                        <!-- Make ");
                WriteLiteral(@"sure to change the email address in anchor text AND the link below! -->
                        <a class=""d-block"" href=""mailto:contact@yourwebsite.com"">Dolg0ff@mail.ru</a>
                    </div>
                </div>
            </div>
        </section>
        <!-- Footer -->
        <footer class=""bg-light py-5"">
            <div class=""container"">
                <div class=""small text-center text-muted"">Copyright &copy; 2019 - Accounting Web</div>
            </div>
        </footer>
        <!-- Bootstrap core JavaScript -->
        <script src=""vendor/jquery/jquery.min.js""></script>
        <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
        <!-- Plugin JavaScript -->
        <script src=""vendor/jquery-easing/jquery.easing.min.js""></script>
        <script src=""vendor/magnific-popup/jquery.magnific-popup.min.js""></script>
        <!-- Custom scripts for this template -->
        <script src=""js/creative.min.js""></script>
");
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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
