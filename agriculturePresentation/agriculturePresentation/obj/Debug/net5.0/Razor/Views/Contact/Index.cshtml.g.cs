#pragma checksum "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be0e3b2f34e5337fd033c6aff72f2a2793e6ded6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Contact\Index.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be0e3b2f34e5337fd033c6aff72f2a2793e6ded6", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34a8b9f500f20bb3a6e489280d80bfc717cf9691", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            <div class=""col-lg-12 grid-margin stretch-card"">
              <div class=""card"">
                <div class=""card-body"">
                  <h4 class=""card-title"">list of Messages</h4>
                  <div class=""table-responsive"">
                    <table class=""table table-striped"">
                      <thead>
                        <tr>
                            <th>#</th>
                            <th>Name</th>
                            <th>Mail</th>
                            <th>Date</th>
                            <th>Message</th>
                            <th>Delete</th>
                            <th>see message</th>
                        </tr>
                      </thead>
                      <tbody>
");
#nullable restore
#line 27 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Contact\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                              <td>");
#nullable restore
#line 30 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Contact\Index.cshtml"
                             Write(item.ContactID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                              <td>");
#nullable restore
#line 31 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Contact\Index.cshtml"
                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                              <td>");
#nullable restore
#line 32 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Contact\Index.cshtml"
                             Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                              <td>");
#nullable restore
#line 33 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Contact\Index.cshtml"
                             Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                              <td>");
#nullable restore
#line 34 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Contact\Index.cshtml"
                             Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                              <td><a");
            BeginWriteAttribute("href", " href=\"", 1329, "\"", 1374, 2);
            WriteAttributeValue("", 1336, "/Contact/DeleteMessage/", 1336, 23, true);
#nullable restore
#line 35 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1359, item.ContactID, 1359, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Delete</a></td>\r\n                              <td><a");
            BeginWriteAttribute("href", " href=\"", 1460, "\"", 1506, 2);
            WriteAttributeValue("", 1467, "/Contact/MessageDetails/", 1467, 24, true);
#nullable restore
#line 36 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1491, item.ContactID, 1491, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">see message</a></td>\r\n                           \r\n\r\n                            </tr>\r\n");
#nullable restore
#line 40 "C:\Users\findi\Desktop\Eren\Projeler\poje2\C# İLE OOP TEMELLERİ ADIM ADIM KATMANLI MİMARİ\agriculturePresentation\agriculturePresentation\Views\Contact\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                      </tbody>\r\n                    </table>\r\n                    <br />\r\n                   \r\n                  </div>\r\n                </div>\r\n              </div>\r\n            </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
