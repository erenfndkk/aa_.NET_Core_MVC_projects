#pragma checksum "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\Demo_Product\Demo_Product\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "144fc5ac35648296b9672174ad2883fe8b94ab89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\Demo_Product\Demo_Product\Views\_ViewImports.cshtml"
using Demo_Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\Demo_Product\Demo_Product\Views\_ViewImports.cshtml"
using Demo_Product.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\Demo_Product\Demo_Product\Views\Product\Index.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"144fc5ac35648296b9672174ad2883fe8b94ab89", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78cfb9a0ef0ec1d3d285195ab224403920d5ac14", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\Demo_Product\Demo_Product\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Ürün Adı</th>\r\n        <th>Fiyat</th>\r\n        <th>Stok</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\Demo_Product\Demo_Product\Views\Product\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 20 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\Demo_Product\Demo_Product\Views\Product\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\Demo_Product\Demo_Product\Views\Product\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\Demo_Product\Demo_Product\Views\Product\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n            <td>");
#nullable restore
#line 23 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\Demo_Product\Demo_Product\Views\Product\Index.cshtml"
           Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 549, "\"", 588, 2);
            WriteAttributeValue("", 556, "/Product/DeleteProduct/", 556, 23, true);
#nullable restore
#line 24 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\Demo_Product\Demo_Product\Views\Product\Index.cshtml"
WriteAttributeValue(" ", 579, item.Id, 580, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 653, "\"", 692, 2);
            WriteAttributeValue("", 660, "/Product/UpdateProduct/", 660, 23, true);
#nullable restore
#line 25 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\Demo_Product\Demo_Product\Views\Product\Index.cshtml"
WriteAttributeValue(" ", 683, item.Id, 684, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n        </tr>\n");
#nullable restore
#line 27 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\Demo_Product\Demo_Product\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
