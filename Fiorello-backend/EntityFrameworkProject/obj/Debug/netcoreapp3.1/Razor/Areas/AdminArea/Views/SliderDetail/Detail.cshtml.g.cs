#pragma checksum "C:\Users\ASUS\OneDrive\İş masası\Programmer\Asp.net\CKEditor\Fiorello-backend\EntityFrameworkProject\Areas\AdminArea\Views\SliderDetail\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bf16f49ba73e40cacc523d032a5a545e425ed88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminArea_Views_SliderDetail_Detail), @"mvc.1.0.view", @"/Areas/AdminArea/Views/SliderDetail/Detail.cshtml")]
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
#line 1 "C:\Users\ASUS\OneDrive\İş masası\Programmer\Asp.net\CKEditor\Fiorello-backend\EntityFrameworkProject\Areas\AdminArea\Views\_ViewImports.cshtml"
using EntityFrameworkProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\OneDrive\İş masası\Programmer\Asp.net\CKEditor\Fiorello-backend\EntityFrameworkProject\Areas\AdminArea\Views\_ViewImports.cshtml"
using EntityFrameworkProject.ViewModels.SliderViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bf16f49ba73e40cacc523d032a5a545e425ed88", @"/Areas/AdminArea/Views/SliderDetail/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"844c043572557435d551ffc9a2612648f25c8378", @"/Areas/AdminArea/Views/_ViewImports.cshtml")]
    public class Areas_AdminArea_Views_SliderDetail_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\OneDrive\İş masası\Programmer\Asp.net\CKEditor\Fiorello-backend\EntityFrameworkProject\Areas\AdminArea\Views\SliderDetail\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container my-5\">\r\n    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            Category detail\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <p class=\"card-text\">");
#nullable restore
#line 12 "C:\Users\ASUS\OneDrive\İş masası\Programmer\Asp.net\CKEditor\Fiorello-backend\EntityFrameworkProject\Areas\AdminArea\Views\SliderDetail\Detail.cshtml"
                            Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
