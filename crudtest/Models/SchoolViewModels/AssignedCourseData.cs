using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;

namespace crudtest.Models.SchoolViewModels
{
    public class AssignedCourseData
    {
        public int CourseID { get; set;}
        public string Title { get; set; }
        public bool Assigned {  get; set; }
    }
}
