#pragma checksum "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\GraduationForm.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c9d0ab623160349c89883c2171af8362be22a96bf2c4a0a663557d2705f05b92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_GraduationForm), @"mvc.1.0.view", @"/Views/Student/GraduationForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c9d0ab623160349c89883c2171af8362be22a96bf2c4a0a663557d2705f05b92", @"/Views/Student/GraduationForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e3e87d56d38b9fa8eec75b372a7a90a0bb749c5cb483de8a6a15c7b78877364f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_GraduationForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\suppo\source\repos\DigitalSkillsAcademyProject\Academy-App\Views\Student\GraduationForm.cshtml"
  
	ViewData["Title"] = "Graduation form";
	Layout = "~/Views/Shared/_StudentLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content container-fluid"">
	<div class=""row"">
		<div class=""col-md-12"">
			<div class=""card mb-0"">
				<div class=""card-header"">
					<h4 class=""card-title mb-0"">Graduation Form</h4>
					<p>Please make sure that all the information you are submitting through this form is false free</p>
				</div>
				<div class=""card-body"">
					<div class=""row"">
						<div class=""col-xl-12"">
							<h4 class=""card-title"">Company Information</h4>
							<div class=""form-group row"">
								<div class=""col-lg-6 md-3"">
									<label>Company Name</label>
									<input type=""text"" class=""form-control"" id=""name"">
									<p class=""text-danger"" id=""nameVDT"" style=""display: none;""><b>Enter Company Name</b></p>
								</div>
								<div class=""col-lg-6 mb-3"">
									<label>Company Address</label>
									<input type=""text"" class=""form-control"" id=""address"">
									<p class=""text-danger"" id=""addressVDT"" style=""display: none;""><b>Enter Company Address</b></p>
								</div>
								<div cl");
            WriteLiteral(@"ass=""col-lg-6 md-3"">
									<label>Company State</label>
									<input type=""text"" class=""form-control"" id=""state"">
									<p class=""text-danger"" id=""stateVDT"" style=""display: none;""><b>Enter state where company is located</b></p>
								</div>
								<div class=""col-lg-6 mb-3"">
									<label>Company Email</label>
									<input type=""email"" class=""form-control"" id=""email"">
									<p class=""text-danger"" id=""emailVDT"" style=""display: none;""><b>Enter Company Email</b></p>
								</div>
								<div class=""col-lg-6 mb-3"">
									<label>Company HR PhoneNumber</label>
									<input type=""number"" class=""form-control"" id=""hrTel"">
									<p class=""text-danger"" id=""hrTelVDT"" style=""display: none;""><b>Enter Company HR Phonenumber</b></p>
								</div>
								<div class=""col-lg-6 md-3"">
									<label>Company Salary Payment Date</label>
									<input type=""date"" class=""form-control"" id=""payDate"">
									<p class=""text-danger"" id=""payDateVDT"" style=""display: none;""><b>Enter Co");
            WriteLiteral(@"mpany Salary Payment Date</b></p>
								</div>
							</div>
						</div>
					</div>
					<div class=""row"">
						<div class=""col-xl-12"">
							<h4 class=""card-title"">Employment Information</h4>
							<div class=""form-group row"">
								<div class=""col-lg-6 md-3"">
									<label>Job Title</label>
									<input type=""text"" class=""form-control"" id=""jobTitle"">
									<p class=""text-danger"" id=""jobTitleVDT"" style=""display: none;""><b>Enter Job Title</b></p>
								</div>
								<div class=""col-lg-6 mb-3"">
									<label>Upload Offer Letter(Pdf)</label>
									<input class=""form-control"" type=""file"" accept=""application/pdf"" id=""offerLetter"">
									<p class=""text-danger"" id=""offerLetterVDT"" style=""display: none;""><b>Upload Offer Letter</b></p>
								</div>
								<div class=""col-lg-6 mb-3"">
									<label>Salary</label>
									<input type=""text"" class=""form-control"" id=""salary"" onchange=""SalaryToString()"" onkeyup=""PercentageDeductionComputation()"">
									<input type=");
            WriteLiteral(@"""text"" class=""form-control"" id=""mainSalary"" hidden>
									<p class=""text-danger"" id=""salaryVDT"" style=""display: none;""><b>Enter Proposed Salary</b></p>
								</div>
								<div class=""col-lg-6 md-3"">
									<label>Monthly Deduction (25% of salary)</label>
									<input type=""text"" class=""form-control"" readonly id=""percentageDeduction"">
									<input type=""text"" class=""form-control"" readonly id=""mainDeduction"" hidden>
								</div>
							</div>
						</div>
					</div>
					<div class=""text-center"">
						<button class=""btn newBtn"" type=""submit"" style=""width: 25%;"" onclick=""EmploymentInfo()"">Submit</button>
					</div>
				</div>
			</div>
		</div>
	</div>
</div>
<script>
	function PercentageDeductionComputation()
	{
		var mySalary = $(""#salary"").val();
		var deduction = (mySalary * 0.25);
		$(""#mainSalary"").val(mySalary.toString());
		$(""#mainDeduction"").val(deduction.toString());

		$(""#percentageDeduction"").val(deduction.toLocaleString('en-US'));
	}

	function Sal");
            WriteLiteral(@"aryToString() {
		var mySalary = $(""#salary"").val();

		var salToString = (mySalary * 1).toLocaleString('en-US');
		$(""#salary"").val(salToString);
	}

	function EmploymentInfo()
	{
		var employmentData = {};
		employmentData.CompanyName = $(""#name"").val();
		employmentData.CompanyAddress = $(""#address"").val();
		employmentData.CompanyState = $(""#state"").val();
		employmentData.CompanyEmail = $(""#email"").val();
		employmentData.CompanyHrPhoneNO = $(""#hrTel"").val();
		employmentData.MonthlyPaymentDate = $(""#payDate"").val();
		employmentData.JobTitle = $(""#jobTitle"").val();
		employmentData.OfferLetter = document.getElementById(""offerLetter"").files;
		employmentData.Salary = $(""#mainSalary"").val();
		var deduct
		employmentData.MonthlyDeduction = $(""#mainDeduction"").val();

		if (employmentData.CompanyName == """" || employmentData.CompanyAddress == """" || employmentData.CompanyState == """" || employmentData.CompanyEmail == """" || employmentData.CompanyHrPhoneNO == """" || employmentData.MonthlyPa");
            WriteLiteral(@"ymentDate == """" || employmentData.JobTitle == """" || employmentData.OfferLetter[0] == null || employmentData.Salary == """") 
		{
			if (employmentData.CompanyName == """") {
				document.querySelector(""#nameVDT"").style.display = ""block"";
			} else {
				document.querySelector(""#nameVDT"").style.display = ""none"";
			}
			if (employmentData.CompanyAddress == """") {
				document.querySelector(""#addressVDT"").style.display = ""block"";
			} else {
				document.querySelector(""#addressVDT"").style.display = ""none"";
			}
			if (employmentData.CompanyState == """") {
				document.querySelector(""#stateVDT"").style.display = ""block"";
			} else {
				document.querySelector(""#stateVDT"").style.display = ""none"";
			}
			if (employmentData.CompanyEmail == """") {
				document.querySelector(""#emailVDT"").style.display = ""block"";
			} else {
				document.querySelector(""#emailVDT"").style.display = ""none"";
			}
			if (employmentData.CompanyHrPhoneNO == """") {
				document.querySelector(""#hrTelVDT"").style.display = ""block""");
            WriteLiteral(@";
			} else {
				document.querySelector(""#hrTelVDT"").style.display = ""none"";
			}
			if (employmentData.MonthlyPaymentDate == """") {
				document.querySelector(""#payDateVDT"").style.display = ""block"";
			} else {
				document.querySelector(""#payDateVDT"").style.display = ""none"";
			}
			if (employmentData.JobTitle == """") {
				document.querySelector(""#jobTitleVDT"").style.display = ""block"";
			} else {
				document.querySelector(""#jobTitleVDT"").style.display = ""none"";
			}
			if (employmentData.OfferLetter[0] == null) {
				document.querySelector(""#offerLetterVDT"").style.display = ""block"";
			} else {
				document.querySelector(""#offerLetterVDT"").style.display = ""none"";
			}
			if (employmentData.Salary == """") {
				document.querySelector(""#salaryVDT"").style.display = ""block"";
			} else {
				document.querySelector(""#salaryVDT"").style.display = ""none"";
			}
		}
		else
		{
			document.querySelector(""#nameVDT"").style.display = ""none"";
			document.querySelector(""#addressVDT"").style.displ");
            WriteLiteral(@"ay = ""none"";
			document.querySelector(""#stateVDT"").style.display = ""none"";
			document.querySelector(""#emailVDT"").style.display = ""none"";
			document.querySelector(""#hrTelVDT"").style.display = ""none"";
			document.querySelector(""#payDateVDT"").style.display = ""none"";
			document.querySelector(""#jobTitleVDT"").style.display = ""none"";
			document.querySelector(""#offerLetterVDT"").style.display = ""none"";
			document.querySelector(""#salaryVDT"").style.display = ""none"";
			const reader = new FileReader();
			reader.readAsDataURL(employmentData.OfferLetter[0]);

			reader.onload = function () 
			{
				employmentData.OfferLetter = reader.result;

				let collectedData = JSON.stringify(employmentData);

				$.ajax({
					type: 'Post',
					dataType: 'json',
					url: '/Student/EmploymentInformationPost',
					data:
					{
						employmentData: collectedData,
					},
					success: function (result) {

						if (!result.isError) {
							var url = '/Student/Index';
							successAlertWithRedir");
            WriteLiteral("ect(result.msg, url)\r\n\t\t\t\t\t\t}\r\n\t\t\t\t\t\telse {\r\n\t\t\t\t\t\t\terrorAlert(result.msg)\r\n\t\t\t\t\t\t}\r\n\t\t\t\t\t},\r\n\t\t\t\t\terror: function (ex) {\r\n\t\t\t\t\t\terrorAlert(\"Error occured try again\");\r\n\t\t\t\t\t}\r\n\t\t\t\t});\r\n\t\t\t}\r\n\t\t}\r\n\t}\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591