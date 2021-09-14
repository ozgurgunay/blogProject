#pragma checksum "C:\Users\user\Documents\BilgeAdamEgitim\odevler-projeler\BlogProje\BlogProje\Views\SaveUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3856395e4f19a4860f76d2566c539f2518b9746e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SaveUser_Index), @"mvc.1.0.view", @"/Views/SaveUser/Index.cshtml")]
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
#line 1 "C:\Users\user\Documents\BilgeAdamEgitim\odevler-projeler\BlogProje\BlogProje\Views\_ViewImports.cshtml"
using BlogProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Documents\BilgeAdamEgitim\odevler-projeler\BlogProje\BlogProje\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3856395e4f19a4860f76d2566c539f2518b9746e", @"/Views/SaveUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c12d849c8c4efeddbba3e8a24a8cbb25215d27b", @"/Views/_ViewImports.cshtml")]
    public class Views_SaveUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserSaveVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\user\Documents\BilgeAdamEgitim\odevler-projeler\BlogProje\BlogProje\Views\SaveUser\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""container h-100"">
    <div class=""row d-flex justify-content-center align-items-center h-100"">

        <div class=""col-12 col-md-7 col-lg-4 col-xl-3"">

            <h2 class=""text-center"">Kullanıcı Bilgilerini Güncelleme</h2>

            <div class=""form-outline mb-6"">
                <label for=""FirstName"" class=""form-label"">Ad</label>
                <input type=""text"" class=""form-control"" id=""firstName"">
            </div>

            <div class=""form-outline mb-6"">
                <label for=""LastName"" class=""form-label"">Soyad</label>
                <input type=""text"" class=""form-control"" id=""lastName"">
            </div>

            <div class=""form-outline mb-6"">
                <label for=""UserName"" class=""form-label"">Kullanıcı Adı</label>
                <input type=""text"" class=""form-control"" id=""userName"">
            </div>

            <div class=""form-outline mb-6"">
                <label for=""Email"" class=""form-label"">E-Mail</label>
                <inp");
            WriteLiteral(@"ut type=""text"" class=""form-control"" id=""eMail"">
            </div>

            <div class=""form-outline mb-6"">
                <label for=""Explanation"" class=""form-label"">Açıklama</label>
                <textarea class=""form-control"" id=""explanation""></textarea>
            </div>

            <div class=""form-outline mb-6"">
                <label for=""UserName"" class=""form-label"">Fotoğraf Seç</label>
            </div>

            <div class=""form-outline mb-6"">
                <input type=""submit"" class=""btn btn-primary"" id=""addUser"" value=""Bilgileri Kaydet"" />
            </div>

        </div>

    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""#addUser"").click(function () {
            var user = {
                ""firstname"": $(""#firstName"").val(),
                ""lastname"": $(""#lastName"").val(),
                ""username"": $(""#userName"").val(),
                ""email"": $(""#eMail"").val(),
                ""explanation"": $(""#explanation"").val()
            }
            $.ajax({
                url: ""/SaveUser/UpdateUser"",
                type: ""POST"",
                data: user,
                success: function (respons) {
                    if (respons == ""ok"") {
                        alert(""İşlem başarılı"")
                    }
                    else {
                        alert(""İşlem başarısız."")
                    }
                }
            });
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserSaveVM> Html { get; private set; }
    }
}
#pragma warning restore 1591