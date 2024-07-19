﻿using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.ViewModels
{
	public class StudentDashBoardViewModel
	{
        public virtual ApplicationUserViewModel Users { get; set; }
        public virtual List<TestResult> TestResult { get; set; }  
        public virtual List<Job> ListOfRecentJobs { get; set; }
        public bool IsProjectCompleted { get; set; }
        public int TotalNumberCourses { get; set; }
        public int TotalNumberExamTaken { get; set; }
    }
}
