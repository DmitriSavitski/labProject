#pragma checksum "D:\study\7 сем\курсач\Kursach\Web\Views\Employee\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75700b6ba74825e820876237d4cbad7f3f2ce8c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Create), @"mvc.1.0.view", @"/Views/Employee/Create.cshtml")]
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
#line 1 "D:\study\7 сем\курсач\Kursach\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\study\7 сем\курсач\Kursach\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\study\7 сем\курсач\Kursach\Web\Views\Employee\Create.cshtml"
using BLL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75700b6ba74825e820876237d4cbad7f3f2ce8c1", @"/Views/Employee/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeesDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "D:\study\7 сем\курсач\Kursach\Web\Views\Employee\Create.cshtml"
 using (Html.BeginForm("Create", "Employee", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"modal-content\">\r\n\t\t<div class=\"modal-header\" style=\"align-self: center; border-bottom:none\">\r\n\t\t\t<h4 class=\"modal-title\">Добавить сотрудника</h4>\r\n\t\t</div>\r\n\t\t<div class=\"modal-body\">\r\n\t\t\t");
#nullable restore
#line 13 "D:\study\7 сем\курсач\Kursach\Web\Views\Employee\Create.cshtml"
       Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<fieldset class=\"form-group\">\r\n\t\t\t\t<label for=\"EmailDto\">Email</label>\r\n\t\t\t\t");
#nullable restore
#line 16 "D:\study\7 сем\курсач\Kursach\Web\Views\Employee\Create.cshtml"
           Write(Html.TextBoxFor(u => u.EmailDto, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</fieldset>\r\n\t\t\t<fieldset class=\"form-group\">\r\n\t\t\t\t<label for=\"LoginDto\">ФИО пользователя</label>\r\n\t\t\t\t<div style=\"margin-left:15px\">\r\n\t\t\t\t\t<label for=\"LastName\">Фамилия</label>\r\n\t\t\t\t\t");
#nullable restore
#line 22 "D:\study\7 сем\курсач\Kursach\Web\Views\Employee\Create.cshtml"
               Write(Html.TextBoxFor(u => u.FIODto.LastName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t<label for=\"FirstName\">Имя</label>\r\n\t\t\t\t\t");
#nullable restore
#line 24 "D:\study\7 сем\курсач\Kursach\Web\Views\Employee\Create.cshtml"
               Write(Html.TextBoxFor(u => u.FIODto.FirstName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t<label for=\"MiddleName\">Отчество</label>\r\n\t\t\t\t\t");
#nullable restore
#line 26 "D:\study\7 сем\курсач\Kursach\Web\Views\Employee\Create.cshtml"
               Write(Html.TextBoxFor(u => u.FIODto.MiddleName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t\t</div>\r\n\t\t\t</fieldset>\r\n\t\t\t<fieldset class=\"form-group\">\r\n\t\t\t\t<label for=\"DepartmentsId\">Отдел</label>\r\n\t\t\t\t");
#nullable restore
#line 32 "D:\study\7 сем\курсач\Kursach\Web\Views\Employee\Create.cshtml"
           Write(Html.DropDownListFor(u => u.DepartmentDto.DepartmentsId, new SelectList(ViewBag.Departments, "DepartmentIdDto", "NameDto"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</fieldset>\r\n\t\t\t<fieldset class=\"form-group\">\r\n\t\t\t\t<label for=\"PositionId\">Должность</label>\r\n\t\t\t\t");
#nullable restore
#line 36 "D:\study\7 сем\курсач\Kursach\Web\Views\Employee\Create.cshtml"
           Write(Html.DropDownListFor(u => u.PositionDto.PositionId, new SelectList(ViewBag.Positions, "PositionIdDto", "NameDto"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</fieldset>\r\n\t\t</div>\r\n\t\t<div class=\"modal-footer\" style=\"border:none\">\r\n\t\t\t<button type=\"submit\" class=\"btn btn-primary pull-left\">Сохранить</button>\r\n\r\n\t\t\t<span style=\'padding-left: 5px\'>\r\n\t\t\t\t<a class=\'btn btn-danger\'");
            BeginWriteAttribute("href", " href=\'", 1791, "\'", 1830, 1);
#nullable restore
#line 43 "D:\study\7 сем\курсач\Kursach\Web\Views\Employee\Create.cshtml"
WriteAttributeValue("", 1798, Url.Action("Index", "Employee"), 1798, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Назад</a>\r\n\t\t\t</span>\r\n\t\t</div>\r\n\r\n\t</div>\r\n");
#nullable restore
#line 48 "D:\study\7 сем\курсач\Kursach\Web\Views\Employee\Create.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeesDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
