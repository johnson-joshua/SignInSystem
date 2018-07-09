using SignInSystem.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSystem.Controllers
{
    public class Form1Controller
    {
        public static void validateCNumber(string cNum)
        {
            
            if (cNum != null && cNum.Count() == 9)
            {
                if (cNum.StartsWith("C00"))
                {
                    Program.usableForm.LblValidate.Visible = false;
                    Program.usableForm.TxtCNum.Text = cNum;
                    getIndividualStudentInformation(cNum);
                    Program.usableForm.BtnClear.Enabled = true;
                    Program.usableForm.BtnSubmit.Enabled = true;
                    //txtCNum.Enabled = true;
                }
            }
            if (cNum.Count() > 9)
                invalidEntry();

            if (cNum == "")
                Program.usableForm.LblValidate.Visible = false;
        }

        public static Boolean checkForRequiredFields()
        {
            if (Program.usableForm.CbxSubject.SelectedItem == null)
            {
                MessageBox.Show("Subject field is required.");
                Program.usableForm.CbxSubject.Focus();
                return false;
            }
            if (Program.usableForm.CbxSubject.SelectedItem.ToString() == "Other" && Program.usableForm.TxtNotes.Text == "")
            {
                MessageBox.Show("When choosing the 'Other' subject, you must fill in the 'Notes' box.");
                Program.usableForm.TxtNotes.Focus();
                return false;
            }
            return true;
        }

        private static void getIndividualStudentInformation(string cNum)
        {
            var studentQuery = from Student x in Program.arrayWithEveryStudent
                               where x.StudentID == cNum
                               select new Student
                               {
                                   StudentID = x.StudentID,
                                   StudentFirstName = x.StudentFirstName,
                                   StudentLastName = x.StudentLastName,
                                   Section = x.Section,
                                   CourseTitle = x.CourseTitle,
                                   CRN = x.CRN,
                                   InstructorFullName = x.InstructorFullName,
                                   Term = x.Term
                               };
            var queryList = studentQuery.ToList();

            if (queryList.Count == 0)
            {
                invalidEntry();
            }
            else
            {
                setName(queryList);
                setupCbxSubject(queryList);
                setTimeAndDate();
                Program.usableForm.TxtCNum.Enabled = false;
                Program.usableForm.BtnClear.Enabled = true;
                Program.usableForm.BtnSubmit.Enabled = true;
            }
        }

        public static void invalidEntry()
        {
            Program.usableForm.LblValidate.Visible = true;
            Program.usableForm.LblValidate.ForeColor = Color.Red;
            Program.usableForm.LblValidate.Text = "Invalid Student C Number!\nScan ID Card again.";
            clearFields();
            Program.usableForm.TxtCNum.Focus();
        }

        private static void setName(List<Student> queryList)
        {
            Program.usableForm.TxtStudentName.Text = queryList.First().StudentFirstName + " " + queryList.First().StudentLastName;
        }

        private static void setupCbxSubject(List<Student> queryList)
        {
            foreach (Student student in queryList)
            {
                Program.usableForm.CbxSubject.Items.Add(student.CourseTitle);
                Program.usableForm.CbxSubject.Enabled = true;
            }
            Program.usableForm.CbxSubject.Items.Add("Other");
        }

        private static void setTimeAndDate()
        {
            string todaysDate = System.DateTime.Today.ToShortDateString();
            string currentTime = System.DateTime.Now.ToShortTimeString();
            Program.usableForm.TxtDate.Text = todaysDate;
            Program.usableForm.TxtSignInTime.Text = currentTime;
        }

        public static void clearFields()
        {
            Program.usableForm.TxtCNum.Clear();
            Program.usableForm.TxtCNum.Enabled = true;
            Program.usableForm.BtnSubmit.Enabled = false;
            Program.usableForm.BtnClear.Enabled = false;
            Program.usableForm.TxtDate.Clear();
            Program.usableForm.TxtSignInTime.Clear();
            Program.usableForm.TxtStudentName.Clear();
            Program.usableForm.CbxSubject.Items.Clear();
            Program.usableForm.CbxSubject.Text = "Subject";
            Program.usableForm.LblExplinationForOther.Visible = false;
            Program.usableForm.TxtNotes.Visible = false;
            Program.usableForm.CbxSubject.Enabled = false;
            Program.usableForm.TxtNotes.Text = "";
            Program.usableForm.TxtCNum.Focus();
        }
    }
}
