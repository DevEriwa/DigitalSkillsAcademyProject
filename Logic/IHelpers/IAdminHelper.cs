using Core.Models;
using Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Logic.Helpers.AdminHelper;

namespace Logic.IHelpers
{
    public interface IAdminHelper
    {
        TrainingCourse AddTrainignCostServices(TrainingCourseViewModel collectedData);
        TrainingCourse EditTrainignCostServices(TrainingCourseViewModel collectedData);
        TrainingCourse DisableTrainignCostServices(TrainingCourseViewModel collectedData);
        TrainingCourse ActivateTrainignCostServices(TrainingCourseViewModel collectedData);
        TrainingCourse DeleteTrainignCostServices(TrainingCourseViewModel collectedData);
        Payments ApproveSelectedPayment(Payments paymentData);
        Payments DeclineSelectedPaymment(Payments paymentData);
        TrainingVideos TrainignVideoServices(TrainingVideosViewModel collectedData);
        TestQuestions TestQuestionsServices(TestQuestionsViewModel collectedData);
        List<string> GetOptListByQuestionIds(int id);
        bool PostServices4Options(AnswerOptionViewModel collectedData);
        List<ProjectTopic> GetListOfAllApprovedProjectTopic();
        ProjectTopic ProjectCompletionServices(int topicId);
        List<Job> GetListOfAllJobs();
        Job JobManagementServices(JobViewModels collectedData);
        AdminDashBoardViewModel DashboardBuildingServices();
        int TotalActiveStudents();
        int TotalNumberOfStudentsProjects();
        int TotalNumberOfJobApplications();
        List<ProjectTopic> GetListOfApprovedProjects();
        List<EmployementData> GetListOfEmploymentData();
        bool ManageGraduationFormServices(EmployementDataViewModel employementDataViewModel);
        ReoccuringPayments SaveCreatedPlan(ReocurringPaymentViewModel reocurringPaymentViewModel, string userId);
        bool AddCustomerSUbscriptionLink(ReocurringPaymentViewModel reocurringPaymentViewModel, int mainId);
        List<SalaryRetures> GetListOfSalaryPaymentsHistory();
        InterviewQuestions InterviewQuestionsServices(InterviewQuestionsViewModel collectedData);
        List<string> GetInterviewOptListByQuestionIds(int id);
        bool PostServicesInterviewAnsOptions(AnswerOptionViewModel collectedData);
        List<TestResult> GetListOfTestResults();
        List<InterviewTestResult> GetListOfInterviewResults();
        bool CreateExamDurationServices(ExamDuration collectedData);
        bool EditExamDurationServices(ExamDuration collectedData);
        bool DeleteExamDurationServices(int id);
        List<ApplicantDocumment> GetListOfApplicantDocumment();
        bool DeleteDocumentServices(Guid id);
        bool QualifiedToTakeWrritingInterview(Guid id);
    }
}
