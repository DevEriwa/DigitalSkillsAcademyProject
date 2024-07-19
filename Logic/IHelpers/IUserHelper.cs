using Core.Models;
using Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logic.IHelpers
{
    public interface IUserHelper
    {
        string GetFullNameByUserNameAsync(string userName);
        Task<ApplicationUser> FindByUserNameAsync(string userName);
        Task<ApplicationUser> FindByPhoneNumberAsync(string phoneNumber);
        Task<ApplicationUser> FindByEmailAsync(string email);
        Task<ApplicationUser> FindByIdAsync(string Id);
        List<ApplicationUserViewModel> GetAllOnboardApplicantsFromDB();
        Task<UserVerification> CreateUserToken(string userEmail);
        Task<UserVerification> GetUserToken(Guid token);
        Task<bool> MarkTokenAsUsed(UserVerification userVerification);
        List<TrainingCourse> GetAllTrainingCourseFromDB();
        TrainingCourse GetTrainingCourseById(int? Id);
        Payments GetPaymentById(int? Id);
        List<Payments> GetPaymentList();
        List<TrainingVideos> GetTrainingVideos();
        List<TrainingVideos> GetStudentPaidTrainingVideos(string userID);
        List<int> GetListOfCourseIdStudentPaid4(string userID);
        TrainingVideos GetVideosById(Guid Id);
        TestQuestions GetQuestionsById(int? Id);
        List<TestQuestions> GetTestQuestions();
        List<TestQuestionsViewModel> GetTestQuestionsForPage1(int? Id);
        List<TestQuestionsViewModel> GetTestQuestionsForPage2(int? Id);
        List<string> SplitStringToList(string dataString);
        List<ProjectTopic> AllSubmenttedProjectTopic();
        ProjectTopic GetProjectTopicById(int? id);
        ProjectTopic CheckIfATopicHasBeenApprovedForTheSelectedCourse(ProjectTopic proj2Approve);
        ApplicantDocumment GetApplicationDocummentByUserId(string userID);
        List<string> GetOptListByQuestionIds(int id);
        Job GetJobById(int? Id);
        List<InterviewQuestions> GetInterviewTestQuestions();
        InterviewQuestions GetInterviewQuestionsById(int Id);
        InterviewViewModel GetInterviewQuestions();
        List<string> GetInterviewOptListByQuestionIds(int id);
        int GetInterviewTestDuration();
        bool CheckIfUserHaveTakenThisInterview(string userID);
    }

}
