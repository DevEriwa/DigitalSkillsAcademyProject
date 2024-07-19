using Core.Enum;
using Core.Models;
using Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logic.IHelpers
{
	public interface IStudentHelper
	{
        List<TrainingCourse> GetAllTrainingCourseDB();
        ApplicantDocumment UpdateApplicantDocumentService(ApplicantDocumment applicantDetailsForUpdate);
        bool DeosApplicantDocummentExist(string username);
        ApplicantDocumment UpdateApplicantDocumentsInfo(ApplicantDocumment applicantDocuments);
        TestResult ListOfAnsweredQuestions(TestQuestionsViewModel collectedData);
        TestResult GetStudentResult(int? Id, string userID);
        TestResult CheckIfTestOneHasBeebTakenByCurrentUser(int? id, string username);
        TrainingCourse GetTrainingCourseById(int? id);
        ProjectTopic UploadProjectTopicServices(ProjectTopicViewModel topics, string userId);
        ProjectTopic ProjectLinksUpdateServices(ProjectTopicViewModel topics);
        ProjectTopic GetProjectLinksServices(int id);
        List<ProjectTopic> GetListOfStutentsProjectTopic(string userId);
        List<ProjectTopic> GetListOfStutentsApprovedProjectTopic(string userId);
        Task<Payments> UploadMaualPaymentProve(PaymentsViewModel prove, string userId);
        List<JobViewModels> GetListOfAvailableJobs(string userID);
        List<JobViewModels> GetListOfAvailableJobsByJobType(string userID, JobType? id);
        Task<JobApplication> JobApplicationServices(int jobId, ApplicationUserViewModel user);
        List<int> GetListOfJobIdsUserHaveAppliedFor(string userID);
        bool CheckIfUserHaveAppliedForThisJob(List<int> getListJobId, int id);
        bool CheckIfUserIsQualifiedToApplyForJobs(string userId);
        StudentDashBoardViewModel DashboardBuildingServices();
        EmployementData EMploymentDataServer(EmployementDataViewModel employmentData, string userId);
        InterviewTestResult InterviewAnswerComputation(InterviewQuestionsViewModel collectedData);
    }
}
