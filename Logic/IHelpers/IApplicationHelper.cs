using Core.Models;
using Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logic.IHelpers
{
	public interface IApplicationHelper
	{
        Task<ApplicationUser> RegisterApplicantService(ApplicationUserViewModel applicationUserViewModel);
        Task<ApplicationUser> RegisterAdminService(ApplicationUserViewModel applicationUserViewModel);
        Task<ApplicationUser> AuthenticateUser(LoginViewModel loginViewModel);
        string GetUserDashboardPage(ApplicationUser userr);
        Task<bool> LogOut();
        string GetUserLayout(string username);
        ApplicationUser AcceptSelectedApplication(ApplicationUser applicantIdToAccept);
        ApplicationUser RejectSelectedApplication(ApplicationUser applicantIdToReject);
        ApplicationUser QualifiedToTakeWrritingInterview(ApplicationUser applicantIdToAccept);
    }
}
