using SignInSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSystem
{
    public partial class Form1 : Form
    {
        private string studentCNum;
        //private bool otherSubjectFlag = false;
        //public ArrayList activeUsersList = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            txtCNum.Focus();
        }
        
        private void txtCNum_TextChanged(object sender, EventArgs e)  
        {
           if (txtCNum.Text != "")
            {
                if (txtCNum.Text.StartsWith("C"))
                {
                    //Since all C# have 9 digits, don't validate number until there are 9 digits in box
                    if (txtCNum.Text.Count() >= 9)
                    {
                        studentCNum = txtCNum.Text;
                        Controllers.Form1Controller.validateCNumber(studentCNum);
                    }
                }
                else
                {
                    Controllers.Form1Controller.invalidEntry();
                }
            }
        }

        public void btnClear_Click(object sender, EventArgs e)
        {
            Controllers.Form1Controller.clearFields();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
               if (txtCNum.Text != "" && Controllers.Form1Controller.checkForRequiredFields())
            {
                using (StreamWriter writer = new StreamWriter("SignInResults.csv", true))
                {
                    
                    writer.Write(txtCNum.Text + ',' 
                        + txtStudentName.Text + ',' 
                        + txtDate.Text +',' 
                        + txtSignInTime.Text + ',' 
                        + cbxSubject.Text + ','
                        +txtNotes.Text
                        + "\n");
                }
                Controllers.Form1Controller.clearFields();
                txtCNum.Focus();
            }
        }

        private void cbxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Program.usableForm.CbxSubject.SelectedItem == "Other")
            {
                lblExplinationForOther.Visible = true;
                txtNotes.Visible = true;
            }
            else
            {
                lblExplinationForOther.Visible = false;
                txtNotes.Visible = false;
            }
        }
    }
}
