#pragma checksum "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\AdminPartials\PartialSidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48673c847bdc0f33e5e21fe2d94ed51e83d45e71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminPartials_PartialSidebar), @"mvc.1.0.view", @"/Views/AdminPartials/PartialSidebar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48673c847bdc0f33e5e21fe2d94ed51e83d45e71", @"/Views/AdminPartials/PartialSidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34a8b9f500f20bb3a6e489280d80bfc717cf9691", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminPartials_PartialSidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<nav class=""sidebar sidebar-offcanvas"" id=""sidebar"">
        <ul class=""nav"">
          <li class=""nav-item"">
            <a class=""nav-link"" href=""/Dashboard/Index/"">
              <i class=""mdi mdi-home menu-icon""></i>
              <span class=""menu-title"">Dashboard</span>
            </a>
          </li>
          <li class=""nav-item"">
            <a class=""nav-link"" href=""/Service/Index/"">
              <i class=""mdi mdi-circle-outline menu-icon""></i>
              <span class=""menu-title"">Services</span>
          </a>
          </li>
          <li class=""nav-item"">
            <a class=""nav-link"" href=""/Team/Index/"">
              <i class=""mdi mdi-view-headline menu-icon""></i>
              <span class=""menu-title"">Teammates</span>
            </a>
          </li>
          <li class=""nav-item"">
            <a class=""nav-link"" href=""/Chart/Index/"">
              <i class=""mdi mdi-chart-pie menu-icon""></i>
              <span class=""menu-title"">graphics</span>
            </a>");
            WriteLiteral(@"
          </li>
          
          <li class=""nav-item"">
            <a class=""nav-link"" href=""/Announcement/Index/"">
              <i class=""mdi mdi-format-annotation-minus menu-icon""></i>
              <span class=""menu-title"">Announcememnts</span>
            </a>
          </li>
          <li class=""nav-item"">
            <a class=""nav-link"" href=""/Contact/Index/"">
              <i class=""mdi mdi-message menu-icon""></i>
              <span class=""menu-title"">incoming messages</span>
            </a>
          </li>
           <li class=""nav-item"">
            <a class=""nav-link"" href=""/Address/Index/"">
              <i class=""mdi mdi-map menu-icon""></i>
              <span class=""menu-title"">Adres Bilgileri</span>
            </a>
          </li>
          <li class=""nav-item"">
            <a class=""nav-link"" href=""/Image/Index/"">
              <i class=""mdi mdi-image menu-icon""></i>
              <span class=""menu-title"">Images</span>
            </a>
          </li>
       ");
            WriteLiteral(@"   <li class=""nav-item"">
            <a class=""nav-link"" href=""/Report/Index/"">
              <i class=""mdi mdi-image menu-icon""></i>
              <span class=""menu-title"">Raporlar</span>
            </a>
          </li>
          <li class=""nav-item"">
            <a class=""nav-link"" href=""/Profile/Index/"">
              <i class=""mdi mdi-image menu-icon""></i>
              <span class=""menu-title"">settings</span>
            </a>
          </li>
          <li class=""nav-item"">
            <a class=""nav-link"" href=""/Admin/Index/"">
              <i class=""mdi mdi-key menu-icon""></i>
              <span class=""menu-title"">Admin işlemleri</span>
            </a>
          </li>
          <li class=""nav-item"">
            <a class=""nav-link"" href=""/Login/LogOut/"">
              <i class=""mdi mdi-exit menu-icon""></i>
              <span class=""menu-title"">Exit</span>
            </a>
          </li>
        </ul>
      </nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
