#pragma checksum "C:\Users\Amirdora\source\repos\Blog\Blog\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec930a9e72fc5e92eca2ebead36d8eb64224e3ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Post.cshtml", typeof(AspNetCore.Views_Home_Post))]
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
#line 1 "C:\Users\Amirdora\source\repos\Blog\Blog\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
#line 2 "C:\Users\Amirdora\source\repos\Blog\Blog\Views\_ViewImports.cshtml"
using Blog.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec930a9e72fc5e92eca2ebead36d8eb64224e3ab", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddfdcd5f334418971b6e1ebb0672f11f44280de0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(212, 51, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"post\">\r\n");
            EndContext();
#line 17 "C:\Users\Amirdora\source\repos\Blog\Blog\Views\Home\Post.cshtml"
         if (!String.IsNullOrEmpty(Model.Image))
        {
            var image_path = $"/Image/{Model.Image}";

#line default
#line hidden
            BeginContext(379, 16, true);
            WriteLiteral("            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 395, "\"", 412, 1);
#line 20 "C:\Users\Amirdora\source\repos\Blog\Blog\Views\Home\Post.cshtml"
WriteAttributeValue("", 401, image_path, 401, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(413, 37, true);
            WriteLiteral(" />\r\n            <span class=\"title\">");
            EndContext();
            BeginContext(451, 11, false);
#line 21 "C:\Users\Amirdora\source\repos\Blog\Blog\Views\Home\Post.cshtml"
                           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(462, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 22 "C:\Users\Amirdora\source\repos\Blog\Blog\Views\Home\Post.cshtml"
        }

#line default
#line hidden
            BeginContext(482, 51, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"post-body\">\r\n        ");
            EndContext();
            BeginContext(534, 21, false);
#line 26 "C:\Users\Amirdora\source\repos\Blog\Blog\Views\Home\Post.cshtml"
   Write(Html.Raw(@Model.Body));

#line default
#line hidden
            EndContext();
            BeginContext(555, 50, true);
            WriteLiteral(";\r\n    </div>\r\n    <br/><br /><br /><br />\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
