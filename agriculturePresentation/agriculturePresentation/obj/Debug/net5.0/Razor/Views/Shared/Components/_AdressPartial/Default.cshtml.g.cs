#pragma checksum "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Shared\Components\_AdressPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5517d59e505ce88eb1eef9f25552cc227e48d2af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__AdressPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_AdressPartial/Default.cshtml")]
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
#line 1 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\_ViewImports.cshtml"
using agriculturePresentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\_ViewImports.cshtml"
using agriculturePresentation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Shared\Components\_AdressPartial\Default.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5517d59e505ce88eb1eef9f25552cc227e48d2af", @"/Views/Shared/Components/_AdressPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34a8b9f500f20bb3a6e489280d80bfc717cf9691", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__AdressPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Adress>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3 class=\"tittle\">Bize Ulaşın</h3>\r\n\t\t<p class=\"heading-btm-w3ls\">bizi bulmak isteyen kendini yaksın\r\n\t\t\t<br />\r\n\t\t\t-Necati Pompa\r\n\t\t</p>\r\n");
#nullable restore
#line 9 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Shared\Components\_AdressPartial\Default.cshtml"
             foreach (var item in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"col-md-3 contact-left\">\r\n\t\t\t\t\t\n\t\t\t\t\t<h4>adres bilgilerimiz</h4>\r\n\t\t\t\t\t<p>");
#nullable restore
#line 14 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Shared\Components\_AdressPartial\Default.cshtml"
                  Write(item.Description1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t<p>");
#nullable restore
#line 15 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Shared\Components\_AdressPartial\Default.cshtml"
                  Write(item.Description2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t<p>");
#nullable restore
#line 16 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Shared\Components\_AdressPartial\Default.cshtml"
                  Write(item.Description3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t<h4>Phone</h4>\r\n\t\t\t\t\t<p>");
#nullable restore
#line 18 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Shared\Components\_AdressPartial\Default.cshtml"
                  Write(item.Description4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 20 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Shared\Components\_AdressPartial\Default.cshtml"
			}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Adress>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
