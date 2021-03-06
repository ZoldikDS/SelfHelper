#pragma checksum "E:\GIT\SelfHelper\SelfHelper\SelfHelper\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dba64b2f1e3e2d117e0ae0976ed4ce4d9c28d073"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\GIT\SelfHelper\SelfHelper\SelfHelper\Views\_ViewImports.cshtml"
using SelfHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GIT\SelfHelper\SelfHelper\SelfHelper\Views\_ViewImports.cshtml"
using SelfHelper.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dba64b2f1e3e2d117e0ae0976ed4ce4d9c28d073", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"104f9377f72594093534d21a4389e838fd12b005", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\GIT\SelfHelper\SelfHelper\SelfHelper\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container info"">
        <h2>О сайте</h2>

    <div class=""about"">
        <p> Данный сайт выполняет функцию личного инструмента и не предназначен для коммерческого использования. <br>
            Он включает в себя различный функционал помогающий человеку повседневно и предназначен для всех возрастов и любого пола. <br>
            Не зависимо от ваших увлечений вы с лёгкостью найдёте применение данному сайту. <br>
            Данный сайт с лёгкость станет заменой различным объектам и результатом их объединения в один экологически чистый, бесплатный, быстрый и удобный продукт.
        </p>
    </div>
</div>

<div class=""sections info"">
    <div class=""container"">
        <h2>Разделы</h2>
        <div class=""info-block"">
            <h3>Дневник</h3>
            <p> Данный раздел сайта предназначен для ведения личного дневника. <br>
                В нём вы может записывать абсолютно любые события за день и просматривать все записанные рание события 
                по дням с о");
            WriteLiteral(@"тображением времени записи, а также редактировать и удалять свои записи.
            </p>
        </div>

        <div class=""info-block right"">
            <h3>Заметки</h3>
            <p> Данный раздел сайта предназначен для заметок. <br>
                Это могут быть совершенно любые заметки с указанием важности и раздела. <br>
                В этом разделе вы можете просматривать, добавлять, редактирова и удалять заметки, а также искать по ключевым словам, дате, разделу или важности заметки.
            </p>
        </div>

        <div class=""info-block"">
            <h3>Цели</h3>
            <p> Данный раздел сайта предназначен для ведения личного списка целей. <br>
                В нём вы может записывать абсолютно любые цели с указанием (при желании) сроков выполнения, раздела и важности.
                В этом разделе вы можете просматривать, добавлять, редактирова и удалять цели, а также искать по ключевым словам, дате, разделу или важности цели.
            </p>
        </div>");
            WriteLiteral(@"

        <div class=""info-block right"">
            <h3>Доска</h3>
            <p> Данный раздел сайта представляет из себя доску для рисования. <br>
                Здесь вы сможете при необходимости визуализировать какой-либо объект, маршрут и т.п.
            </p>
        </div>
    </div>
        
</div>
    

");
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
