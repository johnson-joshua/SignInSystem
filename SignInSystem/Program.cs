using SignInSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSystem
{
    public static class Program
    {
        public static ArrayList arrayWithEveryStudent = getStudentData();
        public static Form1 usableForm;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            //Form1 usableForm = new Form1();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            usableForm = new Form1();
            Application.Run(usableForm);
        }

        private static ArrayList getStudentData()
        {
            ArrayList studentData = new ArrayList();
            try
            {
                using(StreamReader sr = new StreamReader("SignInStudentInfo.csv", true))
                {
                    string line;
                    var words = new string[9];
                    while((line = sr.ReadLine()) != null)
                    {
                        words = line.Split(new string[] {","}, StringSplitOptions.None);

                            studentData.Add(new Student {StudentID=words[0],
                                                         StudentFirstName=words[1],
                                                         StudentLastName=words[2],
                                                         CRN=words[3],
                                                         CourseTitle=words[4],
                                                         Section=words[5],
                                                         InstructorFullName=words[6],
                                                         Term=words[7]
                                                         });
                    }
                }
                return studentData;
            }
            catch(Exception e)
            {
                Console.WriteLine("The student data file could not be read.\n");
                Console.WriteLine(e.Message);
                return studentData;
            }
        }
    }
}
