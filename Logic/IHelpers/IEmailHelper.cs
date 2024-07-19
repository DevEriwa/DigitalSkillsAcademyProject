using Core.Models;
using Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logic.IHelpers
{
    public interface IEmailHelper
    {
        bool SendMailToApplicant(ApplicationUser userDetail, string linkToClick);
        bool VerificationEmail(string applicantEmail, string linkToClick);
        Task<UserVerification> CreateUserToken(string userEmail);
        bool Gratitude(string applicantEmail);
        void ForgotPasswordTemplateEmailer(ApplicationUser userEmail, string linkToClick);
        Task PasswordResetedTemplateEmailerAsync(ApplicationUser userEmail, string linkToClick);
        bool ChangePasswordMailTemlate(ApplicationUser userDetail, string linkToClick);
        bool ChangePasswordAlert(ApplicationUser userDetail, string linkToClick);
        bool ApprovedProjectTopicMailTemlate(ApplicationUser userDetail, ProjectTopic topicOwer);
        bool SendPaymentAprovalMsg(ApplicationUser userDetail, string course);
        bool SendPaymentDeclineMsg(ApplicationUser userDetail, string course);
        bool SendMailToAdminOnJobApplication(ApplicationUserViewModel userDetail, Job jobDetails);
        bool SendMailToStudentsOnProjectCompletion(string emailAddressTo);
        bool SendMailToNewEmployee(string reference);
        bool InformApplicantAboutWrittenInterview(string userEmail);
        bool DeclineApplicant(string userEmail);
        bool AcceptSuccessfulApplicantMessage(string userEmail);
    }
}
