using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Specification_Pattern.Old_Solution;

namespace Specification_Pattern.Controllers
{
    [Route("api/v1/[controller]")]
    public class ValuesController : Controller
    {
        public List<CourseDTO> GetCourses(string cultureCode)
        {
            var courses = DataTransferObjectsHelper.GetCourseItems(cultureCode);
            return courses;
        }
    }
}
