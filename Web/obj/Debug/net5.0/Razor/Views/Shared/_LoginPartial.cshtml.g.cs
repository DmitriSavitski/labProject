#pragma checksum "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53d676be5515880a8d60b58404f47fb827107f52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginPartial), @"mvc.1.0.view", @"/Views/Shared/_LoginPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53d676be5515880a8d60b58404f47fb827107f52", @"/Views/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
 if (this.Context.User.Identity.IsAuthenticated)
{
	

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
     using (Html.BeginForm("LogOff", "Authorization", FormMethod.Post, new { id = "logoutForm", style = "width:100%" }))
	{

		

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
                                
		if (this.Context.User.IsInRole("Admin"))
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<ul class=\"nav navbar-nav\" style=\"float:inherit; position:relative;display:inline-block; width:100%\">\r\n\t\t\t\t<li style=\"margin-top: 6px; display: inline-flex; margin-right: 15px;\">\r\n\t\t\t\t\t<a style=\"color: honeydew !important\"");
            BeginWriteAttribute("href", " href=\"", 482, "\"", 522, 1);
#nullable restore
#line 12 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
WriteAttributeValue("", 489, Url.Action("Index", "Informing"), 489, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Уведомить сотрудника(ов)</a>\r\n\t\t\t\t</li>\r\n\t\t\t\t<li style=\"margin-top: 6px; display: inline-flex; margin-right: 15px \">\r\n\t\t\t\t\t<a style=\"color: honeydew !important\" class=\"dropdown\"");
            BeginWriteAttribute("href", " href=\"", 701, "\"", 736, 1);
#nullable restore
#line 15 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
WriteAttributeValue("", 708, Url.Action("Index", "User"), 708, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Работа с пользователями</a>\r\n\t\t\t\t</li>\r\n\t\t\t\t<li style=\"margin-top: 6px; display: inline-flex; margin-right: 15px; \">\r\n\t\t\t\t\t<a style=\"color: honeydew !important\" class=\"dropdown\"");
            BeginWriteAttribute("href", " href=\"", 915, "\"", 954, 1);
#nullable restore
#line 18 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
WriteAttributeValue("", 922, Url.Action("Index", "Employee"), 922, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Работа с сотрудниками</a>\r\n\t\t\t\t</li>\r\n\t\t\t\t<li style=\"margin-top: 6px; display: inline-flex; margin-right: 15px;\">\r\n\t\t\t\t\t<a style=\"color: honeydew !important\" class=\"dropdown\"");
            BeginWriteAttribute("href", " href=\"", 1130, "\"", 1171, 1);
#nullable restore
#line 21 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
WriteAttributeValue("", 1137, Url.Action("Index", "Department"), 1137, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Работа с отделами</a>\r\n\t\t\t\t</li>\r\n\t\t\t\t<li style=\"margin-top: 6px; display:inline-flex \">\r\n\t\t\t\t\t<a style=\"color: honeydew !important\" class=\"dropdown\"");
            BeginWriteAttribute("href", " href=\"", 1322, "\"", 1361, 1);
#nullable restore
#line 24 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
WriteAttributeValue("", 1329, Url.Action("Index", "Position"), 1329, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Работа с должностями</a>
				</li>
				<li style=""padding-right: 50px; float:right"">
					<div id=""nav"" class=""btn btn-primary"" style="" background-color: darkred; float: right; margin-top: 5px; height: 41px; border-radius: 20px;"">
						<span class=""navbar-text"" style=""display: contents;"">
							<a class=""btn"" role=""button"" style=""color: honeydew !important; display:initial"" href=""javascript:document.getElementById('logoutForm').submit()"">Выход</a>
						</span>
					</div>
				</li>
			</ul> ");
#nullable restore
#line 33 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
                  }
		else if (this.Context.User.IsInRole("Менеджер") || this.Context.User.IsInRole("Руководитель предприятия"))
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\"nav navbar-nav\" style=\"float:inherit; position:relative;display:inline-block; width:100%\">\r\n\t<li style=\"margin-top: 6px; display: inline-flex; margin-right: 15px;\">\r\n\t\t<a style=\"color: honeydew !important\"");
            BeginWriteAttribute("href", " href=\"", 2205, "\"", 2245, 1);
#nullable restore
#line 38 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
WriteAttributeValue("", 2212, Url.Action("Index", "Informing"), 2212, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Уведомить сотрудника(ов)</a>\r\n\t</li>\r\n\t<li style=\"margin-top: 6px; display: inline-flex; margin-right: 15px \">\r\n\t\t<a style=\"color: honeydew !important\" class=\"dropdown\"");
            BeginWriteAttribute("href", " href=\"", 2415, "\"", 2450, 1);
#nullable restore
#line 41 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
WriteAttributeValue("", 2422, Url.Action("Index", "User"), 2422, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Работа с пользователями</a>\r\n\t</li>\r\n\t<li style=\"margin-top: 6px; display: inline-flex; margin-right: 15px; \">\r\n\t\t<a style=\"color: honeydew !important\" class=\"dropdown\"");
            BeginWriteAttribute("href", " href=\"", 2620, "\"", 2659, 1);
#nullable restore
#line 44 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
WriteAttributeValue("", 2627, Url.Action("Index", "Employee"), 2627, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Работа с сотрудниками</a>\r\n\t</li>\r\n\t<li style=\"margin-top: 6px; display: inline-flex; margin-right: 15px; \">\r\n\t\t<a style=\"color: honeydew !important\" class=\"dropdown\"");
            BeginWriteAttribute("href", " href=\"", 2827, "\"", 2868, 1);
#nullable restore
#line 47 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
WriteAttributeValue("", 2834, Url.Action("Index", "Department"), 2834, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Работа с отделами</a>\r\n\t</li>\r\n\t<li style=\"margin-top: 6px; display:inline-flex \">\r\n\t\t<a style=\"color: honeydew !important\" class=\"dropdown\"");
            BeginWriteAttribute("href", " href=\"", 3010, "\"", 3049, 1);
#nullable restore
#line 50 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
WriteAttributeValue("", 3017, Url.Action("Index", "Position"), 3017, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Работа с должностями</a>
	</li>
	<li style=""padding-right: 50px; float:right"">
		<div id=""nav"" class=""btn btn-primary"" style="" background-color: darkred; float: right; margin-top: 5px; height: 41px; border-radius: 20px;"">
			<span class=""navbar-text"" style=""display: contents;"">
				<a class=""btn"" role=""button"" style=""color: honeydew !important; display:initial"" href=""javascript:document.getElementById('logoutForm').submit()"">Выход</a>
			</span>
		</div>
	</li>
</ul>
");
#nullable restore
#line 60 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
		}
		else
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<ul class=\"nav navbar-nav\" style=\"float:inherit\">\r\n\t\t\t\t<li style=\"margin-top: 6px; display: inline-flex; margin-right: 15px;\">\r\n\t\t\t\t\t<a style=\"color: honeydew !important\"");
            BeginWriteAttribute("href", " href=\"", 3724, "\"", 3764, 1);
#nullable restore
#line 65 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
WriteAttributeValue("", 3731, Url.Action("Index", "Informing"), 3731, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Уведомить сотрудника(ов)</a>\r\n\t\t\t\t</li>\r\n\t\t\t\t<li style=\"margin-top: 6px; display: inline-flex; margin-right: 15px; \">\r\n\t\t\t\t\t<a style=\"color: honeydew !important\" class=\"dropdown\"");
            BeginWriteAttribute("href", " href=\"", 3944, "\"", 3983, 1);
#nullable restore
#line 68 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
WriteAttributeValue("", 3951, Url.Action("Index", "Employee"), 3951, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Работа с сотрудниками</a>
				</li>
				<li style=""padding-right: 50px; float:right"">
					<div id=""nav"" class=""btn btn-primary"" style="" background-color: darkred; float: right; margin-top: 5px; height: 41px; border-radius: 20px;"">
						<span class=""navbar-text"" style=""display: contents;"">
							<a style=""color: honeydew !important"" class=""btn"" role=""button"" href=""javascript:document.getElementById('logoutForm').submit()"">Выход</a>
						</span>
					</div>
				</li>
			</ul>");
#nullable restore
#line 77 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
                 }
	}

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
     

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"navbar navbar-light navbar-expand-lg\">\r\n\t</div>\r\n");
#nullable restore
#line 85 "D:\study\7 сем\курсач\Kursach\Web\Views\Shared\_LoginPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
