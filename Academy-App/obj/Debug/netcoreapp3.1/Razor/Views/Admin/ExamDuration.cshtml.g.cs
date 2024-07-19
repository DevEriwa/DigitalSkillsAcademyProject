#pragma checksum "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\ExamDuration.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "70a57d5b2ec84fbf9239f922ebec014596f2fbf1d18c3e6da9ffcd37615a258d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ExamDuration), @"mvc.1.0.view", @"/Views/Admin/ExamDuration.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"70a57d5b2ec84fbf9239f922ebec014596f2fbf1d18c3e6da9ffcd37615a258d", @"/Views/Admin/ExamDuration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e3e87d56d38b9fa8eec75b372a7a90a0bb749c5cb483de8a6a15c7b78877364f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_ExamDuration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Core.Models.ExamDuration>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("examType"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\ExamDuration.cshtml"
  
	ViewData["Title"] = "Exam Duration";
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
			<h3 class=""page-title"">Exam Duration Setup</h3>
		</div>
		<div class=""col-auto float-right ml-auto"">
			<a href=""#"" class=""btn add-btn"" data-toggle=""modal"" data-target=""#add_ExamDuration""><i class=""fa fa-plus""></i> Add</a>
		</div>
	</div>
</div>
<!-- /Page Header -->

<div class=""row"">
	<div class=""col-md-12"">
");
#nullable restore
#line 36 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\ExamDuration.cshtml"
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
							<th>Exam Type</th>
							<th>Duration</th>
							<th>Actions</th>
						</tr>
					</thead>
");
#nullable restore
#line 48 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\ExamDuration.cshtml"
      foreach (var duration in Model)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<tbody>\r\n\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t<td></td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 53 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\ExamDuration.cshtml"
       Write(duration.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 54 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\ExamDuration.cshtml"
       Write(duration.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
								<td class=""text-center"">
									<div class=""dropdown dropdown-action"">
										<a href=""#"" class=""action-icon dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""false""><i class=""material-icons"">more_vert</i></a>
										<div class=""dropdown-menu dropdown-menu-right"">
											<a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#edit_ExamDuration""");
            BeginWriteAttribute("onclick", " onclick=\"", 1684, "\"", 1770, 7);
            WriteAttributeValue("", 1694, "MapTopicDetailsForEdit(\'", 1694, 24, true);
#nullable restore
#line 59 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\ExamDuration.cshtml"
WriteAttributeValue("", 1718, duration.Id, 1718, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1730, "\',\'", 1730, 3, true);
#nullable restore
#line 59 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\ExamDuration.cshtml"
WriteAttributeValue("", 1733, duration.Type, 1733, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1747, "\',\'", 1747, 3, true);
#nullable restore
#line 59 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\ExamDuration.cshtml"
WriteAttributeValue("", 1750, duration.Duration, 1750, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1768, "\')", 1768, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-check-circle m-r-5 text-success\"></i>Edit</a>\r\n\t\t\t\t\t\t\t\t\t\t\t<a class=\"dropdown-item\" href=\"#\" data-toggle=\"modal\" data-target=\"#delete_ExamDuration\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1934, "\"", 1982, 3);
            WriteAttributeValue("", 1944, "MapTopicDetailsForEdit(\'", 1944, 24, true);
#nullable restore
#line 60 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\ExamDuration.cshtml"
WriteAttributeValue("", 1968, duration.Id, 1968, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1980, "\')", 1980, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash-o m-r-5 text-danger\"></i>Delete</a>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t</tbody>\r\n");
#nullable restore
#line 66 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\ExamDuration.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</table>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 69 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\ExamDuration.cshtml"
		}
		else
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div cclass=\"row p5 m-5\">\r\n\t\t\t\t<div class=\"col-md-12 text-center p-5 m5\">\r\n\t\t\t\t\t<h2>No Record Found</h2>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 77 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\ExamDuration.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"	</div>
</div>

<!-- Add Exam Duration Modal -->
<div id=""add_ExamDuration"" class=""modal custom-modal fade"" role=""dialog"">
	<div class=""modal-dialog modal-dialog-centered"" role=""document"">
		<div class=""modal-content"">
			<div class=""modal-header"">
				<h5 class=""modal-title"">Add Exam Duration</h5>
				<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
					<span aria-hidden=""true"">&times;</span>
				</button>
			</div>
			<div class=""modal-body"">
				<div class=""form-group"">
					<label>Exam Type<span class=""text-danger"">*</span></label>
					");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70a57d5b2ec84fbf9239f922ebec014596f2fbf1d18c3e6da9ffcd37615a258d10432", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 94 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Admin\ExamDuration.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(@ViewBag.ExamType,  "Id", "Name" ));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
					<p class=""text-danger"" id=""examTypeVDT"" style=""display: none;"">Select Exam type</p>
				</div>
				<div class=""form-group"">
					<label>Duration<span class=""text-danger"">*</span></label>
					<input class=""form-control"" type=""number"" id=""duration"">
					<p class=""text-danger"" id=""durationVDT"" style=""display: none;"">Enter Exam Duration</p>
				</div>
				<div class=""submit-section"">
					<button class=""btn newBtn submit-btn"" onclick=""CreateExamDuration()"" type=""submit"">Submit</button>
				</div>
			</div>
		</div>
	</div>
</div>
<!-- /Add Exam Duration Modal -->
<!-- Edit Exam Duration Modal -->
<div id=""edit_ExamDuration"" class=""modal custom-modal fade"" role=""dialog"">
	<div class=""modal-dialog modal-dialog-centered"" role=""document"">
		<div class=""modal-content"">
			<div class=""modal-header"">
				<h5 class=""modal-title"">Edit Exam Duration</h5>
				<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
					<span aria-hidden=""true"">&times;</span>
				</button>");
            WriteLiteral(@"
			</div>
			<div class=""modal-body"">
				<div class=""form-group"">
					<input type=""number"" id=""edit_Id"" hidden>
					<label>Exam Type<span class=""text-danger"">*</span></label>
					<input class=""form-control"" type=""text"" id=""examType_Edit"" disabled>
				</div>
				<div class=""form-group"">
					<label>Duration(Minutes)<span class=""text-danger"">*</span></label>
					<input class=""form-control"" type=""text"" id=""duration_Edit"">
					<p class=""text-danger"" id=""duration_EditVTD"" style=""display: none;"">Enter Exam Duration</p>
				</div>
				<div class=""submit-section"">
					<button class=""btn newBtn submit-btn"" type=""submit"" onclick=""EditExamDuration()"">Update</button>
				</div>
			</div>
		</div>
	</div>
</div>
<!-- /Edit Exam Duration Modal -->
<!-- Delete Exam Duration Modal -->
<div class=""modal custom-modal fade"" id=""delete_ExamDuration"" role=""dialog"">
	<div class=""modal-dialog modal-dialog-centered"">
		<div class=""modal-content"">
			<div class=""modal-body"">
				<div class=""form-hea");
            WriteLiteral(@"der"">
					<h3>Delete Exam Duration</h3>
					<p>Are you sure want to delete?</p>
				</div>
				<div class=""modal-btn delete-action"">
					<input type=""number"" id=""delete_Id"" hidden>
					<div class=""row"">
						<div class=""col-6"">
							<a  class=""btn newBtn continue-btn"" onclick=""DeleteExamDuration()"">Delete</a>
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
<!-- /Delete Exam Duration Modal -->

<script>
	function MapTopicDetailsForEdit(Id, Type, Duration) {
		debugger
		$(""#edit_Id"").val(Id);
		$(""#delete_Id"").val(Id);
		$(""#examType_Edit"").val(Type);
		$(""#duration_Edit"").val(Duration);
	}
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Core.Models.ExamDuration>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
