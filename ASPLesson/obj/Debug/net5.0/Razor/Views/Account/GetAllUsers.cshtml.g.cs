#pragma checksum "C:\Users\leowa\Desktop\ASPLesson\ASPLesson\Views\Account\GetAllUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "078c0b69015bd1c66323ec25aef1530e5ac23539"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_GetAllUsers), @"mvc.1.0.view", @"/Views/Account/GetAllUsers.cshtml")]
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
#line 1 "C:\Users\leowa\Desktop\ASPLesson\ASPLesson\Views\_ViewImports.cshtml"
using ASPLesson;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leowa\Desktop\ASPLesson\ASPLesson\Views\_ViewImports.cshtml"
using ASPLesson.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\leowa\Desktop\ASPLesson\ASPLesson\Views\Account\GetAllUsers.cshtml"
using ASPLesson.Domain.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"078c0b69015bd1c66323ec25aef1530e5ac23539", @"/Views/Account/GetAllUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de57081c4101b7ca21ad3a0251dacdad5d43cba", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_GetAllUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\leowa\Desktop\ASPLesson\ASPLesson\Views\Account\GetAllUsers.cshtml"
  
    ViewData["Title"] = "GetAllUsers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\leowa\Desktop\ASPLesson\ASPLesson\Views\Account\GetAllUsers.cshtml"
  
    var users = @Model.ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n}\r\n\r\n");
#nullable restore
#line 13 "C:\Users\leowa\Desktop\ASPLesson\ASPLesson\Views\Account\GetAllUsers.cshtml"
 for (int i = 0; i < users.Count; i++)
{
  if (i % 2 == 0)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"      <div class=""card col-md-12"">
          <div class=""row g-0"">
              <div class=""col-md-4"">
                  <img src=""https://images.wallpaperscraft.ru/image/soldat_shlem_art_123765_300x168.jpg"" class=""card-img"" alt=""..."">
              </div>
              <div class=""col-md-8"">
                  <div class=""card-body"">
                      <h5 class=""card-title text-center"">Информация о пользователе #");
#nullable restore
#line 24 "C:\Users\leowa\Desktop\ASPLesson\ASPLesson\Views\Account\GetAllUsers.cshtml"
                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                      <p class=\"card-text\">Имя - ");
#nullable restore
#line 25 "C:\Users\leowa\Desktop\ASPLesson\ASPLesson\Views\Account\GetAllUsers.cshtml"
                                            Write(users[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  </div>\r\n              </div>\r\n          </div>\r\n      </div>   \r\n      <div style=\"padding: 15px;\"></div>\r\n");
#nullable restore
#line 31 "C:\Users\leowa\Desktop\ASPLesson\ASPLesson\Views\Account\GetAllUsers.cshtml"
  }
  else
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <div class=\"card col-md-12\">\r\n          <div class=\"row g-0\">\r\n            <div class=\"col-md-8\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title text-center\">Информация о пользователе #");
#nullable restore
#line 38 "C:\Users\leowa\Desktop\ASPLesson\ASPLesson\Views\Account\GetAllUsers.cshtml"
                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">Имя - ");
#nullable restore
#line 39 "C:\Users\leowa\Desktop\ASPLesson\ASPLesson\Views\Account\GetAllUsers.cshtml"
                                          Write(users[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
              <div class=""col-md-4"">
                  <img src=""https://images.wallpaperscraft.ru/image/kot_milyj_shar_127642_300x168.jpg"" class=""card-img"" alt=""..."">
              </div>
          </div>
      </div>  
");
#nullable restore
#line 47 "C:\Users\leowa\Desktop\ASPLesson\ASPLesson\Views\Account\GetAllUsers.cshtml"
  }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
