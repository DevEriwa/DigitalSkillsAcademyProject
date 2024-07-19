#pragma checksum "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "363b0d3669329f2ec2aae8ae1e66d1bb08164a54a89e1340d72efeb88d0806a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Employment), @"mvc.1.0.view", @"/Views/Admin/Employment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"363b0d3669329f2ec2aae8ae1e66d1bb08164a54a89e1340d72efeb88d0806a7", @"/Views/Admin/Employment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e3e87d56d38b9fa8eec75b372a7a90a0bb749c5cb483de8a6a15c7b78877364f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Employment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Core.Models.EmployementData>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
  
	ViewData["Title"] = "Employement Data Submissions";
	Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    body {
        counter-reset: Serial; /* / Set the Serial counter to 0 /*/
    }

    tr td:first-child:before  {
        counter-increment: Serial; /* / Increment the Serial counter /*/
        content: counter(Serial); /*  / Display the counter /*/
    }
</style>

<!-- Page Header -->
<div class=""page-header"">
	<div class=""row"">
		<div class=""col-sm-12"">
			<h3 class=""page-title"">Graduation Form Submission</h3>
		</div>
	</div>
</div>
<!-- /Page Header -->
					
");
            WriteLiteral("\r\n<div class=\"row\">\r\n\t<div class=\"col-md-12\">\r\n");
#nullable restore
#line 48 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
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
							<th>Name</th>
							<th>Company Name</th>
							<th>Company Address</th>
							<th>Company State</th>
							<th>Company Email</th>
							<th>Company Hr Tel</th>
							<th>Salary Pay Dates</th>
							<th>Job Title</th>
							<th class=""text-center"">OfferLetter</th>
							<th>Salary</th>
							<th>Deduction(25%)</th>
							<th>Status</th>
							<th class=""text-center"">Actions</th>
											
						</tr>
					</thead>
");
#nullable restore
#line 71 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
      foreach(var data in Model)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<tbody>\r\n\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t<td></td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 76 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
       Write(data.User.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 77 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
       Write(data.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 78 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
       Write(data.CompanyAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 79 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
       Write(data.CompanyState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 80 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
       Write(data.CompanyEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 81 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
       Write(data.CompanyHrPhoneNO);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 82 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
       Write(data.MonthlyPaymentDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 83 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
       Write(data.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td class=\"text-center\">\r\n\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2438, "\"", 2462, 1);
#nullable restore
#line 85 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
WriteAttributeValue("", 2445, data.OfferLetter, 2445, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn newBtn download-offer text-center\" download><span><i class=\"fa fa-download fafaColor mr-1\"></i> Download </span></a>\r\n\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 87 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
       Write(data.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 88 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
       Write(data.MonthlyDeduction);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 89 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
         if (data.IsApproved)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<td class=\"text-success\">");
#nullable restore
#line 91 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
                             Write(data.IsApproved);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 92 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
								}else{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 94 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
        Write(data.IsApproved);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 95 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
								}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"								<td class=""text-center"">
									<div class=""dropdown dropdown-action"">
										<a href=""#"" class=""action-icon dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""false""><i class=""material-icons"">more_vert</i></a>
										<div class=""dropdown-menu dropdown-menu-right"">
											<a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#accept_Submission""");
            BeginWriteAttribute("onclick", " onclick=\"", 3231, "\"", 3258, 3);
            WriteAttributeValue("", 3241, "MapID(\'", 3241, 7, true);
#nullable restore
#line 100 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
WriteAttributeValue("", 3248, data.Id, 3248, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3256, "\')", 3256, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-check-circle m-r-5 text-success\"></i>Approve</a>\r\n");
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t</tbody>\r\n");
#nullable restore
#line 106 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</table>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 109 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
		}
		else
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div cclass=\"row p5 m-5\">\r\n\t\t\t\t<div class=\"col-md-12 text-center p-5 m5\">\r\n\t\t\t\t\t<h2>No Record Found</h2>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 117 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\Employment.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"	</div>
</div>
<!-- /Content End -->
<!-- Accept Submission Modal -->
<div class=""modal custom-modal fade"" id=""accept_Submission"" role=""dialog"">
	<div class=""modal-dialog modal-dialog-centered"">
		<div class=""modal-content"">
			<div class=""modal-body"">
				<div class=""form-header"">
					<h3>Accept</h3>
					<input hidden id=""approveID"">
					<p>Are you sure want to approve this submission?</p>
				</div>
				<div class=""modal-btn"">
					<div class=""row"">
						<div class=""col-6"">
							<a class=""btn btn-success continue-btn"" onclick=""AcceptGraduationPost()"">Approve</a>
						</div>
						<div class=""col-6"">
							<a href=""javascript:void(0);"" data-dismiss=""modal"" class=""btn btn-primary cancel-btn"">Cancel</a>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
</div>
<!-- /Accept Submission Modal -->
<!-- Decline Submission Modal 
<div class=""modal custom-modal fade"" id=""decliine_Submission"" role=""dialog"">
	<div class=""modal-dialog modal-dialog-centered"">
		<div clas");
            WriteLiteral(@"s=""modal-content"">
			<div class=""modal-body"">
				<div class=""form-header"">
					<h3>Delicine</h3>
					<input hidden id=""declineID"">
					<p>Are you sure want to decline this submission?</p>
				</div>
				<div class=""modal-btn"">
					<div class=""row"">
						<div class=""col-6"">
							<a class=""btn btn-danger continue-btn"" onclick=""RejectApplicationPost()"">Decline</a>
						</div>
						<div class=""col-6"">
							<a href=""javascript:void(0);"" data-dismiss=""modal"" class=""btn cancel-btn"">Cancel</a>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
</div>
 /Decline Submission Modal -->
<script>
	function MapID(Id) {
		debugger
		$(""#approveID"").val(Id);
");
            WriteLiteral(@"	}

	function AcceptGraduationPost()
	{debugger
		var dataID = $(""#approveID"").val();
		if (dataID != """") {
			let dataId = dataID;
			$.ajax({
				type: 'POST',
				dataType: 'Json',
				url: '/Admin/ManageGraduationForms',
				data:
				{
					Id: dataId
				},
				success: function (result) {

					if (!result.isError) {
						var url = '/Admin/Employment'
						successAlertWithRedirect(result.msg, url)
					}
				},
				Error: function (ex) {
					errorAlert(ex);
				}
			});
		}
		else {
			errorAlert(""Error Occurred, Please Try Again"");
		}
	}
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Core.Models.EmployementData>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
