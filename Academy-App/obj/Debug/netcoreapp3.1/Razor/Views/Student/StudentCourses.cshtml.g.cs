#pragma checksum "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "14a4a37adbcc1a59689822d92dabaf0afdd60169f4702590178f4da27fa1846d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_StudentCourses), @"mvc.1.0.view", @"/Views/Student/StudentCourses.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"14a4a37adbcc1a59689822d92dabaf0afdd60169f4702590178f4da27fa1846d", @"/Views/Student/StudentCourses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e3e87d56d38b9fa8eec75b372a7a90a0bb749c5cb483de8a6a15c7b78877364f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_StudentCourses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Core.Models.TrainingCourse>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TrainingVideos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn newBtn btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml"
  
	ViewData["Title"] = "StudentCourses";
	Layout = "~/Views/Shared/_StudentLayout.cshtml";
	var paidCourseIdList = ViewBag.PaidCourseIdList;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Page Header -->
<div class=""page-header"">
	<div class=""row align-items-center"">
		<div class=""col"">
			<h3 class=""page-title"">Student</h3>
			<ul class=""breadcrumb"">
				<li class=""breadcrumb-item""><a href=""index.html"">Dashboard</a></li>
				<li class=""breadcrumb-item active""></li>
			</ul>
		</div>
	</div>
</div>
<!-- /Page Header -->
					
<!-- Search Filter -->
<div class=""row filter-row"">
	<div class=""col-sm-6 col-md-3"">  
		<div class=""form-group form-focus"">
			<input type=""text"" class=""form-control floating"">
			<label class=""focus-label"">Client ID</label>
		</div>
	</div>
	<div class=""col-sm-6 col-md-3"">  
		<div class=""form-group form-focus"">
			<input type=""text"" class=""form-control floating"">
			<label class=""focus-label"">Client Name</label>
		</div>
	</div>
	<div class=""col-sm-6 col-md-3""> 
		<div class=""form-group form-focus select-focus"">
			<select class=""select floating""> 
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14a4a37adbcc1a59689822d92dabaf0afdd60169f4702590178f4da27fa1846d5792", async() => {
                WriteLiteral("Select Company");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14a4a37adbcc1a59689822d92dabaf0afdd60169f4702590178f4da27fa1846d6790", async() => {
                WriteLiteral("Global Technologies");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14a4a37adbcc1a59689822d92dabaf0afdd60169f4702590178f4da27fa1846d7793", async() => {
                WriteLiteral("Delta Infotech");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
			</select>
			<label class=""focus-label"">Company</label>
		</div>
	</div>
	<div class=""col-sm-6 col-md-3"">  
		<a href=""#"" class=""btn newSearchBtn btn-block""> Search </a>
	</div>     
</div>
<!-- Search Filter -->
					
<div class=""row staff-grid-row"">

");
#nullable restore
#line 53 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml"
  if (Model != null && Model.Count() > 0)
	{
		

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml"
   foreach (var course in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"col-md-3\">\r\n\t\t\t\t<div class=\"profile-widget\">\r\n\t\t\t\t\t<div class=\"profile-img\">\r\n\t\t\t\t\t\t<a href=\"client-profile.html\" class=\"round\"><img style=\"height:80px; \" class=\"card-img-top rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 1811, "\"", 1829, 1);
#nullable restore
#line 60 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml"
WriteAttributeValue("", 1817, course.Logo, 1817, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\"></a>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"card-body mb-0\">\r\n\t\t\t\t\t\t<h4 class=\"user-name m-t-10 mb-0 text-ellipsis\"><a href=\"client-profile.html\">Title : ");
#nullable restore
#line 63 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml"
                                                                                       Write(course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n\t\t\t\t\t\t<h4 class=\"user-name m-t-10 mb-0 text-ellipsis\"><a href=\"client-profile.html\">Duration : ");
#nullable restore
#line 64 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml"
                                                                                          Write(course.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n\t\t\t\t\t\t<h4 class=\"user-name m-t-10 mb-0 text-ellipsis\"><a href=\"client-profile.html\">Amount: ");
#nullable restore
#line 65 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml"
                                                                                       Write(String.Format("{0:n0}", course.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n\t\t\t\t\t\t<div class=\"small mt-2\">\r\n");
#nullable restore
#line 67 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml"
       if (!User.IsInRole("Applicant"))
							{
								

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml"
         if (paidCourseIdList != null)
								{
									

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml"
          if (paidCourseIdList.Contains(course.Id))
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14a4a37adbcc1a59689822d92dabaf0afdd60169f4702590178f4da27fa1846d12466", async() => {
                WriteLiteral("Get Started");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 74 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml"
									}
									else
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<a href=\"#\" class=\"btn btn-white btn-sm mr-2\" data-toggle=\"modal\" data-target=\"#Pay_Now\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2731, "\"", 2766, 3);
            WriteAttributeValue("", 2741, "GetCourseId(\'", 2741, 13, true);
#nullable restore
#line 77 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml"
WriteAttributeValue("", 2754, course.Id, 2754, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2764, "\')", 2764, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Pay Now</a>\r\n");
#nullable restore
#line 78 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml"
									}

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml"
          
								}
								else
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<a href=\"#\" class=\"btn btn-white btn-sm mr-2\" data-toggle=\"modal\" data-target=\"#Pay_Now\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2926, "\"", 2961, 3);
            WriteAttributeValue("", 2936, "GetCourseId(\'", 2936, 13, true);
#nullable restore
#line 82 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml"
WriteAttributeValue("", 2949, course.Id, 2949, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2959, "\')", 2959, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Pay Now</a>\r\n");
#nullable restore
#line 83 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml"
								}

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml"
         
							}				

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 89 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml"
			
		}

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml"
   
	}
	else
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div cclass=\"row p5 m-5\">\r\n\t\t\t<div class=\"col-md-12 text-center p-5 m5\">\r\n\t\t\t\t<h2>No Record Found</h2>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
#nullable restore
#line 99 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\StudentCourses.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<!-- /Page Content -->


	<!-- Pay Now Modal -->
	<div id=""Pay_Now"" class=""modal custom-modal fade"" role=""dialog"">
		<div class=""modal-dialog modal-dialog-centered modal-lg"" role=""document"">
			<div class=""modal-content"">
				<div class=""modal-header"">
					<h5 class=""modal-title"">BiviSoft Account Details</h5>
					<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
						<span aria-hidden=""true"">&times;</span>
					</button>
				</div>
				<div class=""modal-body"">
					<div class=""row justify-content-center"">
						<div class=""col-md-4"">
							<div class=""form-group"">
								<label class=""col-form-label"">Account Name :</label>
							</div>
						</div>
						<div class=""col-md-6"">
							<div class=""form-group"">
							<input class=""form-control"" placeholder=""BiviSoft Academy"" type=""text"" readonly>
							</div>
						</div>
					</div>
					<div class=""row justify-content-center"">
						<div class=""col-md-4"">
							<div class=""form-group"">
		");
            WriteLiteral(@"						<label class=""col-form-label"">Account Number :</label>
							</div>
						</div>
						<div class=""col-md-6"">
							<div class=""row"">
								<div class=""col-md-10"">
									<input class=""form-control"" id=""accountInput"" Value=""0123456789"" type=""text"" disabled>
								</div>
								<div class=""col-md-2"">
									<botton class=""btn btn-white p-2"" onclick=""CopyLink('accountInput')""><i class=""fa fa-clone""></i></botton>
								</div>
							</div>
							<div class=""form-group"">
								<a data-clipboard-target=""#""></a>
							</div>
						</div>
					</div>
					<div class=""row justify-content-center"">			
						<div class=""col-md-4"">
							<div class=""form-group"">
								<label class=""col-form-label"">Bank Name :</label>
							</div>
						</div>
						<div class=""col-md-6"">
							<div class=""form-group"">
								<input class=""form-control"" placeholder=""Access Bank"" type=""text"" readonly>
							</div>
						</div>
					</div>
					<div class=""row justify-content-center");
            WriteLiteral(@""">
						<div class=""col-md-10"">
							<input type=""number"" id=""courseId"" hidden />
							<div class=""form-group mb-0 row mb-2"">
								<div class=""col-md-12"">
									<div class=""input-group"">
										<div class=""input-group-prepend"">
											<span class=""input-group-text""><i class=""fa fa-paperclip"" aria-hidden=""true""></i></span>
										</div>
											<input class=""form-control"" type=""file"" id=""prove"">
										<div class=""input-group-append"">
										<button class=""btn newBtn"" type=""button"" onclick=""ManualPaymentAUpload()"">Submit</button>
										</div>
									</div>
								</div>
							</div>
							<h4 class=""text-center mt-5""><a href=""#"" class=""text-primary"" onclick=""SendCourseIdForPayment()"">Pay with PayStack</a></h4>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
	<!-- Pay Now Modal -->

<script>
	function GetCourseId(courseId){
		document.getElementById(""courseId"").value = courseId;
		var chk = document.getElementById(""courseId"").valu");
            WriteLiteral("e;\r\n\t}\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Core.Models.TrainingCourse>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
