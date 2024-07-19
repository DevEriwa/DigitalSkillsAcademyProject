using Core.Db;
using Core.Enum;
using Core.Models;
using Core.ViewModels;
using Logic.Helpers;
using Logic.IHelpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Logic.AppHttpContext;

namespace Academy_App.Controllers
{
    [SessionTimeout]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class AdminController : Controller
    {
        private readonly IUserHelper _userHelper;
        private readonly IStudentHelper _studentHelper;
        private readonly IAdminHelper _adminHelper;
        private readonly IApplicationHelper _applicationHelper;
        private readonly IDropdownHelper _dropdownHelper;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AppDbContext _context;
        private readonly IEmailHelper _emailHelper;
        private const string Create_Training_Cost_ActionType = "CreateTrainingCourse";
        private const string Edit_Training_Cost_ActionType = "EditTrainingCourse";
        private const string Activate_Training_Cost_ActionType = "ActivateTrainingCourse";
        private const string Deactivate_Training_Cost_ActionType = "DeactivateTrainingCourse";
        private const string Delete_Training_Cost_ActionType = "DeleteTrainingCourse";

        public AdminController(IUserHelper userHelper, IApplicationHelper applicationHelper, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, IAdminHelper adminHelper, IDropdownHelper dropdownHelper, AppDbContext context, IEmailHelper emailHelper)
        {
            _userHelper = userHelper;
            _applicationHelper = applicationHelper;
            _signInManager = signInManager;
            _userManager = userManager;
            _adminHelper = adminHelper;
            _dropdownHelper = dropdownHelper;
            _context = context;
            _emailHelper = emailHelper;
        }
        public IActionResult Index()
        {
            var dashBoardData = _adminHelper.DashboardBuildingServices();
            return View(dashBoardData);
        }
        [HttpGet]
        public IActionResult OnboardingStudent()
        {
            var onboardingStudentList = _userHelper.GetAllOnboardApplicantsFromDB();
            return View(onboardingStudentList);
        }

        // POST ACTION FOR ACCEPT & REJECT APPLICATION
        [HttpPost]
        public JsonResult ApplicationStatusPost(string applicantDetails)
        {
            try
            {
                if (applicantDetails == null)
                {
                    return Json(new { isError = true, msg = "Aborted" });
                }
                var applicantData = JsonConvert.DeserializeObject<ApplicationUser>(applicantDetails);
                if (applicantData != null && applicantData.Status == ApplicationStatus.Accepted)
                {
                    var applicant = _applicationHelper.AcceptSelectedApplication(applicantData);
                    if (applicant != null)
                    {
                        var removeUserFromRole = _userManager.RemoveFromRoleAsync(applicant, "Applicant").Result;
                        if (removeUserFromRole.Succeeded)
                        {
                            var addToRole = _userManager.AddToRoleAsync(applicant, "Student").Result;
                            if (addToRole.Succeeded)
                            {
                                return Json(new { isError = false, msg = "Application accepted successfully" });
                            }
                        }
                    }
                }
                else if (applicantData != null &&  applicantData.Status == ApplicationStatus.Rejected)
                {
                    var applicant = _applicationHelper.RejectSelectedApplication(applicantData);
                    if (applicant != null)
                    {
                        return Json(new { isError = false, msg = "Application rejected successfully" });
                    }
                }
                return Json(new { isError = true, msg = "Failed" });
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public JsonResult GetApplicationProfileById(string Id)
        {
            try
            {
                if (Id != null)
                {
                    var application = _userManager.FindByIdAsync(Id).Result;
                    return Json(application);
                }
                else
                {
                    return Json(new { isError = true, msg = "Not Found" });
                }
            }
            catch (Exception ex)
            {
                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }
        // TRAINING COST SETUP
        public async Task<IActionResult> TrainingCourse()
        {
            var username = User.Identity.Name;
            ViewBag.Layout = _applicationHelper.GetUserLayout(username).FirstOrDefault();
            var allTrainingCourse = _userHelper.GetAllTrainingCourseFromDB();
            return View(allTrainingCourse);
        }

        // POST ACTION FOR ALL TRAINING COST SETUP
        [HttpPost]
        public JsonResult TrainingCoursePost(string collectedTrainingData)
        {
            try
            {
                if (collectedTrainingData != null)
                {
                    var rawTrainingData = JsonConvert.DeserializeObject<TrainingCourseViewModel>(collectedTrainingData);

                    if(rawTrainingData.ActionType == Create_Training_Cost_ActionType)
                    {
                        var newTrainingCourse = _adminHelper.AddTrainignCostServices(rawTrainingData);
                        if (newTrainingCourse != null)
                        {
                            return Json(new { isError = false, msg = "Added Successfully" });
                        }

                    }
                    else if (rawTrainingData.ActionType == Edit_Training_Cost_ActionType)
                    {
                        var costToEdit = _adminHelper.EditTrainignCostServices(rawTrainingData);
                        if (costToEdit != null)
                        {
                            return Json(new { isError = false, msg = "Update Successfully" });
                        }
                    }
                    else if (rawTrainingData.ActionType == Activate_Training_Cost_ActionType)
                    {

                        if (rawTrainingData.Id != null)
                        {
                            var costToActivate = _adminHelper.ActivateTrainignCostServices(rawTrainingData);
                            if (costToActivate != null)
                            {
                                return Json(new { isError = false, msg = "Activated Successfully" });
                            }
                        }
                        
                    }
                    else if (rawTrainingData.ActionType == Deactivate_Training_Cost_ActionType)
                    {
                        if (rawTrainingData.Id != null)
                        {
                            var costToDisable = _adminHelper.DisableTrainignCostServices(rawTrainingData);
                            if (costToDisable != null)
                            {
                                return Json(new { isError = false, msg = "Deactivated Successfully" });
                            }
                        }
                    }
                    else if (rawTrainingData.ActionType == Delete_Training_Cost_ActionType)
                    {
                        if (rawTrainingData.Id != null)
                        {
                            var costToDelete = _adminHelper.DeleteTrainignCostServices(rawTrainingData);
                            if (costToDelete != null)
                            {
                                return Json(new { isError = false, msg = "Deleted Successfully" });
                            }
                        }
                    }
                }
                return Json(new { isError = true, msg = "Failed" });
            }
            catch (Exception)
            {
                throw;
            }
        }

        // TRAINING COST SETUP  GET ACTION
        [HttpGet]
        public JsonResult GetTrainingCourseById(int? Id)
        {
            try
            {
                if (Id != null)
                {
                    var editedTrainingCourse = _userHelper.GetTrainingCourseById(Id);
                    return Json(editedTrainingCourse);
                }
                return Json(new { isError = true, msg = "Failed" });

            }
            catch (Exception ex)
            {

                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }

        [HttpGet]
        public IActionResult Payments()
        {
            var username = User.Identity.Name;
            ViewBag.Layout = _applicationHelper.GetUserLayout(username).FirstOrDefault();
            var payment = _userHelper.GetPaymentList();
            return View(payment);
        }
        [HttpGet]
        public JsonResult GetCourseDescriptionById(int? id)
        {
            try
            {
                if (id != null)
                {
                    var courseDescription = _userHelper.GetTrainingCourseById(id).Description;
                    return Json(courseDescription);
                }
                return Json(new { isError = true, msg = "Failed" });

            }
            catch (Exception ex)
            {
                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }

        // PAYMENT  GET ACTION
        [HttpGet]
        public JsonResult GetPaymentById(int? Id)
        {
            try
            {
                if (Id != null)
                {
                    var payment4Action = _userHelper.GetPaymentById(Id);
                    return Json(payment4Action);
                }
                return Json(new { isError = true, msg = "Failed" });

            }
            catch (Exception ex)
            {

                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }

        // POST ACTION FOR ALL TRAINING COST SETUP
        [HttpPost]
        public JsonResult PaymentPostAction(string collectedPaymentID)
        {
            try
            {
                if (collectedPaymentID != null)
                {
                    var payment = JsonConvert.DeserializeObject<Payments>(collectedPaymentID);

                   if (payment.Status == PaymentStatus.Approved)
                    {

                        if (payment.Id > 0)
                        {
                            var paymentActivate = _adminHelper.ApproveSelectedPayment(payment);
                            if (paymentActivate != null)
                            {
                                return Json(new { isError = false, msg = "Approved Successfully" });
                            }
                        }

                    }
                    else if(payment.Status == PaymentStatus.Declined)
                    {
                        if (payment.Id != null)
                        {
                            var paymentToDecline = _adminHelper.DeclineSelectedPaymment(payment);
                            if (paymentToDecline != null)
                            {
                                return Json(new { isError = false, msg = "Declined Successfully" });
                            }
                        }
                    }
                }
                return Json(new { isError = true, msg = "Failed" });
            }
            catch (Exception ex)
            {
                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> TrainingVideos()
        {
            var username = User.Identity.Name;
            ViewBag.Layout = _applicationHelper.GetUserLayout(username).FirstOrDefault();
            var model = new TrainingVideosViewModel();
            ViewBag.AllCourses = _dropdownHelper.DropdownOfCourses();
            model.Videos = _userHelper.GetTrainingVideos();
            return View(model);
        }

        [HttpPost]
        public JsonResult TrainingVideoUpload(string collectedVideoData)
        {
            try
            {
                ViewBag.AllCourses = _dropdownHelper.DropdownOfCourses();
                if (collectedVideoData != null)
                {
                    var videoDetails = JsonConvert.DeserializeObject<TrainingVideosViewModel>(collectedVideoData);

                    if (videoDetails != null)
                    {
                        var newVideoAdded =  _adminHelper.TrainignVideoServices(videoDetails);
                        if (newVideoAdded != null){
                            if(videoDetails.ActionType == GeneralAction.CREATE)
                            {
                                return Json(new { isError = false, msg = "Created Successfully" });
                            }
                            if (videoDetails.ActionType == GeneralAction.EDIT)
                            {
                                return Json(new { isError = false, msg = "Updated Successfully" });
                            }
                            if (videoDetails.ActionType == GeneralAction.DELETE)
                            {
                                return Json(new { isError = false, msg = "Deleted Successfully" });
                            }
                        }
                        else{
                            return Json(new { isError = true, msg = "Failed" });
                        }
                    }
                }
                return Json(new { isError = true, msg = "Failed" });
            }
            catch (Exception ex)
            {

                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }

        // VIDEO  GET ACTIONAdminPostActionsForTestQuestions
        [HttpGet]
        public JsonResult GetVideoById(string videoId)
        {
            try
            {
                if (videoId != null)
                {
                    var videoDetails = JsonConvert.DeserializeObject<Guid>(videoId);
                    if (videoDetails != Guid.Empty)
                    {
                        var video4Action = _userHelper.GetVideosById(videoDetails);
                        return Json(video4Action);
                    }
                }
                return Json(new { isError = true, msg = "Failed" });
            }
            catch (Exception ex)
            {

                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }

        [HttpGet]
        public IActionResult TestQuestions()
        {
            var username = User.Identity.Name;
            ViewBag.Layout = _applicationHelper.GetUserLayout(username).FirstOrDefault();
            var model = new GeneralViewModel();
            ViewBag.AllCourses = _dropdownHelper.DropdownOfCourses();
            model.Questions = _userHelper.GetTestQuestions();
            return View(model);
        }

        [HttpPost]
        public JsonResult AdminPostActionsForTestQuestions(string collectedTestQuestionsData)
        {
            try
            {
                if (collectedTestQuestionsData != null)
                {
                    var questionDetails = JsonConvert.DeserializeObject<TestQuestionsViewModel>(collectedTestQuestionsData);

                    if (questionDetails != null)
                    {
                        var newVideoAdded = _adminHelper.TestQuestionsServices(questionDetails);
                        if (newVideoAdded != null)
                        {
                            if (questionDetails.ActionType == GeneralAction.CREATE)
                            {
                                return Json(new { isError = false, msg = "Created Successfully" });
                            }
                            if (questionDetails.ActionType == GeneralAction.EDIT)
                            {
                                return Json(new { isError = false, msg = "Updated Successfully" });
                            }
                            if (questionDetails.ActionType == GeneralAction.ACTIVATE)
                            {
                                return Json(new { isError = false, msg = "Activated Successfully" });
                            }
                            if (questionDetails.ActionType == GeneralAction.DEACTIVATE)
                            {
                                return Json(new { isError = false, msg = "Deactivated Successfully" });
                            }
                            if (questionDetails.ActionType == GeneralAction.DELETE)
                            {
                                return Json(new { isError = false, msg = "Deleted Successfully" });
                            }
                        }
                        else
                        {
                            return Json(new { isError = true, msg = "Failed" });
                        }
                    }
                }
                return Json(new { isError = true, msg = "Failed" });
            }
            catch (Exception ex)
            {

                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }

        // QUESTION  GET ACTION
        [HttpGet]
        public JsonResult GetQuestionById(int? Id)
        {
            try
            {
                if (Id != null)
                {
                    var question4Action = _userHelper.GetQuestionsById(Id);
                    return Json(question4Action);
                }
                return Json(new { isError = true, msg = "Failed" });
            }
            catch (Exception ex)
            {

                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }

        public JsonResult GetOptionsByQuestionId(int id)
        {
            try
            {
                if (id != 0)
                {
                    var listOfOpt = _adminHelper.GetOptListByQuestionIds(id);
                    var nullResult = "No Record Found";
                    if (listOfOpt != null)
                    {
                        return Json(listOfOpt);
                    }
                    return Json(new { isNull = true, val = nullResult });
                }
                return Json(new { isError = true, msg = "Failed" });

            }
            catch (Exception ex)
            {
                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }

        [HttpPost]
        public JsonResult AddAnwserOptions(string dataCollected)
        {
            try
            {
                if (dataCollected != null)
                {
                    var optDetails = JsonConvert.DeserializeObject<AnswerOptionViewModel>(dataCollected);

                    if (optDetails != null)
                    {
                        var newOpt = _adminHelper.PostServices4Options(optDetails);
                        if (newOpt)
                        {
                            return Json(new { isError = false, msg = "Created Successfully" });
                        }
                    }
                }
                return Json(new { isError = true, msg = "Failed" });
            }
            catch (Exception ex)
            {

                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }

        public IActionResult ViewProjectTopics() 
        {
            var projectTopicList = _userHelper.AllSubmenttedProjectTopic();
            return View(projectTopicList);
        }

        public JsonResult AppoveProjectTopic(int? id)
        {
            if(id != null)
            {
                var proj2Approve = _userHelper.GetProjectTopicById(id);
                var alreadyApprovedChk = _userHelper.CheckIfATopicHasBeenApprovedForTheSelectedCourse(proj2Approve);
                if(alreadyApprovedChk != null)
                {
                    return Json(new { isError = true, msg = "You have already approve " + alreadyApprovedChk.Title + "Topic for this student"});
                }
                else
                {
                    proj2Approve.IsApproved = true;

                    var approved = _context.ProjectTopics.Update(proj2Approve);
                    _context.SaveChanges();
                    if(approved != null)
                    {
                        var user = _userHelper.FindByIdAsync(proj2Approve.UserId).Result;
                        _emailHelper.ApprovedProjectTopicMailTemlate(user, proj2Approve);
                        return Json(new { isError = false, msg = "Approved Successfully" });
                    }
                }
            }
            return Json(new { isError = true, msg = "Failed" });
        }
        [HttpGet]
        public IActionResult AprovedTopics()
        {
            var myTopics = _adminHelper.GetListOfAllApprovedProjectTopic();
            if (myTopics != null)
            {
                return View(myTopics);
            }
            return View();
        }
        [HttpGet]
        public JsonResult GetProjectLinksById(int id)
        {
            try
            {
                if (id != 0)
                {
                    var links = _studentHelper.GetProjectLinksServices(id);
                    return Json(links);
                }
                return Json(new { isError = true, msg = "Failed" });

            }
            catch (Exception ex)
            {
                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }
        [HttpPost]
        public JsonResult MarkProjectAsCompleted(int projectId)
        {
            if (projectId > 0)
            {
                var newTopic = _adminHelper.ProjectCompletionServices(projectId);
                if (newTopic != null)
                {
                    return Json(new { isError = false, msg = "Marked Successfully." });
                }
            }
            return Json(new { isError = true, msg = "Failed" });
        }
        [HttpGet]
        public IActionResult Jobs()
        {
            ViewBag.JobTypes = _dropdownHelper.JobTypes();
            var allJobs = _adminHelper.GetListOfAllJobs();
            if (allJobs != null && allJobs.Count > 0)
            {
                return View(allJobs);
            }
            return View();
        }
        [HttpPost]
        public JsonResult JopMGTPostAction(string collectedJobData)
        {
            try
            {
                if (collectedJobData != null)
                {
                    var collectedJobDetails = JsonConvert.DeserializeObject<JobViewModels>(collectedJobData);

                    if (collectedJobDetails != null)
                    {
                        var newJobData = _adminHelper.JobManagementServices(collectedJobDetails);
                        if (newJobData != null)
                        {
                            if (collectedJobDetails.ActionType == GeneralAction.CREATE)
                            {
                                return Json(new { isError = false, msg = "Created Successfully" });
                            }
                            if (collectedJobDetails.ActionType == GeneralAction.EDIT)
                            {
                                return Json(new { isError = false, msg = "Updated Successfully" });
                            }
                            if (collectedJobDetails.ActionType == GeneralAction.DEACTIVATE)
                            {
                                return Json(new { isError = false, msg = "Deactivated Successfully" });
                            }
                            if (collectedJobDetails.ActionType == GeneralAction.ACTIVATE)
                            {
                                return Json(new { isError = false, msg = "Activated Successfully" });
                            }
                        }
                        else
                        {
                            return Json(new { isError = true, msg = "Failed" });
                        }
                    }
                }
                return Json(new { isError = true, msg = "Failed" });
            }
            catch (Exception ex)
            {

                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }
        [HttpGet]
        public JsonResult FindJob(int? jobId)
        {
            try
            {
                if (jobId != null)
                {
                    var job4Action = _userHelper.GetJobById(jobId);
                    return Json(job4Action);
                }
                return Json(new { isError = true, msg = "Failed" });
            }
            catch (Exception ex)
            {

                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }
        [HttpGet]
        public IActionResult Employment()
        {
            var employmentList = _adminHelper.GetListOfEmploymentData();
            return View(employmentList);
        }

        // POST ACTION FOR ACCEPT & DECLINE GRADUATION FORM
        [HttpPost]
        public JsonResult ManageGraduationForms(EmployementDataViewModel employementDataViewModel)
        
        {
            try
            {
                if (employementDataViewModel != null)
                {
                    var employementData = _adminHelper.ManageGraduationFormServices(employementDataViewModel);
                    if (employementData)
                    {
                        return Json(new { isError = false, msg = "Approved uccessfully" });
                    }
                }
                
                return Json(new { isError = true, msg = "Failed" });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult SalaryPaymentsHistory()
        {
            var histories = _adminHelper.GetListOfSalaryPaymentsHistory();
            return View(histories);
        }

        [HttpGet]
        public IActionResult InterviewQuestions()
        {
            var Questions = _userHelper.GetInterviewTestQuestions();
            return View(Questions);
        }

        [HttpPost]
        public JsonResult PostActionsForInterveiwQuestions(string collectedTestQuestionsData)
        {
            try
            {
                if (collectedTestQuestionsData != null)
                {
                    var questionDetails = JsonConvert.DeserializeObject<InterviewQuestionsViewModel>(collectedTestQuestionsData);

                    if (questionDetails != null)
                    {
                        var newVideoAdded = _adminHelper.InterviewQuestionsServices(questionDetails);
                        if (newVideoAdded != null)
                        {
                            if (questionDetails.ActionType == GeneralAction.CREATE)
                            {
                                return Json(new { isError = false, msg = "Created Successfully" });
                            }
                            if (questionDetails.ActionType == GeneralAction.EDIT)
                            {
                                return Json(new { isError = false, msg = "Updated Successfully" });
                            }
                            if (questionDetails.ActionType == GeneralAction.ACTIVATE)
                            {
                                return Json(new { isError = false, msg = "Activated Successfully" });
                            }
                            if (questionDetails.ActionType == GeneralAction.DEACTIVATE)
                            {
                                return Json(new { isError = false, msg = "Deactivated Successfully" });
                            }
                            if (questionDetails.ActionType == GeneralAction.DELETE)
                            {
                                return Json(new { isError = false, msg = "Deleted Successfully" });
                            }
                        }
                        else
                        {
                            return Json(new { isError = true, msg = "Failed" });
                        }
                    }
                }
                return Json(new { isError = true, msg = "Failed" });
            }
            catch (Exception ex)
            {

                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }

        public JsonResult GetInterviewOptionsByQuestionId(int id)
        {
            try
            {
                if (id != 0)
                {
                    var listOfOpt = _adminHelper.GetInterviewOptListByQuestionIds(id);
                    var nullResult = "No Record Found";
                    if (listOfOpt != null)
                    {
                        return Json(listOfOpt);
                    }
                    return Json(new { isNull = true, val = nullResult });
                }
                return Json(new { isError = true, msg = "Failed" });

            }
            catch (Exception ex)
            {
                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }

        [HttpPost]
        public JsonResult AddInterViewAnwserOptions(string dataCollected)
        {
            try
            {
                if (dataCollected != null)
                {
                    var optDetails = JsonConvert.DeserializeObject<AnswerOptionViewModel>(dataCollected);

                    if (optDetails != null)
                    {
                        var newOpt = _adminHelper.PostServicesInterviewAnsOptions(optDetails);
                        if (newOpt)
                        {
                            return Json(new { isError = false, msg = "Created Successfully" });
                        }
                    }
                }
                return Json(new { isError = true, msg = "Failed" });
            }
            catch (Exception ex)
            {

                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }
        [HttpGet]
        public IActionResult TestResult()
        {
            var testResult = _adminHelper.GetListOfTestResults();
            return View(testResult);
        }
        [HttpGet]
        public IActionResult InterviewResult()
        {
            var interviewResult = _adminHelper.GetListOfInterviewResults(); 
            return View(interviewResult);
        }
        [HttpGet]
        public IActionResult ExamDuration()
        {
            ViewBag.ExamType = _dropdownHelper.GetExamTypeList();
            var duration = _context.ExamDuration.ToList();
            return View(duration);
        }
        [HttpPost]
        public JsonResult CreateExamDuration(string dataCollected)
        {
            try
            {
                if (dataCollected != null)
                {
                    var durationCreate = JsonConvert.DeserializeObject<ExamDuration>(dataCollected);

                    if (durationCreate != null)
                    {
                        var duration = _adminHelper.CreateExamDurationServices(durationCreate);
                        if (duration != null)
                        {
                            return Json(new { isError = false, msg = "Created Successfully" });
                        }
                    }
                }
                return Json(new { isError = true, msg = "Failed" });
            }
            catch (Exception ex)
            {

                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }
        [HttpPost]
        public JsonResult EditExamDuration(string dataCollected)
        {
            try
            {
                if (dataCollected != null)
                {
                    var durationEdit = JsonConvert.DeserializeObject<ExamDuration>(dataCollected);

                    if (durationEdit != null)
                    {
                        var duration = _adminHelper.EditExamDurationServices(durationEdit);
                        if (duration != null)
                        {
                            return Json(new { isError = false, msg = "Updated Successfully" });
                        }
                    }
                }
                return Json(new { isError = true, msg = "Failed" });
            }
            catch (Exception ex)
            {

                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }
        [HttpPost]
        public JsonResult DeleteExamDuration(int id)
        {
            try
            {
                if (id > 0)
                {
                    var duration = _adminHelper.DeleteExamDurationServices(id);
                    if (duration != null)
                    {
                        return Json(new { isError = false, msg = "Deleted Successfully" });
                    }
                }
                return Json(new { isError = true, msg = "Failed" });
            }
            catch (Exception ex)
            {

                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }

        // POST ACTION FOR ACCEPT & REJECT APPLICATION
        [HttpPost]
        public JsonResult QualifyApllicantFoeWrittenInterview(string userId)
        {
            try
            {
                
                if (userId != null)
                {

                    var applicantsDetails = _userManager.FindByIdAsync(userId).Result;
                    if (applicantsDetails != null)
                    {
                        var applicant = _applicationHelper.QualifiedToTakeWrritingInterview(applicantsDetails);
                        if (applicant != null)
                        {
                            return Json(new { isError = false, msg = "Ssuccessfully" });
                        }
                    }
                   
                }
               
                return Json(new { isError = true, msg = "Failed" });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public IActionResult StudentsDocumentations()
        {
            var testResult = _adminHelper.GetListOfApplicantDocumment();
            return View(testResult);
        }

        [HttpPost]
        public JsonResult DeleteDocuments(Guid docId)
        {
            try
            {
                if (docId != Guid.Empty)
                {
                    var document = _adminHelper.DeleteDocumentServices(docId);
                    if (document)
                    {
                        return Json(new { isError = false, msg = "Deleted Successfully" });
                    }
                }
                return Json(new { isError = true, msg = "Failed" });
            }
            catch (Exception ex)
            {

                return Json(new { isError = true, msg = "An unexpected error occured " + ex.Message });
            }
        }

        // POST ACTION FOR ACCEPT & REJECT APPLICATION
        [HttpPost]
        public JsonResult ApproveApplicantDocuments(Guid docId)
        {
            try
            {
                if (docId != Guid.Empty)
                {
                    var document = _adminHelper.QualifiedToTakeWrritingInterview(docId);
                    if (document)
                    {
                        return Json(new { isError = false, msg = "Ssuccessfully" });
                    }
                }

                return Json(new { isError = true, msg = "Failed" });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}