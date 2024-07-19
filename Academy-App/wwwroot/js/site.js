﻿function ChangeColorToValid(selectedClass) {
    
    for (var i = 0; i < selectedClass.length; i++) {
        selectedClass[i].style.color = "green";
    }
}
function ChangeColorToInValid(selectedClass) {
    
    for (var i = 0; i < selectedClass.length; i++) {
        selectedClass[i].style.color = "gray";
    }
}

function HideFormPage11Next()
{
    //FORM SECTION INDICATORS
    var registrationFormValidation = document.getElementsByClassName("tickcheck1");
    var personFormValidation = document.getElementsByClassName("tickcheck2");
    var skillFormValidation = document.getElementsByClassName("tickcheck3");

    // FORM INPUTS FOR VALIDATING SCRIPT
    var fName = document.getElementById("FirstName").value;
    var lName = document.getElementById("LastName").value;
    var noba = document.getElementById("PhoneNo").value;
    var userNam = document.getElementById("UserName").value;
    var email = document.getElementById("Email").value;
    var passwrd = document.getElementById("Passwrd").value;
    var cPasswrd = document.getElementById("Cpasswrd").value;
    var address = document.getElementById("Address").value;

    
    if (fName != "" && lName != "" && noba != "" && userNam != "" && email != "" && passwrd != "" && cPasswrd != "" && passwrd == cPasswrd && address != "")
    {
        
        document.getElementById("form11").style.display = "none";
        document.getElementById("form22").style.display = "block";
        document.getElementById("form33").style.display = "none";
        ChangeColorToValid(registrationFormValidation);
        ChangeColorToInValid(personFormValidation);
        ChangeColorToInValid(skillFormValidation);
    }
    else
    {
        document.getElementById("form11").style.display = "block";
        document.getElementById("form22").style.display = "none";
        document.getElementById("form33").style.display = "none";
        ChangeColorToInValid(registrationFormValidation);
        ChangeColorToInValid(personFormValidation);
        ChangeColorToInValid(skillFormValidation);
        if (fName == "") {
            document.getElementById("FNameValidation").style.display = "block";
        } else {
            document.getElementById("FNameValidation").style.display = "none";
        }
        if (lName == "") {
            document.getElementById("LNameValidation").style.display = "block";
        } else {
            document.getElementById("LNameValidation").style.display = "none";
        }
        if (noba == "") {
            document.getElementById("TelValidation").style.display = "block";
        } else {
            document.getElementById("TelValidation").style.display = "none";
        }
        if (userNam == "") {
            document.getElementById("UserNameValidation").style.display = "block";
        } else {
            document.getElementById("UserNameValidation").style.display = "none";
        }
        if (email == "") {
            document.getElementById("EmailValidation").style.display = "block";
        } else {
            document.getElementById("EmailValidation").style.display = "none";
        }
        if (passwrd == "") {
            document.getElementById("PasswordValidation").style.display = "block";
        } else {
            document.getElementById("PasswordValidation").style.display = "none";
        }
        if (cPasswrd != passwrd) {
            document.getElementById("ConfirmValidation").style.display = "block";
        } else {
            document.getElementById("ConfirmValidation").style.display = "none";
        }
        if (address == "") {
            document.getElementById("AddressValidation").style.display = "block";
        } else {
            document.getElementById("AddressValidation").style.display = "none";
        }
    }

}

// Registration for page 2 Button Next
function HideFormPage22Next()
{
    //FORM SECTION INDICATORS
    var registrationFormValidation = document.getElementsByClassName("tickcheck1");
    var personFormValidation = document.getElementsByClassName("tickcheck2");
    var skillFormValidation = document.getElementsByClassName("tickcheck3");

    // FORM INPUTS FOR VALIDATING SCRIPT
    var jNysc = document.getElementById("nysc").value;
    var jLaptop = document.getElementById("laptop").value;
    var jProgrammingExp = document.getElementById("programmingExp").value;
    var jProgrammingExpList = document.getElementById("programmingExpList").value;
    var jStateOfResident = document.getElementById("stateOfResident").value;
    var jReasons = document.getElementById("reasons").value;

    if (jNysc != 0 && jLaptop != 0 && jProgrammingExp != 0 && jStateOfResident != 0 && jReasons != "")
    {
        if (jProgrammingExp == 1 && jProgrammingExpList == "") {
            document.getElementById("form11").style.display = "none";
            document.getElementById("form22").style.display = "block";
            document.getElementById("form33").style.display = "none";
            ChangeColorToValid(registrationFormValidation);
            ChangeColorToInValid(personFormValidation);
            ChangeColorToInValid(skillFormValidation);
            document.getElementById("ProgrammingExpListValidation").style.display = "block";
        } else {
            document.getElementById("form11").style.display = "none";
            document.getElementById("form22").style.display = "none";
            document.getElementById("form33").style.display = "block";
            ChangeColorToValid(registrationFormValidation);
            ChangeColorToValid(personFormValidation);
            ChangeColorToInValid(skillFormValidation);
        }
    }
    else
    {
        document.getElementById("form11").style.display = "none";
        document.getElementById("form22").style.display = "block";
        document.getElementById("form33").style.display = "none";
        ChangeColorToValid(registrationFormValidation);
        ChangeColorToInValid(personFormValidation);
        ChangeColorToInValid(skillFormValidation);
        if (jNysc == 0) {
            document.getElementById("NyscValidation").style.display = "block";
        } else {
            document.getElementById("NyscValidation").style.display = "none";
        }
        if (jLaptop == 0) {
            document.getElementById("LaptopValidation").style.display = "block";
        } else {
            document.getElementById("LaptopValidation").style.display = "none";
        }
        if (jProgrammingExp == 0) {
            document.getElementById("programmingExpValidation").style.display = "block";
        } else {
            document.getElementById("programmingExpValidation").style.display = "none";
        }
        if (jStateOfResident == 0) {
            document.getElementById("StateOfResidentValidation").style.display = "block";
        } else {
            document.getElementById("StateOfResidentValidation").style.display = "none";
        }
        if (jReasons == "") {
            document.getElementById("ReasonValidation").style.display = "block";
        } else {
            document.getElementById("ReasonValidation").style.display = "none";
        }
    }

}

// Registration for page 2 Button Previous
function HideFormPage22Previous()
{
    document.getElementById("form11").style.display = "block";
    document.getElementById("form22").style.display = "none";
    document.getElementById("form33").style.display = "none";
    var registrationFormValidation = document.getElementsByClassName("tickcheck1");
    var personFormValidation = document.getElementsByClassName("tickcheck2");
    var skillFormValidation = document.getElementsByClassName("tickcheck3");

    ChangeColorToInValid(registrationFormValidation);
    ChangeColorToInValid(personFormValidation);
    ChangeColorToInValid(skillFormValidation);
}

// Registration for page 3 Button Previous
function HideFormPage33Previous()
{
    
    document.getElementById("form11").style.display = "none";
    document.getElementById("form22").style.display = "block";
    document.getElementById("form33").style.display = "none";
    var registrationFormValidation = document.getElementsByClassName("tickcheck1");
    var personFormValidation = document.getElementsByClassName("tickcheck2");
    var skillFormValidation = document.getElementsByClassName("tickcheck3");

    ChangeColorToValid(registrationFormValidation);
    ChangeColorToInValid(personFormValidation);
    ChangeColorToInValid(skillFormValidation);
}

// Registration for page 3 Button Submt
function ApplicationRequest()
{
    
    var registrationFormValidation = document.getElementsByClassName("tickcheck1");
    var personFormValidation = document.getElementsByClassName("tickcheck2");
    var skillFormValidation = document.getElementsByClassName("tickcheck3");
    var skll = document.getElementById("skills").value;
    var surv = document.getElementById("survive").value;
    var cv = document.getElementById("cv").value;

    
    if (skll != "" && surv != "" && cv != "")
    {
        ChangeColorToValid(registrationFormValidation);
        ChangeColorToValid(personFormValidation);
        ChangeColorToValid(skillFormValidation);
        
        ApplicationRequestMain();
    }
    else
    {
        ChangeColorToValid(registrationFormValidation);
        ChangeColorToValid(personFormValidation);
        ChangeColorToInValid(skillFormValidation);

        if (skll == "") {
            document.getElementById("SkillsValidation").style.display = "block";
        } else {
            document.getElementById("SkillsValidation").style.display = "none";
        }
        if (surv == "") {
            document.getElementById("SurviveValidation").style.display = "block";
        } else {
            document.getElementById("SurviveValidation").style.display = "none";
        }
        if (cv == "") {
            document.getElementById("CvValidation").style.display = "block";
        } else {
            document.getElementById("CvValidation").style.display = "none";
        }
    }

}

function EnableOrDisableInput() {
    var inputControlla = document.getElementById("programmingExp").value;
    var inputToChange = document.getElementById("programmingExpList");

    if (inputControlla == 1) {
        inputToChange.disabled = false;
    } else {
        inputToChange.disabled = true;
    }
}

// APPLICATION REQUEST 
function ApplicationRequestMain()
{
    
    $('#loader').show();
    $('#loader-wrapper').show();

    var file = document.getElementById("cv").files;
    
    if (file[0] != null)
    {
            const reader = new FileReader();
            reader.readAsDataURL(file[0]);

        reader.onload = function ()
        {
            var data = {};
            // section 1
            data.FirstName = $('#FirstName').val();
            data.LastName = $('#LastName').val();
            data.PhoneNumber = $('#PhoneNo').val();
            data.UserName = $('#UserName').val();
            data.Email = $('#Email').val();
            data.Password = $('#Passwrd').val();
            data.ConfirmPassword = $('#Cpasswrd').val();
            data.Address = $('#Address').val();

            // section 2
            data.HasCompletedNysc = $('#nysc').val();
            data.HasLaptop = $('#laptop').val();
            data.HasAnyProgrammingExp = $('#programmingExp').val();
            data.ApplicantResideInEnugu = $('#stateOfResident').val();
            data.ProgrammingLanguagesExps = $('#programmingExpList').val();
            data.ReasonForProgramming = $('#reasons').val();

            // section 3
            data.AboutYourSkills = $('#skills').val();
            data.HowDoYouIntendToCopeStatement = $('#survive').val();
            data.CV = reader.result;
            data.fileExtensionChecker = data.CV.includes("application/pdf");
            
            if (data.fileExtensionChecker)
            {
                let applicationViewModel = JSON.stringify(data);
                $.ajax({
                    type: 'Post',
                    dataType: 'json',
                    url: '/Accounts/Application',
                    data:
                    {
                        applicationUserViewModel: applicationViewModel,
                    },
                    success: function (result)
                    {
                        
                        if (!result.isError)
                        {
                            $("#loader").fadeOut(3000);

                            var url = '/Accounts/Login';
                            successAlertWithRedirect(result.msg, url)
                        }
                        else
                        {
                            $("#loader").fadeOut(3000);
                            errorAlert(result.msg)
                        }
                    },
                    error: function (ex)
                    {
                        $("#loader").fadeOut(3000);
                        errorAlert("Error occured try again");
                    }
                });
            }
            else
            {
                $("#loader").fadeOut(3000);
                errorAlert("Only PDF file is allowed");
            }
        }
    }
}

// LOGIN POST ACTION
function loginPost()
{
    
    $('#loader').show();
    $('#loader-wrapper').show();

    var email = document.getElementById("Email").value;
    var Passwrd = document.getElementById("Passwrd").value;
    if (email != null && Passwrd != null)
    {
        
        var data = {};
        data.Email = $("#Email").val();
        data.Password = $("#Passwrd").val();
        let loginViewModel = JSON.stringify(data);
        $.ajax({
            type: 'POST',
            dataType: 'Json',
            url: '/Accounts/Login',
            data:
            {
                loginViewModel: loginViewModel
            },
            success: function (result)
            {
                

                if (result.isNotVerified)
                {
                    $("#loader").fadeOut(3000);
                    errorAlert(result.msg)
                }
                else if (!result.isError)
                {
                    $("#loader").fadeOut(3000);
                    successAlertWithRedirect(result.msg, result.dashboard)
                }
                else
                {
                    $("#loader").fadeOut(3000);
                    errorAlert(result.msg)
                }
            },
            Error: function (ex)
            {
                $("#loader").fadeOut(3000);
                errorAlert(ex);
            }
        });
    }
}

// Admin Registration POST ACTION
function RegisterAdmin()
{
    var data = {};
    data.FirstName = $('#FirstName').val();
    data.LastName = $('#LastName').val();
    data.Email = $('#Email').val();
    data.Password = $('#Passwrd').val();
    data.ConfirmPassword = $('#ConfirmPasswrd').val();
    if (data.FirstName != "" && data.LastName != "" && data.Email != "" && data.Password != "" && data.Password == data.ConfirmPassword) {
        let applicationViewModel = JSON.stringify(data);
        $.ajax({
            type: 'POST',
            dataType: 'Json',
            url: '/Accounts/AdminRegisteration',
            data:
            {
                applicationUserViewModel: applicationViewModel,
            },
            success: function (result) {

                if (!result.isError) {
                    $("#loader").fadeOut(3000);
                    var url = '/Accounts/Login'
                    successAlertWithRedirect(result.msg, url)
                }
                else {
                    $("#loader").fadeOut(3000);
                    errorAlert(result.msg)
                }
            },
            Error: function (ex) {
                $("#loader").fadeOut(3000);
                errorAlert(ex);
            }
        });
    }
    else {
        if (data.FirstName == "") {
            document.querySelector("#fNameVDT").style.display = "block";
        } else {
            document.querySelector("#fNameVDT").style.display = "none";
        }
        if (data.LastName == "") {
            document.querySelector("#lNameVDT").style.display = "block";
        } else {
            document.querySelector("#lNameVDT").style.display = "none";
        }
        if (data.Email == "") {
            document.querySelector("#emailVDT").style.display = "block";
        } else {
            document.querySelector("#emailVDT").style.display = "none";
        }
        if (data.Password == "") {
            document.querySelector("#passwrdVDT").style.display = "block";
        } else {
            document.querySelector("#passwrdVDT").style.display = "none";
            if (data.Password != data.ConfirmPassword) {
                document.querySelector("#cpasswrdVDT").style.display = "block";
            } else {
                document.querySelector("#cpasswrdVDT").style.display = "none";
            }
        }
    } 
}

function viewApplcantsData(HasCompletedNysc, HasLaptop, HasAnyProgrammingExp, ApplicantResideInEnugu, ProgrammingLanguagesExps, ReasonForProgramming) {
    
    var nyscCheck = HasCompletedNysc;
    var laptopCheck = HasLaptop;
    var programmingExpCheck = HasAnyProgrammingExp;
    var ResideInEnuguCheck = ApplicantResideInEnugu;
    if (nyscCheck == "Yes") {
        document.querySelector("#nyscChecker1").style.display = "block";
        document.querySelector("#nyscChecker2").style.display = "none";
    } else {
        document.querySelector("#nyscChecker1").style.display = "none";
        document.querySelector("#nyscChecker2").style.display = "block";
    }
    if (laptopCheck == "Yes") {
        document.querySelector("#laptopChecker1").style.display = "block";
        document.querySelector("#laptopChecker2").style.display = "none";

    } else {
        document.querySelector("#laptopChecker1").style.display = "none";
        document.querySelector("#laptopChecker2").style.display = "block";
    }
    if (programmingExpCheck == "Yes") {
        document.querySelector("#programmingExpChecker1").style.display = "block";
        document.querySelector("#programmingExpChecker2").style.display = "none";
    } else {
        document.querySelector("#programmingExpChecker1").style.display = "none";
        document.querySelector("#programmingExpChecker2").style.display = "block";
    }
    if (ResideInEnuguCheck == "Yes") {
        document.querySelector("#resideInEnuguChecker1").style.display = "block";
        document.querySelector("#resideInEnuguChecker2").style.display = "none";
    } else {
        document.querySelector("#resideInEnuguChecker1").style.display = "none";
        document.querySelector("#resideInEnuguChecker2").style.display = "block";
    }

    $("#nysc").val(nyscCheck);
    $("#laptop").val(laptopCheck);
    $("#programmingExp").val(programmingExpCheck);
    $("#ApplicantResideInEnugu").val(ResideInEnuguCheck);
    $("#programmingExpList").val(ProgrammingLanguagesExps);
    $("#reasons").val(ReasonForProgramming);
}
// ACCEPT APPLICATION  POST ACTION
function AcceptApplicationPost()
{
    $('#loader').show();
    $('#loader-wrapper').show();

    var actionType = "Accepted";
    var data = {};
    data.Id = $("#qualifyId").val();
    data.Status = actionType;
    let applicationToBeAccepted = JSON.stringify(data);
    $.ajax({
        type: 'POST',
        dataType: 'Json',
        url: '/Admin/ApplicationStatusPost',
        data:
        {
            applicantDetails: applicationToBeAccepted
        },
        success: function (result)
        {
            
            if (!result.isError)
            {
                $("#loader").fadeOut(3000);
                var url = '/Admin/InterviewResult'
                successAlertWithRedirect(result.msg, url)
            }
            else
            {
                $("#loader").fadeOut(3000);
                errorAlert(result.msg)
            }
        },
        Error: function (ex)
        {
            $("#loader").fadeOut(3000);
            errorAlert(ex);
        }
    });
}

// REJECT APPLICATION POST ACTION
function RejectApplicationPost() {
    $('#loader').show();
    $('#loader-wrapper').show();

    var actionType = "Rejected";
    var data = {};
    data.Id = $("#disqualifyId").val();
    data.Status = actionType;
    let applicationToBeRejected = JSON.stringify(data);
    $.ajax({
        type: 'POST',
        dataType: 'Json',
        url: '/Admin/ApplicationStatusPost',
        data:
        {
            applicantDetails: applicationToBeRejected
        },
        success: function (result)
        {
            
            if (!result.isError)
            {
                $("#loader").fadeOut(3000);
                var url = '/Admin/InterviewResult'
                successAlertWithRedirect(result.msg, url)
            }
            else
            {
                $("#loader").fadeOut(3000);
                errorAlert(result.msg)
            }
        },
        Error: function (ex)
        {
            $("#loader").fadeOut(3000);
            errorAlert(ex);
        }
    });
}

// REJECT APPLICATION POST ACTION
function RejectNewApplicationPost() {
    $('#loader').show();
    $('#loader-wrapper').show();

    var actionType = "Rejected";
    var data = {};
    data.Id = $("#rejectApplicantId").val();
    data.Status = actionType;
    let applicationToBeRejected = JSON.stringify(data);
    $.ajax({
        type: 'POST',
        dataType: 'Json',
        url: '/Admin/ApplicationStatusPost',
        data:
        {
            applicantDetails: applicationToBeRejected
        },
        success: function (result) {

            if (!result.isError) {
                $("#loader").fadeOut(3000);
                var url = '/Admin/OnboardingStudent'
                successAlertWithRedirect(result.msg, url)
            }
            else {
                $("#loader").fadeOut(3000);
                errorAlert(result.msg)
            }
        },
        Error: function (ex) {
            $("#loader").fadeOut(3000);
            errorAlert(ex);
        }
    });
}
// QUALIFY APPLICANT FOR INTERVIEW  POST ACTION
function QualifyApplicantForInterview() {
    $('#loader').show();
    $('#loader-wrapper').show();

    var data = $("#acceptApplicantId").val();
    let applicationData = data;
    $.ajax({
        type: 'POST',
        dataType: 'Json',
        url: '/Admin/QualifyApllicantFoeWrittenInterview',
        data:
        {
            userId: applicationData
        },
        success: function (result) {

            if (!result.isError) {
                $("#loader").fadeOut(3000);
                var url = '/Admin/OnboardingStudent'
                successAlertWithRedirect(result.msg, url)
            }
            else {
                $("#loader").fadeOut(3000);
                errorAlert(result.msg)
            }
        },
        Error: function (ex) {
            $("#loader").fadeOut(3000);
            errorAlert(ex);
        }
    });
}
// DOCUMENTATION SUBMISSION 
function ApplicantDocumentation() {
    
    var file = {};
    file.FirstGuarantor = document.getElementById("FirstGuarantor").files;
    file.SecondGuarantor = document.getElementById("SecondGuarantor").files;
    file.NepaBill = document.getElementById("NepaBill").files;
    file.Contractforms = document.getElementById("Contractforms").files;
    var BVN = $('#BVN').val();
    if (file.FirstGuarantor[0] != null && file.SecondGuarantor[0] != null && file.NepaBill[0] != null && file.Contractforms[0] != null && BVN != null) {

        $('#loader').show();
        $('#loader-wrapper').show();
        if (file.FirstGuarantor[0] != null) {
            const reader = new FileReader();
            reader.readAsDataURL(file.FirstGuarantor[0]);
            var base64FirstGuarantor;
            reader.onload = function () {
                base64FirstGuarantor = reader.result;


                if (file.SecondGuarantor[0] != null) {
                    const reader = new FileReader();
                    reader.readAsDataURL(file.SecondGuarantor[0]);
                    var base64SecondGuarantor;
                    reader.onload = function () {
                        base64SecondGuarantor = reader.result;

                        if (file.NepaBill[0] != null) {
                            const reader = new FileReader();
                            reader.readAsDataURL(file.NepaBill[0]);
                            var base64NepaBill;
                            reader.onload = function () {
                                base64NepaBill = reader.result;

                                if (file.Contractforms[0] != null) {
                                    const reader = new FileReader();
                                    reader.readAsDataURL(file.Contractforms[0]);
                                    var base64Contractforms;
                                    reader.onload = function () {
                                        base64Contractforms = reader.result;
                                        var allDocument = {};
                                        allDocument.BVN = BVN;
                                        allDocument.FirstGuarantor = base64FirstGuarantor;
                                        allDocument.SecondGuarantor = base64SecondGuarantor;
                                        allDocument.NepaBill = base64NepaBill;
                                        allDocument.SignedContract = base64Contractforms;

                                        if (BVN != "" || BVN != 0) {
                                            let rawData = JSON.stringify(allDocument);
                                            $.ajax({
                                                type: 'Post',
                                                dataType: 'Json',
                                                url: '/Student/SubmitApplicantDocument',
                                                data:
                                                {
                                                    applicantDetailedDocuments: rawData,
                                                },
                                                success: function (result) {

                                                    if (result.isError) {
                                                        $("#loader").fadeOut(3000);
                                                        errorAlert(result.msg)
                                                    }
                                                    else {
                                                        $("#loader").fadeOut(3000);
                                                        var url = '/Student/ViewApplicantsDocumentation';
                                                        newSuccessAlert(result.msg, url);
                                                    }
                                                },
                                                error: function (ex) {
                                                    $("#loader").fadeOut(3000);
                                                    errorAlert("Error occured try again");
                                                }
                                            })
                                        }
                                        else {
                                            $("#loader").fadeOut(3000);
                                            errorAlert("Incorrect Details");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }
    }
    else {
        
        if (BVN == "") {
            document.querySelector("#BVNVDT").style.display = "block";
        } else {
            document.querySelector("#BVNVDT").style.display = "none";
        }
        if (file.FirstGuarantor[0] == null) {
            document.querySelector("#FirstGuarantorVDT").style.display = "block";
        } else {
            document.querySelector("#FirstGuarantorVDT").style.display = "none";
        }
        if (file.SecondGuarantor[0] == null) {
            document.querySelector("#SecondGuarantorVDT").style.display = "block";
        } else {
            document.querySelector("#SecondGuarantorVDT").style.display = "none";
        }
        if (file.NepaBill[0] == null) {
            document.querySelector("#NepaBillVDT").style.display = "block";
        } else {
            document.querySelector("#NepaBillVDT").style.display = "none";
        }
        if (file.Contractforms[0] == null) {
            document.querySelector("#ContractformsVDT").style.display = "block";
        } else {
            document.querySelector("#ContractformsVDT").style.display = "none";
        }
    }
}

// CHANGE PASSWORD POST ACTION
function ChangePasswordPost() {
    
    $('#loader').show();
    $('#loader-wrapper').show();
    var data = {};
    data.OldPassword = $("#OldPasswrd").val();
    data.NewPassword = $("#NewPasswrd").val();
    data.ConfirmPassword = $("#Cpasswrd").val();
    let changePasswordDetails = JSON.stringify(data);
    $.ajax({
        type: 'POST',
        dataType: 'Json',
        url: '/Accounts/ChangePasswordPost',
        data:
        {
            userPasswordDetails: changePasswordDetails
        },
        success: function (result) {
            
            if (!result.isError) {
                $("#loader").fadeOut(3000);
                successAlertWithRedirect(result.msg, result.url)
            }
            else {
                $("#loader").fadeOut(3000);
                errorAlert(result.msg)
            }
        },
        Error: function (ex) {
            $("#loader").fadeOut(3000);
            errorAlert(ex);
        }
    });
}

// FORGOT PASSWORD POST ACTION
function ForgotPasswordReset()
{
    var email = $("#Email").val();
    if (email != "") {
        let emailAccount = email;
        $.ajax({
            type: 'POST',
            url: '/Accounts/ForgotPassword', // we are calling json method
            dataType: 'json',
            data:
            {
                email: emailAccount,
            },
            success: function (result) {
                
                if (!result.isNotVerified) {
                    var url = '/Accounts/Login';
                    successAlertWithRedirect(result.msg, url)
                }
                else {
                    errorAlert(result.msg);
                }
            },
            Error: function (ex) {
                errorAlert(ex);
            }
        });
    }
    else
    {
        errorAlert("Enter your email");
    }
}

// SET NEW PASSWORD POST ACTION
function resetPassword()
{
    
    $('#loader').show();
    $('#loader-wrapper').show();
    var data = {};
    data.Password = $("#newPasswordId").val();
    data.ConfirmPassword = $("#confirmPasswordId").val();
    data.Token = $("#Token").val();
    let resetPasswordViewModel = JSON.stringify(data);
    if (data.Password != "" && data.ConfirmPassword != "" && data.Password == data.ConfirmPassword) {
        $.ajax({
            type: 'POST',
            url: '/Accounts/ResetUserPassword', // we are calling json method
            dataType: 'json',
            data:
            {
                viewmodel: resetPasswordViewModel,
            },
            success: function (result) {

                if (!result.isError) {
                    $("#loader").fadeOut(3000);
                    successAlert(result.msg)
                    window.location.reload;
                }
                else {
                    $("#loader").fadeOut(3000);
                    errorAlert(result.msg);
                }
            },
            error: function (ex) {
                $("#loader").fadeOut(3000);
                errorAlert(ex);
            }
        });
    } else {
        if (data.Password == "") {
            errorAlert("Enter password");
        }
        if (data.Password != data.ConfirmPassword) {
            errorAlert("Password and password confirm not matched");
        }
    }
}

function CreateTrainingCourse(action) {
    
    var data = {};
    var logo = document.getElementById("Logo").files;
    data.Title = $('#Title').val();
    data.Description = $('#Description').val();
    data.Amount = $('#Cost').val();
    data.Duration = $('#Duration').val();
    data.TestDuration = $('#TestDuration').val();
    data.ActionType = action;
    if (logo[0] == null || data.Title == "" || data.Description == "" || data.Amount == "" || data.Duration == "" || data.TestDuration == "") {
        if (logo[0] != null) {
            document.querySelector("#logoVDT").style.display = "block";
        } else {
            document.querySelector("#logoVDT").style.display = "none";
        }
        if (data.Title == "") {
            document.querySelector("#titleVDT").style.display = "block";
        } else {
            document.querySelector("#titleVDT").style.display = "none";
        }
        if (data.Description == "") {
            document.querySelector("#descVDT").style.display = "block";
        } else {
            document.querySelector("#descVDT").style.display = "none";
        }
        if (data.Amount == "") {
            document.querySelector("#amtcVDT").style.display = "block";
        } else {
            document.querySelector("#amtcVDT").style.display = "none";
        }
        if (data.Duration == "") {
            document.querySelector("#durationVDT").style.display = "block";
        } else {
            document.querySelector("#durationVDT").style.display = "none";
        }
        if (data.TestDuration == "") {
            document.querySelector("#testDurationVDT").style.display = "block";
        } else {
            document.querySelector("#testDurationVDT").style.display = "none";
        }
    }
    else {
        document.querySelector("#titleVDT").style.display = "none";
        document.querySelector("#descVDT").style.display = "none";
        document.querySelector("#amtcVDT").style.display = "none";
        document.querySelector("#durationVDT").style.display = "none";
        document.querySelector("#testDurationVDT").style.display = "none";
        document.querySelector("#logoVDT").style.display = "none";

        $('#loader').show();
        $('#loader-wrapper').show();

        const reader = new FileReader();
        reader.readAsDataURL(logo[0]);

        reader.onload = function () {
            data.Logo = reader.result;

            SendTrainingCourseToController(data);
        }
    }
}

function EditTrainingCourse(action) {
    
    var data = {};
    var logo = document.getElementById("Edit_Logo").files;
    data.Id = $('#Edit_Id').val();
    data.Title = $('#Edit_Title').val();
    data.Description = $('#Edit_Description').val();
    data.Amount = $('#Edit_Cost').val();
    data.Duration = $('#Edit_Duration').val();
    data.TestDuration = $('#Edit_TestDuration').val();
    data.ActionType = action;
    if (logo[0] != null) {
        const reader = new FileReader();
        reader.readAsDataURL(logo[0]);

        reader.onload = function () {
            data.Logo = reader.result;
        }
    }
    SendTrainingCourseToController(data);
}

function SendTrainingCourseToController(data) {
    let collectedData = JSON.stringify(data);

    $.ajax({
        type: 'Post',
        dataType: 'json',
        url: '/Admin/TrainingCoursePost',
        data:
        {
            collectedTrainingData: collectedData,
        },
        success: function (result) {

            if (!result.isError) {
                $("#loader").fadeOut(3000);
                var url = '/Admin/TrainingCourse';
                successAlertWithRedirect(result.msg, url)
            }
            else {
                $("#loader").fadeOut(3000);
                errorAlert(result.msg)
            }
        },
        error: function (ex) {
            $("#loader").fadeOut(3000);
            errorAlert("Error occured try again");
        }
    });
}

function TrainingCoursePost(action, id)
{
    
    if (action == 'DeactivateTrainingCourse' || action == 'ActivateTrainingCourse' && id != "")
    {
        var data = {};
        data.Id = id;
        data.ActionType = action;
        if (data.Id != "") {
            SendTrainingCourseToController(data);
        } else {
            errorAlert("Error occured try again");
        }
    }
    else if (action == 'DeleteTrainingCourse')
    {
        var data = {};
        data.Id = $('#Delete_Id').val();
        data.ActionType = action;
        if (data.Id != "") {
            SendTrainingCourseToController(data);
        } else {
            errorAlert("Error occured try again");
        }
    }
}

// GET TRAINING COST FOR EDIT
function GetTrainingCourseById(Id)
{
    
    $.ajax({
        type: 'GET',
        url: '/Admin/GetTrainingCourseById', // we are calling json method
        data: { Id: Id },
        dataType: 'json',
        success: function (data)
        {
            
            if (!data.isError)
            {
                $("#Delete_Id").val(data.id);
                $("#Edit_Id").val(data.id);
                $("#Edit_Title").val(data.title);
                $("#Edit_Description").val(data.description);
                $("#Edit_Cost").val(data.amount);
                $("#Edit_Duration").val(data.duration);
                $("#Edit_TestDuration").val(data.testDuration);
                $("#Edit_Logo").val(data.logo);
            }
        }
    });
}

// GET PAYMENT BY ID
function GetPaymentById(Id) {
    
    $.ajax({
        type: 'GET',
        url: '/Admin/GetPaymentById', // we are calling json method
        data: { Id: Id },
        dataType: 'json',
        success: function (data) {
            
            if (!data.isError) {
                $("#approvedId").val(data.id);
                $("#declineId").val(data.id);
            }
        }
    });
}

// APPROVE PAYMENT  POST ACTION
function ApprovePaymentPost() {
    
    $('#loader').show();
    $('#loader-wrapper').show();
    var actionType = "Approved";
    var data = {};
    data.Id = $("#approvedId").val();
    data.Status = actionType;
    if (data.Id > 0 && data.Id != '') {
        let paymentdata = JSON.stringify(data);
        $.ajax({
            type: 'POST',
            dataType: 'Json',
            url: '/Admin/PaymentPostAction',
            data:
            {
                collectedPaymentID: paymentdata
            },
            success: function (result) {
                
                if (!result.isError) {
                    $("#loader").fadeOut(3000);
                    var url = '/Admin/Payments'
                    successAlertWithRedirect(result.msg, url)
                }
                else {
                    $("#loader").fadeOut(3000);
                    errorAlert(result.msg)
                }
            },
            Error: function (ex) {
                $("#loader").fadeOut(3000);
                errorAlert(ex);
            }
        });
    }
    else {
        $("#loader").fadeOut(3000);
        errorAlert("Error Occurred, Please Try Again");
    }

}

// DECLINE PAYMEN POST ACTION
function DeclinePaymentPost() {
    
    $('#loader').show();
    $('#loader-wrapper').show();
    var actionType = "Declined";
    var data = {};
    data.Id = $("#declineId").val();
    data.Status = actionType;
    if (data.Id > 0 && data.Id != '') {
        let paymentdata = JSON.stringify(data);
        $.ajax({
            type: 'POST',
            dataType: 'Json',
            url: '/Admin/PaymentPostAction',
            data:
            {
                collectedPaymentID: paymentdata
            },
            success: function (result) {
                
                if (!result.isError) {
                    $("#loader").fadeOut(3000);
                    var url = '/Admin/Payments'
                    successAlertWithRedirect(result.msg, url)
                }
                else {
                    $("#loader").fadeOut(3000);
                    errorAlert(result.msg)
                }
            },
            Error: function (ex) {
                $("#loader").fadeOut(3000);
                errorAlert(ex);
            }
        });
    }
    else {
        $("#loader").fadeOut(3000);
        errorAlert("Error Occurred, Please Try Again");
    }
}

function manualSubmitTest(action, Id)
{
    
    $('#loader').show();
    $('#loader-wrapper').show();
    var data = [];
    var allCheckedFeatures = document.getElementsByClassName("chkd");

    for (var i = 0; i < allCheckedFeatures.length; i++)
    {
        var ckd = { questionId: '', selectedAnswer: '' };

        if (allCheckedFeatures[i].checked) {
            ckd.questionId = allCheckedFeatures[i].name;
            ckd.selectedAnswer = allCheckedFeatures[i].value;
            data.push(ckd);
        }
    }
    var resultCount = data.length;
    if (resultCount == 10)
    {
        //Check if answers has been submitted automatically
        var stopper = $("#manualStopper").val();
        if (stopper == "Off")
        {
            $("#autoStopper").val("On");
            
            let dataa = {};
            dataa.AnsweredQuestions = data;
            dataa.ActionType = action;
            dataa.Id = Id;
            let QandA = JSON.stringify(dataa);
            $.ajax({
                type: 'Post',
                dataType: 'json',
                url: '/Student/SubmitTestQuestions',
                data:
                {
                    collectedData: QandA,
                },
                success: function (result) {
                    
                    if (!result.isError) {
                        $("#loader").fadeOut(3000);
                        var url = '/Student/TakeTest/' + result.courseID;
                        successAlertWithRedirect(result.msg, url)
                    }
                    else {
                        $("#loader").fadeOut(3000);
                        errorAlert(result.msg)
                    }
                },
                error: function (ex) {
                    $("#loader").fadeOut(3000);
                    errorAlert("Error occured try again");
                }
            });
        }
    }
    else
    {
        $("#loader").fadeOut(3000);
        errorAlert("Answer All the questions");
    }

}

function autoSubmitTest(action, Id)
{
    
    //Check if answers has been submitted manually
    var stopper = $("#autoStopper").val();
    if (stopper == "Off")
    {
        $("#manualStopper").val("On");
        
        $('#loader').show();
        $('#loader-wrapper').show();
        var data = [];
        var allCheckedFeatures = document.getElementsByClassName("chkd");

        for (var i = 0; i < allCheckedFeatures.length; i++) {
            var ckd = { questionId: '', selectedAnswer: '' };

            if (allCheckedFeatures[i].checked) {
                ckd.questionId = allCheckedFeatures[i].name;
                ckd.selectedAnswer = allCheckedFeatures[i].value;
                data.push(ckd);
            }
        }
        var resultCount = data.length;
        
        let dataa = {};
        dataa.AnsweredQuestions = data;
        dataa.ActionType = action;
        dataa.Id = Id;
        let QandA = JSON.stringify(dataa);
        $.ajax({
            type: 'Post',
            dataType: 'json',
            url: '/Student/SubmitTestQuestions',
            data:
            {
                collectedData: QandA,
            },
            success: function (result) {
                
                if (!result.isError) {
                    $("#loader").fadeOut(3000);
                    var url = '/Student/TakeTest/' + result.courseID;
                    successAlertWithRedirect(result.msg, url)
                }
                else {
                    $("#loader").fadeOut(3000);
                    errorAlert(result.msg)
                }
            },
            error: function (ex) {
                $("#loader").fadeOut(3000);
                errorAlert("Error occured try again");
            }
        });
    }
}

// SUBMIT PROJECT TOPICS
function SubmitProjectTopic() {
    
    $('#loader').show();
    $('#loader-wrapper').show();
    var data = {};
    data.CourseId = $("#name").val();
    data.Title = $("#title").val();
    data.Description = $("#description").val();
    if (data.CourseId != 0 && data.Title != "" && data.Description != "") {
        let topicsData = JSON.stringify(data);
        $.ajax({
            type: 'POST',
            dataType: 'Json',
            url: '/Student/UploadProjectTopics',
            data:
            {
                topics: topicsData
            },
            success: function (result) {
                
                if (!result.isError) {
                    $("#loader").fadeOut(3000);
                    var url = '/Student/ProjectTopics'
                    successAlertWithRedirect(result.msg, url)
                }
                else {
                    $("#loader").fadeOut(3000);
                    errorAlert(result.msg)
                }
            },
            Error: function (ex) {
                $("#loader").fadeOut(3000);
                errorAlert(ex);
            }
        });
    }
    else
    {
        $("#loader").fadeOut(3000);
        if (data.CourseId == 0) {
            document.querySelector("#nameVDT").style.display = "block"
        } else {
            document.querySelector("#nameVDT").style.display = "none"
        }
        if (data.Title == "") {
            document.querySelector("#titleVDT").style.display = "block"
        } else {
            document.querySelector("#titleVDT").style.display = "none"
        }
        if (data.Description == "") {
            document.querySelector("#descriptionVDT").style.display = "block"
        } else {
            document.querySelector("#descriptionVDT").style.display = "none"
        }
    }

}

// SUBMIT PROJECT GIT LINK
function AddProjectLink() {
    
    $('#loader').show();
    $('#loader-wrapper').show();
    var projectData = {};
    projectData.Id = $("#update_Id").val();
    projectData.GitLink = $("#git_link").val();
    projectData.RedmineLink = $("#redmine_link").val();
    if (projectData.GitLink != "" && projectData.RedmineLink != "") {
        let topicData = JSON.stringify(projectData);
        $.ajax({
            type: 'POST',
            dataType: 'Json',
            url: '/Student/ProjectLinkUpdatePost',
            data:
            {
                topicData : topicData
            },
            success: function (result) {
                
                if (!result.isError) {
                    $("#loader").fadeOut(3000);
                    var url = '/Student/AprovedTopics'
                    successAlertWithRedirect(result.msg, url)
                }
                else {
                    $("#loader").fadeOut(3000);
                    errorAlert(result.msg)
                }
            },
            Error: function (ex) {
                $("#loader").fadeOut(3000);
                errorAlert(ex);
            }
        });
    }
    else {
        $("#loader").fadeOut(3000);
        if (projectData.GitLink == "") {
            document.querySelector("#git_linkVDT").style.display = "block"
        } else {
            document.querySelector("#git_linkVDT").style.display = "none"
        }
        if (projectData.RedmineLink == "") {
            document.querySelector("#redmine_linkVDT").style.display = "block"
        } else {
            document.querySelector("#redmine_linkVDT").style.display = "none"
        }
    }

}

// EDIT PROJECT GIT LINK
function EditProjectLink(action) {
    
    $('#loader').show();
    $('#loader-wrapper').show();
    var projectData = {};
    projectData.Id = $("#edit_Id").val();
    projectData.GitLink = $("#edit_Git_link").val();
    projectData.RedmineLink = $("#edit_Redmine_link").val();
    if (projectData.GitLink != "" && projectData.RedmineLink != "") {
        let topicData = JSON.stringify(projectData);
        $.ajax({
            type: 'POST',
            dataType: 'Json',
            url: '/Student/ProjectLinkUpdatePost',
            data:
            {
                topicData: topicData
            },
            success: function (result) {
                
                if (!result.isError) {
                    $("#loader").fadeOut(3000);
                    var url = '/Student/AprovedTopics'
                    successAlertWithRedirect(result.msg, url)
                }
                else {
                    $("#loader").fadeOut(3000);
                    errorAlert(result.msg)
                }
            },
            Error: function (ex) {
                $("#loader").fadeOut(3000);
                errorAlert(ex);
            }
        });
    }
    else {
        $("#loader").fadeOut(3000);
        if (projectData.GitLink == "") {
            document.querySelector("#edit_Git_linkVDT").style.display = "block"
        } else {
            document.querySelector("#edit_Git_linkVDT").style.display = "none"
        }
        if (projectData.RedmineLink == "") {
            document.querySelector("#edit_Redmine_linkVDT").style.display = "block"
        } else {
            document.querySelector("#edit_Redmine_linkVDT").style.display = "none"
        }
    }

}

// GET Project Links
function GetLinksById(Id) {
    
    $.ajax({
        type: 'GET',
        url: '/Student/GetProjectLinksById',
        data: { Id: Id },
        dataType: 'json',
        success: function (data) {
            
            if (!data.isError) {
                document.getElementById("gitLinkView").innerHTML = data.gitLink;
                document.getElementById("redmineLinkView").innerHTML = data.redmineLink;
                $("#copyGit").val(data.gitLink);
                $("#copyRedmine").val(data.redmineLink);
            }
        }
    });
}

//SEND COURSEID FOR PAYMENT 
function SendCourseIdForPayment() {
    
    $('#loader').show();
    $('#loader-wrapper').show();
    var id = $('#courseId').val();
    let Id = id;
    $.ajax({
        type: 'Post',
        dataType: 'json',
        url: '/Student/GetPaymentDetials',
        data:
        {
            Id: Id,
        },
        success: function (result) {
            
            if (!result.isError) {
                $("#loader").fadeOut(3000);
                Swal.fire ({
                        title: "Success",
                        text: "You're good to go,Let's make the payment now",
                        icon: "success",
                        timer: "30000",
                        confirmButtonColor: "##0253cc",

                    })
                    .then(function ()
                    {
                        location.href = result.paystackUrl;
                    });
            }
        },
        error: function (ex)
        {
            $("#loader").fadeOut(3000);
            errorAlert("Error occured try again");
        }
    });
}
// APPLICATION REQUEST 
function ManualPaymentAUpload() {
    
    $('#loader').show();
    $('#loader-wrapper').show();

    var file = document.getElementById("prove").files;
    
    if (file[0] != null) {
        const reader = new FileReader();
        reader.readAsDataURL(file[0]);

        reader.onload = function () {
            var data = {};
            data.Id = $('#courseId').val();
            data.ProveOfPayment = reader.result;
            
            if (data.ProveOfPayment != "" && data.Id > 0) {
                let paymentData = JSON.stringify(data);
                $.ajax({
                    type: 'Post',
                    dataType: 'json',
                    url: '/Student/ManualPaymenUpload',
                    data:
                    {
                        paymentData: paymentData,
                    },
                    success: function (result) {
                        
                        if (!result.isError) {
                            $("#loader").fadeOut(3000);

                            var url = '/Student/StudentCourses';
                            successAlertWithRedirect(result.msg, url)
                        }
                        else {
                            $("#loader").fadeOut(3000);
                            errorAlert(result.msg)
                        }
                    },
                    error: function (ex) {
                        $("#loader").fadeOut(3000);
                        errorAlert("Error occured try again");
                    }
                });
            }
            else {
                $("#loader").fadeOut(3000);
                errorAlert("Only PDF file is allowed");
            }
        }
    }
    else
    {
        $("#loader").fadeOut(3000);
        errorAlert("Upload Prove to proceed");
    }
}
function ApplicantsGetJobById(id) {

    $.ajax({
        type: 'GET',
        url: '/Student/FindJob',
        data: { jobId: id },
        dataType: 'json',
        success: function (data) {

            if (!data.isError) {
                var desc = data.description.split("\n");
                var resp = data.responsibilities.split("\n");
                var requ = data.requirements.split("\n");
                document.getElementById('jobDescriptionView').innerHTML = "<ul><li>" + desc.join("</li><br><li>") + "</li></ul>";
                document.getElementById('jobResponsibilitiesView').innerHTML = "<ul><li>" + resp.join("</li><br><li>") + "</li></ul>";
                document.getElementById('jobRequirementsView').innerHTML = "<ul><li>" + requ.join("</li><br><li>") + "</li></ul>";
                document.getElementById('companyName').innerHTML = "<b>Company Name : <b>" + data.companyName + "</b>";
                document.getElementById('title').innerHTML = "<b>Job Title : " + data.title + "</b>";
                document.getElementById('salary').innerHTML = "<b>Salary : ₦" + data.salary.toLocaleString('en-US') + " a month" + "</b>";
                var typee = data.type;
                if (typee == 1) {
                    document.getElementById('type').innerHTML = "<b>Full-time (On Premise)</b>";
                } else if (typee == 2) {
                    document.getElementById('type').innerHTML = "<b>Part-time (On Premise)</b>";
                }
                else if (typee == 3) {
                    document.getElementById('type').innerHTML = "<b>Full-time (On Home)</b>";
                }
                else{
                    document.getElementById('type').innerHTML = "<b>Part-time (On Home)</b>";
                }
            }
        }
    });
}

// SEARCH MAPPING FOR JOBS
function MapJoyTypeIdForSearch() {
    var searchId = $("#jobSearch").val();
    var address = "/Student/Jobs/" + searchId;
    $("a[href]").attr("href", address)
}

function manualSubmitInterviewTest() {
    //Check if answers has been submitted automatically
    var stopper = $("#manualStopper").val();
    if (stopper == "Off")
    {
        
        $("#autoStopper").val("On");

        $('#loader').show();
        $('#loader-wrapper').show();
        var data = [];
        var allCheckedFeatures = document.getElementsByClassName("chkd");

        for (var i = 0; i < allCheckedFeatures.length; i++) {
            var CheckedAnswers = { questionId: '', selectedAnswer: '' };

            if (allCheckedFeatures[i].checked) {
                CheckedAnswers.questionId = allCheckedFeatures[i].name;
                CheckedAnswers.selectedAnswer = allCheckedFeatures[i].value;
                data.push(CheckedAnswers);
            }
        }
        var resultCount = data.length;
        if (resultCount == 20) {
            let dataa = {};
            dataa.InterviewAnsweredQuestions = data;
            let questionAndAnswer = JSON.stringify(dataa);
            $.ajax({
                type: 'Post',
                dataType: 'json',
                url: '/Student/SubmitInterviewAnwser',
                data:
                {
                    collectedData: questionAndAnswer,
                },
                success: function (result) {

                    if (!result.isError) {
                        $("#loader").fadeOut(3000);
                        var url = '/Student/Index';
                        successAlertWithRedirect(result.msg, url)
                    }
                    else {
                        $("#loader").fadeOut(3000);
                        errorAlert(result.msg)
                    }
                },
                error: function (ex) {
                    $("#loader").fadeOut(3000);
                    errorAlert("Error occured try again");
                }
            });
        }
        else
        {
            $("#loader").fadeOut(3000);
            errorAlert("Answer All the questions");
        }
    }
    else {
        $("#loader").fadeOut(3000);
    }
}

function autoSubmitInterview() {
    
    //Check if answers has been submitted manually
    var stopper = $("#autoStopper").val();
    if (stopper == "Off") {
        $("#manualStopper").val("On");

        $('#loader').show();
        $('#loader-wrapper').show();
        var data = [];
        var allCheckedFeatures = document.getElementsByClassName("chkd");

        for (var i = 0; i < allCheckedFeatures.length; i++) {
            var CheckedAnswers = { questionId: '', selectedAnswer: '' };

            if (allCheckedFeatures[i].checked) {
                CheckedAnswers.questionId = allCheckedFeatures[i].name;
                CheckedAnswers.selectedAnswer = allCheckedFeatures[i].value;
                data.push(CheckedAnswers);
            }
        }

        let dataa = {};
        dataa.InterviewAnsweredQuestions = data;
        let questionAndAnswer = JSON.stringify(dataa);
        $.ajax({
            type: 'Post',
            dataType: 'json',
            url: '/Student/SubmitInterviewAnwser',
            data:
            {
                collectedData: questionAndAnswer,
            },
            success: function (result) {

                if (!result.isError) {
                    $("#loader").fadeOut(3000);
                    var url = '/Student/Index';
                    successAlertWithRedirect(result.msg, url)
                }
                else {
                    $("#loader").fadeOut(3000);
                    errorAlert(result.msg)
                }
            },
            error: function (ex) {
                $("#loader").fadeOut(3000);
                errorAlert("Error occured try again");
            }
        });
    }
}

//COPY TEXT
function CopyLink(type) {
    
    var id = type;
    var copiedLink = document.getElementById(id);

    // Select the text field
    copiedLink.select();
    copiedLink.setSelectionRange(0, 99999); // For mobile devices

    // Copy the text inside the text field
    navigator.clipboard.writeText(copiedLink.value);

    // Alert the copied text
    if (copiedLink.value) {
        successAlert("Copied: " + copiedLink.value)
    }
}
// <!......................... ADMIN SCRIPTS ............................>
function CourseVideoPost(action) {
    
    $('#loader').show();
    $('#loader-wrapper').show();
    var data = {};
    if (action == "CREATE") {
        data.ActionType = action;
        data.CourseId = $("#name").val();
        var nameVDT = document.querySelector("#nameValidation");
        data.Outline = $("#outline").val();
        var outlineVDT = document.querySelector("#outlineValidation");
        data.VideoLink = $("#videoLink").val();
        var videoLinkVDT = document.querySelector("#videoLinkValidation");
    }
    if (action == "EDIT") {
        data.ActionType = action;
        data.Id = $("#edit_Id").val();
        data.CourseId = $("#edit_Name").val();
        var nameVDT = document.querySelector("#edit_NameValidation");
        data.Outline = $("#edit_Outline").val();
        var outlineVDT = document.querySelector("#edit_OutlineValidation");
        data.VideoLink = $("#edit_videoLink").val();
        var videoLinkVDT = document.querySelector("#edit_videoLinkValidation");
    }
    if (action == "DELETE") {
        data.ActionType = action;
        data.Id = $("#Delete_Id").val();
    }

    if (data.ActionType == "CREATE") {
        if (data.CourseId != "" && data.Outline != "" && data.VideoLink != "") {
            
            SendVideoDataToController(data);
        }
        else {
            $("#loader").fadeOut(3000);
            if (data.CourseId == "") {
                nameVDT.style.display = "block";
            } else {
                nameVDT.style.display = "none";
            }
            if (data.Outline == "") {
                outlineVDT.style.display = "block";
            } else {
                outlineVDT.style.display = "none";
            }
            if (data.VideoLink == "") {
                videoLinkVDT.style.display = "block";
            } else {
                videoLinkVDT.style.display = "none";
            }
        }
    }
    else if (data.ActionType == "EDIT") {
        if (data.Id != "" && data.CourseId != 0 && data.Outline != "" && data.VideoLink) {
            
            SendVideoDataToController(data);
        }
        else {
            $("#loader").fadeOut(3000);
            if (data.CourseId == "") {
                nameVDT.style.display = "block";
            } else {
                nameVDT.style.display = "none";
            }
            if (data.Outline == "") {
                outlineVDT.style.display = "block";
            } else {
                outlineVDT.style.display = "none";
            }
            if (data.VideoLink == "") {
                videoLinkVDT.style.display = "block";
            } else {
                videoLinkVDT.style.display = "none";
            }
        }
    }
    else if (data.ActionType == "DELETE") {
        if (data.Id != "") {
            
            SendVideoDataToController(data);
        }
    }
    else {

        $("#loader").fadeOut(3000);
        errorAlert("Failed");
    }
}

function SendVideoDataToController(data) {
    let collectedData = JSON.stringify(data);
    
    $.ajax({
        type: 'Post',
        dataType: 'json',
        url: '/Admin/TrainingVideoUpload',
        data:
        {
            collectedVideoData: collectedData,
        },
        success: function (result) {
            
            if (!result.isError) {
                $("#loader").fadeOut(3000);
                var url = '/Admin/TrainingVideos';
                successAlertWithRedirect(result.msg, url)
            }
            else {
                $("#loader").fadeOut(3000);
                errorAlert(result.msg)
            }
        },
        error: function (ex) {
            $("#loader").fadeOut(3000);
            errorAlert("Error occured try again");
        }
    });
}

function FullScreenVideo(videoLink) {
    
    $('#full_Screen').attr('src', videoLink);
}

function ViewOutline2(id) {
    
    $.ajax({
        type: 'GET',
        url: '/Student/GetCourseOutLineById',
        data: { id: id },
        dataType: 'json',
        success: function (data) {
            
            if (!data.isError) {
                var outlin = data.split("\n");
                document.getElementById('view_Outline').innerHTML = "<ul><li>" + outlin.join("</li><br><li>") + "</li></ul>";
            }
        }
    });

}

function GetVideoById(data) {
    let Id = JSON.stringify(data);
    
    $.ajax({
        type: 'GET',
        url: '/Admin/GetVideoById',
        data: { videoId: Id },
        dataType: 'json',
        success: function (data) {
            
            if (!data.isError) {
                $("#Delete_Id").val(data.id);
                $("#edit_Id").val(data.id);
                $("#edit_Name").val(data.courseId);
                $("#edit_Outline").val(data.outline);
                $("#edit_videoLink").val(data.videoLink);
            }
        }
    });
}

function TrainingQuestionPost(action, Id) {
    
    $('#loader').show();
    $('#loader-wrapper').show();
    var data = {};
    if (action == "CREATE") {
        data.ActionType = action;
        data.CourseId = $("#title").val();
        data.Question = $("#question").val();
        data.Answer = $("#answer").val();
        var titleVDT = document.querySelector("#titleValidation");
        var questionVDT = document.querySelector("#questionValidation");
        var awserVDT = document.querySelector("#answerValidation");
    }
    if (action == "EDIT") {
        data.ActionType = action;
        data.Id = $("#edit_Id").val();
        data.CourseId = $("#edit_Title").val();
        data.Question = $("#edit_Question").val();
        data.Answer = $("#edit_Aanswer").val();
        var titleVDT = document.querySelector("#edit_titleValidation");
        var questionVDT = document.querySelector("#edit_questionValidation");
        var awserVDT = document.querySelector("#edit_answerValidation");
    }
    if (action == "DELETE") {
        data.ActionType = action;
        data.Id = $("#Delete_Id").val();
    }
    if (action == "ACTIVATE" || action == "DEACTIVATE") {
        data.ActionType = action;
        data.Id = Id;
    }

    if (data.ActionType == "CREATE") {
        if (data.CourseId != "" && data.Question != "" && data.Answer != "") {
            
            SendQuestionDataToController(data);
        }
        else {
            $("#loader").fadeOut(3000);
            if (data.CourseId == "") {
                titleVDT.style.display = "block";
            } else {
                titleVDT.style.display = "none";
            }
            if (data.Outline == "") {
                questionVDT.style.display = "block";
            } else {
                questionVDT.style.display = "none";
            }
            if (data.Answer == "") {
                awserVDT.style.display = "block";
            } else {
                awserVDT.style.display = "none";
            }
        }
    }
    else if (data.ActionType == "EDIT") {
        if (data.Id != "" && data.CourseId != "" && data.Question != "" && data.Answer != "") {
            
            SendQuestionDataToController(data);
        }
        else {
            $("#loader").fadeOut(3000);
            if (data.CourseId == "") {
                titleVDT.style.display = "block";
            } else {
                titleVDT.style.display = "none";
            }
            if (data.Outline == "") {
                questionVDT.style.display = "block";
            } else {
                questionVDT.style.display = "none";
            }
            if (data.Answer == "") {
                awserVDT.style.display = "block";
            } else {
                awserVDT.style.display = "none";
            }
        }
    }
    else if (data.ActionType == "DELETE" || action == "ACTIVATE" || action == "DEACTIVATE") {
        if (data.Id != "") {
            
            SendQuestionDataToController(data);
        }
    }
    else {
        $("#loader").fadeOut(3000);
        errorAlert("Failed");
    }
}

function SendQuestionDataToController(data) {
    let collectedData = JSON.stringify(data);
    
    $.ajax({
        type: 'Post',
        dataType: 'json',
        url: '/Admin/AdminPostActionsForTestQuestions',
        data:
        {
            collectedTestQuestionsData: collectedData,
        },
        success: function (result) {
            
            if (!result.isError) {
                $("#loader").fadeOut(3000);
                var url = '/Admin/TestQuestions';
                successAlertWithRedirect(result.msg, url)
            }
            else {
                $("#loader").fadeOut(3000);
                errorAlert(result.msg)
            }
        },
        error: function (ex) {
            $("#loader").fadeOut(3000);
            errorAlert("Error occured try again");
        }
    });
}

function GetQuestionById(Id) {
    
    $('#loader').show();
    $('#loader-wrapper').show();
    $.ajax({
        type: 'GET',
        url: '/Admin/GetQuestionById',
        data: { Id: Id },
        dataType: 'json',
        success: function (data) {
            
            if (!data.isError) {
                $("#loader").fadeOut(3000);
                $("#Delete_Id").val(data.id);
                $("#edit_Id").val(data.id);
                $("#edit_Title").val(data.courseId);
                $("#edit_Question").val(data.question);
                $("#edit_Aanswer").val(data.answer);
            }
        }
    });
}

function GetOptionsById(id) {
    
    $.ajax({
        type: 'GET',
        url: '/Admin/GetOptionsByQuestionId',
        data: { id: id },
        dataType: 'json',
        success: function (data) {
            
            if (!data.isError) {
                $("#optQuestionId").val(id);
                if (data.isNull) {

                    document.getElementById("optList").innerHTML = data.val;
                }
                else
                {
                    var dataCount = data.length;
                    $("#optCount").val(dataCount);
                    var list = "<ul><li>" + data.join("</li><li>") + "</li></ul >";
                    document.getElementById("optList").innerHTML = list;

                    $("#option1Edit").val(data[3]);
                    $("#option2Edit").val(data[2]);
                    $("#option3Edit").val(data[1]);
                    $("#option4Edit").val(data[0]);

                }
            }
        }
    });
}

function CreateOption() {
    
    var data = {};
    data.QuestionId = $("#optQuestionId").val();
    data.OptionOne = $("#option1").val();
    data.OptionTwo = $("#option2").val();
    data.OptionThree = $("#option3").val();
    data.OptionFour = $("#option4").val();
    var counter = $("#optCount").val();
    if (counter >= 4) {
        errorAlert("Fialed!!! Maximum of 4 Option per question")
    }
    else
    {
        if (data.QuestionId > 0 && data.OptionOne != "" && data.OptionTwo != "" && data.OptionThree != "" && data.OptionFour != "") {
            let optdata = JSON.stringify(data);

            $('#loader').show();
            $('#loader-wrapper').show();
            $.ajax({
                type: 'POST',
                dataType: 'Json',
                url: '/Admin/AddAnwserOptions',
                data:
                {
                    dataCollected: optdata
                },
                success: function (result) {
                    
                    if (!result.isError) {
                        $("#loader").fadeOut(3000);
                        var url = '/Admin/TestQuestions'
                        successAlertWithRedirect(result.msg, url)
                    }
                    else {
                        $("#loader").fadeOut(3000);
                        errorAlert(result.msg)
                    }
                },
                Error: function (ex) {
                    $("#loader").fadeOut(3000);
                    errorAlert(ex);
                }
            });
        }
        else {
            errorAlert("Fill all option field")
        }

    }
}

function EditOption() {
    
    var data = {};
    data.QuestionId = $("#optQuestionId").val();
    data.OptionOne = $("#option1Edit").val();
    data.OptionTwo = $("#option2Edit").val();
    data.OptionThree = $("#option3Edit").val();
    data.OptionFour = $("#option4Edit").val();
    if (data.QuestionId > 0 && data.OptionOne != "" && data.OptionTwo != "" && data.OptionThree != "" && data.OptionFour != "") {
        let optdata = JSON.stringify(data);

        $('#loader').show();
        $('#loader-wrapper').show();
        $.ajax({
            type: 'POST',
            dataType: 'Json',
            url: '/Admin/AddAnwserOptions',
            data:
            {
                dataCollected: optdata
            },
            success: function (result) {

                if (!result.isError) {
                    $("#loader").fadeOut(3000);
                    var url = '/Admin/TestQuestions'
                    successAlertWithRedirect(result.msg, url)
                }
                else {
                    $("#loader").fadeOut(3000);
                    errorAlert(result.msg)
                }
            },
            Error: function (ex) {
                $("#loader").fadeOut(3000);
                errorAlert(ex);
            }
        });
    }
    else {
        errorAlert("Fill all option field")
    }
}

function InterviewQuestionPost(action, Id) {

    $('#loader').show();
    $('#loader-wrapper').show();
    var data = {};
    if (action == "CREATE") {
        data.ActionType = action;
        data.Question = $("#question").val();
        data.Answer = $("#answer").val();
        var questionVDT = document.querySelector("#questionValidation");
        var awserVDT = document.querySelector("#answerValidation");
    }
    if (action == "EDIT") {
        data.ActionType = action;
        data.Id = $("#edit_Id").val();
        data.Question = $("#edit_Question").val();
        data.Answer = $("#edit_Aanswer").val();
        var questionVDT = document.querySelector("#edit_questionValidation");
        var awserVDT = document.querySelector("#edit_answerValidation");
    }
    if (action == "DELETE") {
        data.ActionType = action;
        data.Id = $("#Delete_Id").val();
    }
    if (action == "ACTIVATE" || action == "DEACTIVATE") {
        data.ActionType = action;
        data.Id = Id;
    }

    if (data.ActionType == "CREATE") {
        if (data.Question != "" && data.Answer != "") {

            SendInterviewQuestionDataToController(data);
        }
        else {
            $("#loader").fadeOut(3000);
            if (data.Question == "") {
                questionVDT.style.display = "block";
            } else {
                questionVDT.style.display = "none";
            }
            if (data.Answer == "") {
                awserVDT.style.display = "block";
            } else {
                awserVDT.style.display = "none";
            }
        }
    }
    else if (data.ActionType == "EDIT") {
        if (data.Id != "" && data.Question != "" && data.Answer != "") {

            SendInterviewQuestionDataToController(data);
        }
        else {
            $("#loader").fadeOut(3000);
            if (data.Question == "") {
                questionVDT.style.display = "block";
            } else {
                questionVDT.style.display = "none";
            }
            if (data.Answer == "") {
                awserVDT.style.display = "block";
            } else {
                awserVDT.style.display = "none";
            }
        }
    }
    else if (data.ActionType == "DELETE" || action == "ACTIVATE" || action == "DEACTIVATE") {
        if (data.Id != "") {

            SendInterviewQuestionDataToController(data);
        }
    }
    else {
        $("#loader").fadeOut(3000);
        errorAlert("Failed");
    }
}

function SendInterviewQuestionDataToController(data) {
    let collectedData = JSON.stringify(data);

    $.ajax({
        type: 'Post',
        dataType: 'json',
        url: '/Admin/PostActionsForInterveiwQuestions',
        data:
        {
            collectedTestQuestionsData: collectedData,
        },
        success: function (result) {

            if (!result.isError) {
                $("#loader").fadeOut(3000);
                var url = '/Admin/InterviewQuestions';
                successAlertWithRedirect(result.msg, url)
            }
            else {
                $("#loader").fadeOut(3000);
                errorAlert(result.msg)
            }
        },
        error: function (ex) {
            $("#loader").fadeOut(3000);
            errorAlert("Error occured try again");
        }
    });
}

function MapInterviewData(id, question, answer) {
    $("#Delete_Id").val(id);
    $("#edit_Id").val(id);
    $("#edit_Question").val(question);
    $("#edit_Aanswer").val(answer);
}

function GetInterviewOptionsById(id) {
    $.ajax({
        type: 'GET',
        url: '/Admin/GetInterviewOptionsByQuestionId',
        data: { id: id },
        dataType: 'json',
        success: function (data) {

            if (!data.isError) {
                $("#optQuestionId").val(id);
                if (data.isNull) {

                    document.getElementById("optList").innerHTML = data.val;
                }
                else {
                    var dataCount = data.length;
                    $("#optCount").val(dataCount);
                    var list = "<ul><li>" + data.join("</li><li>") + "</li></ul >";
                    document.getElementById("optList").innerHTML = list;

                    $("#option1Edit").val(data[3]);
                    $("#option2Edit").val(data[2]);
                    $("#option3Edit").val(data[1]);
                    $("#option4Edit").val(data[0]);
                }
            }
        }
    });
}

function CreateInterviewAnsOption() {
    
    var data = {};
    data.QuestionId = $("#optQuestionId").val();
    data.OptionOne = $("#option1").val();
    data.OptionTwo = $("#option2").val();
    data.OptionThree = $("#option3").val();
    data.OptionFour = $("#option4").val();
    var counter = $("#optCount").val();
    if (counter >= 4) {
        errorAlert("Fialed!!! Maximum of 4 Option per question")
    }
    else {
        if (data.QuestionId > 0 && data.OptionOne != "" && data.OptionTwo != "" && data.OptionThree != "" && data.OptionFour != "") {
            let optdata = JSON.stringify(data);

            $('#loader').show();
            $('#loader-wrapper').show();
            $.ajax({
                type: 'POST',
                dataType: 'Json',
                url: '/Admin/AddInterViewAnwserOptions',
                data:
                {
                    dataCollected: optdata
                },
                success: function (result) {

                    if (!result.isError) {
                        $("#loader").fadeOut(3000);
                        var url = '/Admin/InterviewQuestions'
                        successAlertWithRedirect(result.msg, url)
                    }
                    else {
                        $("#loader").fadeOut(3000);
                        errorAlert(result.msg)
                    }
                },
                Error: function (ex) {
                    $("#loader").fadeOut(3000);
                    errorAlert(ex);
                }
            });
        }
        else {
            errorAlert("Fill all option field")
        }

    }
}

function EditInterviewAnsOption() {
    
    var data = {};
    data.QuestionId = $("#optQuestionId").val();
    data.OptionOne = $("#option1Edit").val();
    data.OptionTwo = $("#option2Edit").val();
    data.OptionThree = $("#option3Edit").val();
    data.OptionFour = $("#option4Edit").val();
    if (data.QuestionId > 0 && data.OptionOne != "" && data.OptionTwo != "" && data.OptionThree != "" && data.OptionFour != "") {
        let optdata = JSON.stringify(data);

        $('#loader').show();
        $('#loader-wrapper').show();
        $.ajax({
            type: 'POST',
            dataType: 'Json',
            url: '/Admin/AddInterViewAnwserOptions',
            data:
            {
                dataCollected: optdata
            },
            success: function (result) {

                if (!result.isError) {
                    $("#loader").fadeOut(3000);
                    var url = '/Admin/InterviewQuestions'
                    successAlertWithRedirect(result.msg, url)
                }
                else {
                    $("#loader").fadeOut(3000);
                    errorAlert(result.msg)
                }
            },
            Error: function (ex) {
                $("#loader").fadeOut(3000);
                errorAlert(ex);
            }
        });
    }
    else {
        errorAlert("Fill all option field")
    }
}

function AppoveSelectedProjectTopic(Id) {
    
    $('#loader').show();
    $('#loader-wrapper').show();
    if (Id != "") {
        let id = Id;
        $.ajax({
            type: 'POST',
            dataType: 'Json',
            url: '/Admin/AppoveProjectTopic',
            data:
            {
                id: id
            },
            success: function (result) {
                
                if (!result.isError) {
                    $("#loader").fadeOut(3000);
                    var url = '/Admin/ViewProjectTopics'
                    successAlertWithRedirect(result.msg, url)
                }
                else {
                    $("#loader").fadeOut(3000);
                    errorAlert(result.msg)
                }
            },
            Error: function (ex) {
                $("#loader").fadeOut(3000);
                errorAlert(ex);
            }
        });
    }
    else
    {
        $("#loader").fadeOut(3000);
        errorAlert("Error Occured")
    }
}

function MarkProjectAsCompleted() {
    
    $('#loader').show();
    $('#loader-wrapper').show();
    var id = $('#accept_Id').val();
    if (id != "") {
        let projectId = id;
        $.ajax({
            type: 'POST',
            dataType: 'Json',
            url: '/Admin/MarkProjectAsCompleted',
            data:
            {
                projectId: projectId
            },
            success: function (result) {

                if (!result.isError) {
                    $("#loader").fadeOut(3000);
                    var url = '/Admin/AprovedTopics'
                    successAlertWithRedirect(result.msg, url)
                }
                else {
                    $("#loader").fadeOut(3000);
                    errorAlert(result.msg)
                }
            },
            Error: function (ex) {
                $("#loader").fadeOut(3000);
                errorAlert(ex);
            }
        });
    }
    else {
        $("#loader").fadeOut(3000);
        errorAlert("Error Occured")
    }
}

function JobCreatePost(action) {
    
    $('#loader').show();
    $('#loader-wrapper').show();
    var salaryInt = $('#salary').val();
    var jobData = {};
    jobData.ActionType = action;
    jobData.CompanyName = $("#companyName").val();
    jobData.Title = $("#title").val();
    jobData.Salary = parseFloat(salaryInt).toFixed(2);
    jobData.Type = $("#type").val();
    jobData.Description = $("#description").val();
    jobData.Responsibilities = $("#responsibilities").val();
    jobData.Requirements = $("#requirements").val();
    if (jobData.CompanyName != "" && jobData.Title != "" && jobData.Salary != "NaN" && jobData.Type != 0 && jobData.Description != "" && jobData.Responsibilities != "" && jobData.Requirements != "") {

        SendJobDataToController(jobData);
    }
    else {
        $("#loader").fadeOut(3000);
        if (jobData.CompanyName == "") {
            document.querySelector("#companyNameVDT").style.display = "block";
        } else {
            document.querySelector("#companyNameVDT").style.display = "none";
        }
        if (jobData.Title == "") {
            document.querySelector("#titleVDT").style.display = "block";
        } else {
            document.querySelector("#titleVDT").style.display = "none";
        }
        if (jobData.Salary == "NaN") {
            document.querySelector("#salaryVDT").style.display = "block";
        } else {
            document.querySelector("#salaryVDT").style.display = "none";
        }
        if (jobData.Type == 0) {
            document.querySelector("#typeVDT").style.display = "block";
        } else {
            document.querySelector("#typeVDT").style.display = "none";
        }
        if (jobData.Description == "") {
            document.querySelector("#descriptionVDT").style.display = "block";
        } else {
            document.querySelector("#descriptionVDT").style.display = "none";
        }
        if (jobData.Responsibilities == "") {
            document.querySelector("#responsibilitiesVDT").style.display = "block";
        } else {
            document.querySelector("#responsibilitiesVDT").style.display = "none";
        }
        if (jobData.Requirements == "") {
            document.querySelector("#requirementsVDT").style.display = "block";
        } else {
            document.querySelector("#requirementsVDT").style.display = "none";
        }
    }
}

function JobEditPost(action) {
    
    $('#loader').show();
    $('#loader-wrapper').show();
    var salaryInt = $('#edit_salary').val();
    var jobData = {};
    jobData.ActionType = action;
    jobData.Id = $("#edit_Id").val();
    jobData.CompanyName = $("#edit_companyName").val();
    jobData.Title = $("#edit_title").val();
    jobData.Salary = parseFloat(salaryInt).toFixed(4);
    jobData.Type = $("#edit_type").val();
    jobData.Description = $("#edit_description").val();
    jobData.Responsibilities = $("#edit_responsibilities").val();
    jobData.Requirements = $("#edit_requirements").val();
    if (jobData.CompanyName != "" && jobData.Title != "" && jobData.Salary != "" &&
        jobData.Type != "" && jobData.Description != "" && jobData.Responsibilities != "" && jobData.Requirements != "") {

        SendJobDataToController(jobData);
    }
    else {
        $("#loader").fadeOut(3000);
        if (jobData.Id <= 0) {
            errorAlert("Error occured try again");
        } 
        if (jobData.CompanyName == "") {
            document.querySelector("#edit_companyNameVDT").style.display = "block";
        } else {
            document.querySelector("#edit_companyNameVDT").style.display = "none";
        }
        if (jobData.Title == "") {
            document.querySelector("#edit_titleVDT").style.display = "block";
        } else {
            document.querySelector("#edit_titleVDT").style.display = "none";
        }
        if (jobData.Salary == "") {
            document.querySelector("#edit_salaryVDT").style.display = "block";
        } else {
            document.querySelector("#edit_salaryVDT").style.display = "none";
        }
        if (jobData.Type == "") {
            document.querySelector("#edit_typeVDT").style.display = "block";
        } else {
            document.querySelector("#edit_typeVDT").style.display = "none";
        }
        if (jobData.Description == "") {
            document.querySelector("#edit_descriptionVDT").style.display = "block";
        } else {
            document.querySelector("#edit_descriptionVDT").style.display = "none";
        }
        if (jobData.Responsibilities == "") {
            document.querySelector("#edit_responsibilitiesVDT").style.display = "block";
        } else {
            document.querySelector("#edit_responsibilitiesVDT").style.display = "none";
        }
        if (jobData.Requirements == "") {
            document.querySelector("#edit_requirementsVDT").style.display = "block";
        } else {
            document.querySelector("#edit_requirementsVDT").style.display = "none";
        }
    }
}

function GetJobById(id) {
    
    $.ajax({
        type: 'GET',
        url: '/Admin/FindJob',
        data: { jobId: id },
        dataType: 'json',
        success: function (data) {
            
            if (!data.isError) {
                
                document.getElementById('jobDescriptionView').innerHTML = data.description;
                document.getElementById('jobResponsibilitiesView').innerHTML = data.responsibilities;
                document.getElementById('jobRequirementsView').innerHTML = data.requirements;
                $("#edit_Id").val(data.id);
                $("#edit_companyName").val(data.companyName);
                $("#edit_title").val(data.title);
                $("#edit_salary").val(data.salary);
                $("#edit_type").val(data.type);
                $('#edit_description').summernote('code', data.description);
                $('#edit_responsibilities').summernote('code', data.responsibilities);
                $('#edit_requirements').summernote('code', data.requirements);
            }
        }
    });
}

function ActivateAndDeactiveJob(action, id) {
    
    $('#loader').show();
    $('#loader-wrapper').show();
    var jobData = {};
    jobData.ActionType = action;
    jobData.Id = id;
    if (jobData.CompanyName != "") {

        SendJobDataToController(jobData);
    }
    else
    {
        $("#loader").fadeOut(3000);
        errorAlert("Error occured try again");
    }
}

function SendJobDataToController(jobData) {
    let collectedData = JSON.stringify(jobData);

    $.ajax({
        type: 'Post',
        dataType: 'json',
        url: '/Admin/JopMGTPostAction',
        data:
        {
            collectedJobData: collectedData,
        },
        success: function (result) {

            if (!result.isError) {
                $("#loader").fadeOut(3000);
                var url = '/Admin/Jobs';
                successAlertWithRedirect(result.msg, url)
            }
            else {
                $("#loader").fadeOut(3000);
                errorAlert(result.msg)
            }
        },
        error: function (ex) {
            $("#loader").fadeOut(3000);
            errorAlert("Error occured try again");
        }
    });
}

function CreateExamDuration() {
    var data = {};
    data.Type = $("#examType").val();
    data.Duration = $("#duration").val();
    if (data.Type == "" || data.Duration == "") {
        if (data.Type == "") {
            document.querySelector("#examTypeVDT").style.display = "block";
        } else {
            document.querySelector("#examTypeVDT").style.display = "none";
        }
        if (data.Duration == "") {
            document.querySelector("#durationVDT").style.display = "block";
        } else {
            document.querySelector("#durationVDT").style.display = "none";
        }
    }
    else {
        document.querySelector("#examTypeVDT").style.display = "none";
        document.querySelector("#durationVDT").style.display = "none";

        let durationData = JSON.stringify(data);
        $.ajax({
            type: 'POST',
            dataType: 'Json',
            url: '/Admin/CreateExamDuration',
            data:
            {
                dataCollected: durationData
            },
            success: function (result) {

                if (!result.isError) {
                    var url = '/Admin/ExamDuration'
                    successAlertWithRedirect(result.msg, url)
                }
                else {
                    errorAlert(result.msg)
                }
            },
            Error: function (ex) {
                errorAlert(ex);
            }
        });
    }
}

function EditExamDuration() {
    var data = {};
    data.Id = $("#edit_Id").val();
    data.Duration = $("#duration_Edit").val();
    if (data.Duration == "" || data.Id == "") {
        if (data.Duration == "") {
            document.querySelector("#duration_EditVTD").style.display = "block";
        } else {
            document.querySelector("#duration_EditVTD").style.display = "none";
        }
    }
    else {
        document.querySelector("#duration_EditVTD").style.display = "none";

        let durationData = JSON.stringify(data);
        $.ajax({
            type: 'POST',
            dataType: 'Json',
            url: '/Admin/EditExamDuration',
            data:
            {
                dataCollected: durationData
            },
            success: function (result) {

                if (!result.isError) {
                    var url = '/Admin/ExamDuration'
                    successAlertWithRedirect(result.msg, url)
                }
                else {
                    errorAlert(result.msg)
                }
            },
            Error: function (ex) {
                errorAlert(ex);
            }
        });
    }
}

function DeleteExamDuration() {
    
    var id = $("#delete_Id").val();
    if (id == "") {
        errorAlert("Error occured, please try again")
    }
    else {
        let durationId = id;
        $.ajax({
            type: 'POST',
            dataType: 'Json',
            url: '/Admin/DeleteExamDuration',
            data:
            {
                id: durationId
            },
            success: function (result) {

                if (!result.isError) {
                    var url = '/Admin/ExamDuration'
                    successAlertWithRedirect(result.msg, url)
                }
                else {
                    errorAlert(result.msg)
                }
            },
            Error: function (ex) {
                errorAlert(ex);
            }
        });
    }
}

function DeleteDocument(Id) {
    
    var id = Id;
    if (id == "") {
        errorAlert("Error occured, please try again")
    }
    else {
        let docId = id;
        $.ajax({
            type: 'POST',
            dataType: 'Json',
            url: '/Admin/DeleteDocuments',
            data:
            {
                docId : docId
            },
            success: function (result) {

                if (!result.isError) {
                    var url = '/Admin/StudentsDocumentations'
                    successAlertWithRedirect(result.msg, url)
                }
                else {
                    errorAlert(result.msg)
                }
            },
            Error: function (ex) {
                errorAlert(ex);
            }
        });
    }
}
function ApproveApplicantDocuments(Id) {
    
    if (Id == "") {
        errorAlert("Error occured, please try again")
    }
    else {
        let id = Id;
        $.ajax({
            type: 'POST',
            dataType: 'Json',
            url: '/Admin/ApproveApplicantDocuments',
            data:
            {
                docId: id
            },
            success: function (result) {

                if (!result.isError) {
                    var url = '/Admin/StudentsDocumentations'
                    successAlertWithRedirect(result.msg, url)
                }
                else {
                    errorAlert(result.msg)
                }
            },
            Error: function (ex) {
                errorAlert(ex);
            }
        });
    }
}
// Accept Graduation form submission POST ACTION
function AcceptGraduationPost() {
    
    var data = {};
    data.Id = $("#approveID").val();
    let graduationFormData = data;
    $.ajax({
        type: 'POST',
        dataType: 'Json',
        url: '/Admin/ManageGraduationForms',
        data:
        {
            employementDataViewModel: graduationFormData
        },
        success: function (result) {

            if (!result.isError) {
                var url = '/Admin/employementDataViewModel'
                successAlertWithRedirect(result.msg, url)
            }
            else {
                errorAlert(result.msg)
            }
        },
        Error: function (ex) {
            errorAlert(ex);
        }
    });
}

//SEND JobId to controller for applications 
function JobAplicationSubmittion(action,id) {
    
    $('#loader').show();
    $('#loader-wrapper').show();
    if (action == "APPLIED") {
        $("#loader").fadeOut(3000);
        errorAlert("Oops! you have already applied for this job");
    }
    else
    {
        let Id = id;
        $.ajax({
            type: 'Post',
            dataType: 'json',
            url: '/Student/JobApplicationPost',
            data:
            {
                Id: Id,
            },
            success: function (result) {
                
                if (!result.isError) {
                    $("#loader").fadeOut(3000);
                    var url = '/Student/Jobs';

                    successAlertWithRedirect(result.msg, url)
                }
                else {
                    $("#loader").fadeOut(3000);
                    errorAlert(result.msg)
                }
            },
            error: function (ex) {
                $("#loader").fadeOut(3000);
                errorAlert("Error occured try again");
            }
        });
    }
}
// <!......................... ADMIN SCRIPTS ............................>

// <!......................... SUPER ADMIN SCRIPTS ............................>
// APPLICATION REQUEST 
function ActivateAndDeactivateAdminPost(action, id) {
    
    $('#loader').show();
    $('#loader-wrapper').show();
    var data = {};
    data.Id = id;
    data.ActionType = action;
    let collectedData = JSON.stringify(data);
    $.ajax({
        type: 'Post',
        dataType: 'json',
        url: '/SuperAdmin/AdminTurnOnAndOff',
        data:
        {
            collectedAdminData: collectedData,
        },
        success: function (result)
        {
            
            if (!result.isError)
            {
                $("#loader").fadeOut(3000);
                var url = '/SuperAdmin/ManageAdmin';
                successAlertWithRedirect(result.msg, url)
            }
            else
            {
                $("#loader").fadeOut(3000);
                errorAlert(result.msg)
            }
        },
        error: function (ex) {
            $("#loader").fadeOut(3000);
            errorAlert("Error occured try again");
        }
    });
}

// <!......................... SUPER ADMIN SCRIPTS ............................>
// <!======EDIT APPLICANT DOCUMENTS==========>
function editApplicantDocumentation(Id) {
    
    var file = {};
    file.FirstGuarantor = document.getElementById("editFirstGuarantor").files;
    file.SecondGuarantor = document.getElementById("editSecondGuarantor").files;
    file.NepaBill = document.getElementById("editNepaBill").files;
    file.SignedContract = document.getElementById("editContractforms").files;
    var BVN = $('#editBVN').val();
    if (file.FirstGuarantor[0] != null && file.SecondGuarantor[0] != null && file.NepaBill[0] != null && file.SignedContract[0] != null && BVN != null) {
        $('#loader').show();
        $('#loader-wrapper').show();
        if (file.FirstGuarantor[0] != null) {
            const reader = new FileReader();
            reader.readAsDataURL(file.FirstGuarantor[0]);
            var base64FirstGuarantor;
            reader.onload = function () {
                base64FirstGuarantor = reader.result;

                if (file.SecondGuarantor[0] != null) {
                    const reader = new FileReader();
                    reader.readAsDataURL(file.SecondGuarantor[0]);
                    var base64SecondGuarantor;
                    reader.onload = function () {
                        base64SecondGuarantor = reader.result;

                        if (file.NepaBill[0] != null) {
                            const reader = new FileReader();
                            reader.readAsDataURL(file.NepaBill[0]);
                            var base64NepaBill;
                            reader.onload = function () {
                                base64NepaBill = reader.result;

                                if (file.SignedContract[0] != null) {
                                    const reader = new FileReader();
                                    reader.readAsDataURL(file.SignedContract[0]);
                                    var base64Contractforms;
                                    reader.onload = function () {
                                        base64Contractforms = reader.result;
                                        var allDocument = {};
                                        allDocument.Id = Id;
                                        allDocument.BVN = BVN;
                                        allDocument.FirstGuarantor = base64FirstGuarantor;
                                        allDocument.SecondGuarantor = base64SecondGuarantor;
                                        allDocument.NepaBill = base64NepaBill;
                                        allDocument.SignedContract = base64Contractforms;

                                        if (BVN != "" || BVN != 0) {
                                            let rawData = JSON.stringify(allDocument);
                                            $.ajax({
                                                type: 'Post',
                                                dataType: 'Json',
                                                url: '/Student/EditApplicantDocuments',
                                                data:
                                                {
                                                    applicantDocuments: rawData,
                                                },
                                                success: function (result) {

                                                    if (!result.isError) {
                                                        $("#loader").fadeOut(3000);
                                                        successAlert(result.msg)
                                                        window.location.reload;
                                                    }
                                                    else {
                                                        $("#loader").fadeOut(3000);
                                                        errorAlert(result.msg)
                                                    }
                                                },
                                                error: function (ex) {
                                                    $("#loader").fadeOut(3000);
                                                    errorAlert("Error occured try again");
                                                }
                                            })
                                        }
                                        else {
                                            $("#loader").fadeOut(3000);
                                            errorAlert("Incorrect Details");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }

    }
    else
    {
        
        if (BVN == "") {
            document.querySelector("#editBVNVDT").style.display = "block";
        } else {
            document.querySelector("#editBVNVDT").style.display = "none";
        }
        if (file.FirstGuarantor[0] == null) {
            document.querySelector("#editFirstGuarantorVDT").style.display = "block";
        } else {
            document.querySelector("#editFirstGuarantorVDT").style.display = "none";
        }
        if (file.SecondGuarantor[0] == null) {
            document.querySelector("#editSecondGuarantorVDT").style.display = "block";
        } else {
            document.querySelector("#editSecondGuarantorVDT").style.display = "none";
        }
        if (file.NepaBill[0] == null) {
            document.querySelector("#editNepaBillVDT").style.display = "block";
        } else {
            document.querySelector("#editNepaBillVDT").style.display = "none";
        }
        if (file.SignedContract[0] == null) {
            document.querySelector("#editContractformsVDT").style.display = "block";
        } else {
            document.querySelector("#editContractformsVDT").style.display = "none";
        }
    }
}
// <!======/EDIT APPLICANT DOCUMENTS==========>

