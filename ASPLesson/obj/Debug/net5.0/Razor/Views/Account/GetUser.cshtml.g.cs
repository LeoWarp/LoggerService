#pragma checksum "C:\Users\leowa\Desktop\ASPLesson\ASPLesson\Views\Account\GetUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca8ad8aef0b89559fe86a2524a420212b0d5b62b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_GetUser), @"mvc.1.0.view", @"/Views/Account/GetUser.cshtml")]
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
#line 1 "C:\Users\leowa\Desktop\ASPLesson\ASPLesson\Views\Account\GetUser.cshtml"
using ASPLesson.Domain.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leowa\Desktop\ASPLesson\ASPLesson\Views\Account\GetUser.cshtml"
using ASPLesson.Domain.Enum;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca8ad8aef0b89559fe86a2524a420212b0d5b62b", @"/Views/Account/GetUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de57081c4101b7ca21ad3a0251dacdad5d43cba", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_GetUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\leowa\Desktop\ASPLesson\ASPLesson\Views\Account\GetUser.cshtml"
  
    ViewData["Title"] = "GetUser";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card col-md-12"">
  <div class=""row g-0"">
    <div class=""col-md-4"">
      <img src=""https://images.wallpaperscraft.ru/image/miachik_smajlik_ulybka_123773_1280x720.jpg"" class=""card-img"">
    </div>
    <div class=""col-md-8"">
      <div class=""card-body"">
        <h5 class=""card-title text-center"">Данные пользователя</h5>
        <hr />
      </div>
    </div>
  </div>
</div>
<hr />
<div class=""card col-md-12"">
  <div class=""row g-0"">
    <div class=""col-md-8"">
      <div class=""card-body"">
        <h5 class=""card-title text-center"">Числа</h5>
        <hr />
      </div>
    </div>
    <div class=""col-md-4"">
      <img src=""https://images.wallpaperscraft.ru/image/miachik_smajlik_ulybka_123773_1280x720.jpg"" class=""card-img"">
    </div>
  </div>
</div>

<style>
  .hr {
    color: white;
  }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591