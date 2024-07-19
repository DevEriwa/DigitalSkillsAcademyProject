﻿using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.ViewModels
{
    public class AdminDashBoardViewModel
    {
        public virtual ApplicationUser Users { get; set; }
        public int? TotalActiveStudents { get; set; }
        public int? TotalNumberOfStudentsProjects { get; set; }
        public int TotalNumberOfJobApplications { get; set; }
        public virtual List<ApplicationUserViewModel> OnboardStudentsList { get; set; }
        public virtual List<Payments> PaymentHistoryList { get; set; }
        public virtual List<ProjectTopic> ApprovedProjectList { get; set; }
    }
}
