#pragma checksum "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\TestResult.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ebbe7cf6291c6ea9829b4faca835b4830a4d0def1cbd2e11defd00712800bd71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_TestResult), @"mvc.1.0.view", @"/Views/Admin/TestResult.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\_ViewImports.cshtml"
using Academy_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\_ViewImports.cshtml"
using Academy_App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ebbe7cf6291c6ea9829b4faca835b4830a4d0def1cbd2e11defd00712800bd71", @"/Views/Admin/TestResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e3e87d56d38b9fa8eec75b372a7a90a0bb749c5cb483de8a6a15c7b78877364f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_TestResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Core.Models.TestResult>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\TestResult.cshtml"
  
	ViewData["Title"] = "Interview Results";
	Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

	body {
		counter-reset: Serial; /* / Set the Serial counter to 0 /*/
	}

	tr td:first-child:before {
		counter-increment: Serial; /* / Increment the Serial counter /*/
		content: counter(Serial); /*  / Display the counter /*/
	}
</style>

<!-- Page Header -->
<div class=""page-header"">

	<div class=""row"">
		<div class=""col"">
			<h3 class=""page-title"">Course Test Result</h3>
		</div>
	</div>
</div>
<!-- /Page Header -->

<div class=""row"">
	<div class=""col-md-12"">
");
#nullable restore
#line 32 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\TestResult.cshtml"
   if (@Model.Count() > 0 && Model != null)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"			<div class=""table-responsive"">
				<table class=""table table-striped custom-table mb-0 datatable"">
					<thead>
						<tr>
							<th>S/N</th>
							<th>Applicant's Name</th>
							<th>Applicant's Email</th>
							<th>Course</th>
							<th>First Test(%)</th>
							<th>Second Test(%)</th>
							<th>Avarage Score(%)</th>
						</tr>
					</thead>
");
#nullable restore
#line 47 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\TestResult.cshtml"
      foreach (var result in Model)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<tbody>\r\n\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t<td></td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 52 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\TestResult.cshtml"
       Write(result.Student.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 53 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\TestResult.cshtml"
       Write(result.Student.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 54 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\TestResult.cshtml"
       Write(result.Course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td class=\"text-center\">");
#nullable restore
#line 55 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\TestResult.cshtml"
                           Write(result.ResultOne);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td class=\"text-center\">");
#nullable restore
#line 56 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\TestResult.cshtml"
                           Write(result.ResultTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td class=\"text-center\">");
#nullable restore
#line 57 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\TestResult.cshtml"
                           Write(result.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t</tbody>\r\n");
#nullable restore
#line 60 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\TestResult.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</table>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 63 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\TestResult.cshtml"
		}
		else
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div cclass=\"row p5 m-5\">\r\n\t\t\t\t<div class=\"col-md-12 text-center p-5 m5\">\r\n\t\t\t\t\t<h2>No Record Found</h2>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 71 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\TestResult.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Core.Models.TestResult>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
