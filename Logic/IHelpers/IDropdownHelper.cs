using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Logic.Helpers.DropdownHelper;

namespace Logic.IHelpers
{
    public interface IDropdownHelper
    {
        List<DropDown> GetDropDownEnumsList();
        List<DropDown> GetApplicationStatusDropDownEnumsList();
        List<TrainingCourse> DropdownOfCourses();
        List<DropDown> DropdownOfCoursesWhereIsTested(string userId);
        List<DropDown> JobTypes();
        List<DropDown> JobTypesForSearch();
        List<DropDown> GetExamTypeList();
    }
}
