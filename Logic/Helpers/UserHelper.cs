﻿using Core.Db;
using Core.Enum;
using Core.Models;
using Core.ViewModels;
using Logic.IHelpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logic.Helpers.DropdownHelper;

namespace Logic.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AppDbContext _context;
        public UserHelper(UserManager<ApplicationUser> userManager, AppDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public string GetFullNameByUserNameAsync(string userName)
        {
            var user = _userManager.Users.Where(u => u.UserName == userName).FirstOrDefaultAsync().Result;
            var fullName = user.LastName + " " + user.FirstName;
            return fullName;
        }
        public async Task<ApplicationUser> FindByUserNameAsync(string userName)
        {
            return _userManager.Users.Where(u => u.UserName == userName).FirstOrDefaultAsync().Result;
        }
        public async Task<ApplicationUser> FindByPhoneNumberAsync(string phoneNumber)
        {
            return await _userManager.Users.Where(s => s.PhoneNumber == phoneNumber)?.FirstOrDefaultAsync();
        }
        public async Task<ApplicationUser> FindByEmailAsync(string email)
        {
            return await _userManager.Users.Where(s => s.Email == email)?.FirstOrDefaultAsync();
        }
        public async Task<ApplicationUser> FindByIdAsync(string Id)
        {
            return await _userManager.Users.Where(s => s.Id == Id)?.FirstOrDefaultAsync();
        }
        public List<ApplicationUserViewModel> GetAllOnboardApplicantsFromDB()
        {
            var applicantsList = new List<ApplicationUserViewModel>();
            var allApplicants = _context.ApplicationUser.Where(b => b.Deactivated == false && b.IsAdmin == false).OrderByDescending(d => d.DateRegistered).ToList();
            if (allApplicants.Any())
            {
                applicantsList = allApplicants.Select(s => new ApplicationUserViewModel()
                {
                    Id = s.Id,
                    UserName = s.UserName,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    FullName = s.FullName,
                    PhoneNumber = s.PhoneNumber,
                    Email = s.Email,
                    ApplicantResideInEnugu = s.ApplicantResideInEnugu,
                    HasLaptop = s.HasLaptop,
                    HasCompletedNysc = s.HasCompletedNysc,
                    HasAnyProgrammingExp = s.HasAnyProgrammingExp,
                    ProgrammingLanguagesExps = s.ProgrammingLanguagesExps,
                    CV = s.CV, 
                    ReasonForProgramming = s.ReasonForProgramming,
                    Status = s.Status,
                }).ToList();
                return applicantsList;
            }
            return applicantsList;
        }
        public async Task<UserVerification> CreateUserToken(string userEmail)
        {
            try
            {
                var user = await FindByEmailAsync(userEmail);
                if (user != null)
                {
                    UserVerification userVerification = new UserVerification()
                    {
                        UserId = user.Id,
                    };
                    await _context.AddAsync(userVerification);
                    await _context.SaveChangesAsync();
                    return userVerification;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public async Task<UserVerification> GetUserToken(Guid token)
        {
            return await _context.UserVerifications.Where(t => !t.Used && t.Token == token)?.Include(s => s.User).FirstOrDefaultAsync();

        }
        public async Task<bool> MarkTokenAsUsed(UserVerification userVerification)
        {
            try
            {
                var VerifiedUser = _context.UserVerifications.Where(s => s.UserId == userVerification.User.Id && s.Used != true).FirstOrDefault();
                if (VerifiedUser != null)
                {
                    userVerification.Used = true;
                    userVerification.DateUsed = DateTime.Now;
                    _context.Update(userVerification);
                    await _context.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<TrainingCourse> GetAllTrainingCourseFromDB()
        {
            var allTrainingCourse = _context.TrainingCourse.Where(t => !t.IsDeleted).ToList();
            if (allTrainingCourse.Any())
            {
                return allTrainingCourse;
            }
            return allTrainingCourse;
        }
        public TrainingCourse GetTrainingCourseById(int? Id)
        {
            var allTrainingCourse = _context.TrainingCourse.Where(t => t.Id == Id).FirstOrDefault();
            if (allTrainingCourse != null)
            {
                return allTrainingCourse;
            }
            return allTrainingCourse;
        }
        public Payments GetPaymentById(int? Id)
        {
            var payment = _context.Payments.Where(t => t.Id == Id).Include(c => c.Courses).Include(s => s.Student).FirstOrDefault();
            if (payment != null)
            {
                return payment;
            }
            return payment;
        }
        public List<Payments> GetPaymentList()
        {
            var allPayments = _context.Payments.Include(p => p.Student).Include(p => p.Courses).OrderByDescending(d => d.Date).ToList();
            if (allPayments.Any())
            {
                return allPayments;
            }
            return allPayments;
        }
        public List<TrainingVideos> GetTrainingVideos()
        {
            var allVideos = _context.TrainingVideos.Where(v => v.IsActive).Include(c => c.Name).ToList();
            if (allVideos.Any())
            {
                return allVideos;
            }
            return allVideos;
        }
        public List<TrainingVideos> GetStudentPaidTrainingVideos(string userID)
        {

            var getListOfCourseStudentPaidFor = _context.Payments.Where(t => t.UserId == userID && t.Status == PaymentStatus.Approved).ToList();
            var paidCourseIDs = getListOfCourseStudentPaidFor.Select(x => x.CourseId).ToList();

            var paidCourseVideos = _context.TrainingVideos.Where(x => x.CourseId != 0 && x.IsActive && paidCourseIDs.Contains(x.CourseId)).Include(c => c.Name).ToList();
            if (paidCourseVideos.Any())
            {
                return paidCourseVideos;
            }
            return null;
        }
        public List<int> GetListOfCourseIdStudentPaid4(string userID)
        {
            var list = new List<int>();
            var getListOfCourseStudentPaidFor = _context.Payments.Where(t => t.UserId == userID && t.Status == PaymentStatus.Approved).ToList();
            var paidCourseIDs = getListOfCourseStudentPaidFor.Select(x => x.CourseId).ToList();
            if (paidCourseIDs.Any())
            {
                list = paidCourseIDs;
                return list;
            }
            return list;
        }
        public TrainingVideos GetVideosById(Guid Id)
        {
            var videos = _context.TrainingVideos.Where(t => t.Id == Id && t.IsActive).FirstOrDefault();
            if (videos != null)
            {
                return videos;
            }
            return videos;
        }
        public TestQuestions GetQuestionsById(int? Id)
        {
            var question = _context.TestQuestions.Where(t => t.Id == Id && !t.IsDeleted).FirstOrDefault();
            if (question != null)
            {
                return question;
            }
            return question;
        }
        public List<TestQuestions> GetTestQuestions()
        {
            var allQuestions = _context.TestQuestions.Where(q => !q.IsDeleted).OrderByDescending(a => a.Id).Include(c => c.Course).ToList();
            if (allQuestions.Any())
            {
                return allQuestions;
            }
            return allQuestions;
        }
        public List<TestQuestionsViewModel> GetTestQuestionsForPage1(int? Id)
        {
            var result = new List<TestQuestionsViewModel>();
            var testQuestion4Page1 = _context.TestQuestions.Where(q => q.CourseId == Id && q.IsActive && !q.IsDeleted).Include(c => c.Course).OrderBy(q => q.Id).Take(10).ToList();
            if (testQuestion4Page1.Any())
            {
                result = testQuestion4Page1.Select(x => new TestQuestionsViewModel()
                {
                    OptionList = GetOptListByQuestionIds(x.Id),
                    Question = x.Question,
                    Answer = x.Answer,
                    CourseId = (int)x.CourseId,
                    Id = x.Id,
                    IsActive = x.IsActive,
                    IsDeleted = x.IsDeleted,
                    DateCreated = x.DateCreated

                }).ToList();
                return result;
            }
            return result;
        }
        public List<TestQuestionsViewModel> GetTestQuestionsForPage2(int? Id)
        {
            var result = new List<TestQuestionsViewModel>();
            var testQuestion4Page2 = _context.TestQuestions.Where(q => q.CourseId == Id && q.IsActive && !q.IsDeleted).Include(c => c.Course).OrderByDescending(q => q.Id).Take(10).ToList();
            if (testQuestion4Page2.Any())
            {
                result = testQuestion4Page2.Select(x => new TestQuestionsViewModel()
                {
                    OptionList = GetOptListByQuestionIds(x.Id),
                    Question = x.Question,
                    Answer = x.Answer,
                    CourseId = (int)x.CourseId,
                    Id = x.Id,
                    IsActive = x.IsActive,
                    IsDeleted = x.IsDeleted,
                    DateCreated = x.DateCreated
                }).ToList();
                return result;
            }
            return result;
        }
        public List<string> SplitStringToList(string dataString)
        {
            if (dataString != null)
            {
                return dataString.Split("\n").Take(3).ToList();
            }
            return new List<string>();
        }
        public List<ProjectTopic> AllSubmenttedProjectTopic()
        {
            var topics = _context.ProjectTopics.OrderBy(t => t.UserId).Include(s => s.Student).Include(c => c.Course).ToList();
            return topics;
        }
        public ProjectTopic GetProjectTopicById(int? id)
        {
            var topic = _context.ProjectTopics.Where(p => p.Id == id).Include(s => s.Student).Include(c => c.Course).FirstOrDefault();
            return topic;
        }
        public ProjectTopic CheckIfATopicHasBeenApprovedForTheSelectedCourse(ProjectTopic proj2Approve)
        {
            var topicCheck = _context.ProjectTopics.Where(p => p.UserId == proj2Approve.UserId && p.CourseId == proj2Approve.CourseId && p.IsApproved).FirstOrDefault();
            return topicCheck;
        }
        public ApplicantDocumment GetApplicationDocummentByUserId(string userID)
        {
            var myDoc = _context.ApplicantDocumments.Where(s => s.StudentId == userID).FirstOrDefault();
            return myDoc;
        }
        public List<string> GetOptListByQuestionIds(int id)
        {
            var optList = new List<string>();
            var optListDetails = _context.AnswerOptions.Where(a => a.QuestionId == id).ToList();
            if (optListDetails.Any())
            {
                optList = optListDetails.Select(a => a.Option).ToList();
                return optList;
            }
            return null;
        }
        public Job GetJobById(int? Id)
        {
            var job = new Job();
            var selectedJob = _context.Jobs.Where(t => t.Id == Id).FirstOrDefault();
            if (selectedJob != null)
            {
                job = selectedJob;
                return job;
            }
            return job;
        }
        public List<InterviewQuestions> GetInterviewTestQuestions()
        {
            var allQuestions = _context.InterviewQuestions.OrderByDescending(a => a.Id).ToList();
            return allQuestions;
        }
        public InterviewQuestions GetInterviewQuestionsById(int Id)
        {
            var selectedQuestion = new InterviewQuestions();
            if (Id > 0)
            {
                selectedQuestion = _context.InterviewQuestions.Where(t => t.Id == Id ).FirstOrDefault();
                if (selectedQuestion != null)
                {
                    return selectedQuestion;
                }
            }
            return selectedQuestion;
        }
        public InterviewViewModel GetInterviewQuestions()
        {

            Random rand = new Random();
            var model = new InterviewViewModel();
            var userId = Session.GetCurrentUser().Id;
            if(userId != null)
            {
                model.Duration = GetInterviewTestDuration();
                model.IsWritten = CheckIfUserHaveTakenThisInterview(userId);

                var interviewQuestion = _context.InterviewQuestions.Where(q => q.IsActive).OrderBy(q => q.Id).ToList();

                if (interviewQuestion.Any())
                {
                    var result = interviewQuestion.Select(x => new InterviewQuestionsViewModel()
                    {
                        Id = x.Id,
                        Question = x.Question,
                        OptionList = GetInterviewOptListByQuestionIds(x.Id),
                    }).ToList();

                    var questionsList = result.OrderBy(c => rand.Next()).Take(20).ToList();

                    model.Questions = questionsList;

                    return model;
                }
            }
            return model;
        }
        public List<string> GetInterviewOptListByQuestionIds(int id)
        {
            var optList = new List<string>();
            var optListDetails = _context.InterviewAnswerOptions.Where(a => a.QuestionId == id).ToList();
            if (optListDetails.Any())
            {
                optList = optListDetails.Select(a => a.Option).ToList();
                return optList;
            }
            return null;
        }
        public int GetInterviewTestDuration()
        {
            var result =  _context.ExamDuration.Where(i => i.Type == ExamType.INTERVIEW).FirstOrDefault();
            if(result != null)
            {
                var duration = result.Duration;
                return duration;
            }
            return 3;
        }
        public bool CheckIfUserHaveTakenThisInterview(string userID)
        {
            var result = _context.InterviewTestResults.Where(i => i.UserId == userID).FirstOrDefault();
            if (result != null)
            {
                return true;
            }
            return false;
        }
    }
}
