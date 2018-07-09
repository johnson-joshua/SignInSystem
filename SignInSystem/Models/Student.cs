using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSystem.Models
{
    public class Student
    {
        public string StudentID { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string CRN { get; set; }
        public string CourseTitle { get; set; }
        public string Section { get; set; }
        public string InstructorFullName { get; set; }
        public string Term { get; set; }
        public DateTime SignInTime { get; set; }
        public DateTime SignOutTime { get; set; }
        public System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

    }
}
