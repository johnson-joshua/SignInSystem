namespace SignInSystem
{
    public partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCNum = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSignInTime = new System.Windows.Forms.TextBox();
            this.lblValidate = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblExplinationForOther = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(47, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student C#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(513, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Today\'s Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(11, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student Name";
            // 
            // txtCNum
            // 
            this.txtCNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNum.Location = new System.Drawing.Point(194, 34);
            this.txtCNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCNum.Name = "txtCNum";
            this.txtCNum.Size = new System.Drawing.Size(174, 26);
            this.txtCNum.TabIndex = 4;
            this.txtCNum.TextChanged += new System.EventHandler(this.txtCNum_TextChanged);
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(681, 34);
            this.txtDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(116, 26);
            this.txtDate.TabIndex = 5;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Enabled = false;
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(194, 124);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(172, 26);
            this.txtStudentName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(518, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sign In Time";
            // 
            // txtSignInTime
            // 
            this.txtSignInTime.Enabled = false;
            this.txtSignInTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignInTime.Location = new System.Drawing.Point(681, 124);
            this.txtSignInTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSignInTime.Name = "txtSignInTime";
            this.txtSignInTime.Size = new System.Drawing.Size(116, 26);
            this.txtSignInTime.TabIndex = 10;
            // 
            // lblValidate
            // 
            this.lblValidate.AutoSize = true;
            this.lblValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidate.Location = new System.Drawing.Point(188, 307);
            this.lblValidate.Name = "lblValidate";
            this.lblValidate.Size = new System.Drawing.Size(92, 31);
            this.lblValidate.TabIndex = 11;
            this.lblValidate.Text = "label6";
            this.lblValidate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblValidate.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Enabled = false;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(163, 405);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(175, 58);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Black;
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Red;
            this.btnSubmit.Location = new System.Drawing.Point(488, 405);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(175, 58);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Sign In";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbxSubject
            // 
            this.cbxSubject.Enabled = false;
            this.cbxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Location = new System.Drawing.Point(210, 231);
            this.cbxSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(141, 33);
            this.cbxSubject.TabIndex = 2;
            this.cbxSubject.Text = "Subject";
            this.cbxSubject.SelectedIndexChanged += new System.EventHandler(this.cbxSubject_SelectedIndexChanged);
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(524, 238);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(273, 26);
            this.txtNotes.TabIndex = 14;
            this.txtNotes.Visible = false;
            // 
            // lblExplinationForOther
            // 
            this.lblExplinationForOther.AutoSize = true;
            this.lblExplinationForOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplinationForOther.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExplinationForOther.Location = new System.Drawing.Point(512, 202);
            this.lblExplinationForOther.Name = "lblExplinationForOther";
            this.lblExplinationForOther.Size = new System.Drawing.Size(285, 20);
            this.lblExplinationForOther.TabIndex = 15;
            this.lblExplinationForOther.Text = "Please explain the purpose of your visit.";
            this.lblExplinationForOther.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 508);
            this.Controls.Add(this.lblExplinationForOther);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.cbxSubject);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblValidate);
            this.Controls.Add(this.txtSignInTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtCNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Student Learning Center";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        #region Getters and Setters
        private System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button BtnClear
        {
            get { return btnClear; }
            set { btnClear = value; }
        }

        private System.Windows.Forms.Button btnSubmit;
        public System.Windows.Forms.Button BtnSubmit
        {
            get { return btnSubmit; }
            set { btnSubmit = value; }
        }

        private System.Windows.Forms.TextBox txtCNum;
        public System.Windows.Forms.TextBox TxtCNum
        {
            get { return txtCNum; }
            set { txtCNum = value; }
        }

        private System.Windows.Forms.TextBox txtDate;
        public System.Windows.Forms.TextBox TxtDate
        {
            get { return txtDate; }
            set { txtDate = value; }
        }

        private System.Windows.Forms.TextBox txtStudentName;
        public System.Windows.Forms.TextBox TxtStudentName
        {
            get { return txtStudentName; }
            set { txtStudentName = value; }
        }

        private System.Windows.Forms.TextBox txtSignInTime;
        public System.Windows.Forms.TextBox TxtSignInTime
        {
            get { return txtSignInTime; }
            set { txtSignInTime = value; }
        }

        private System.Windows.Forms.TextBox txtNotes;
        public System.Windows.Forms.TextBox TxtNotes
        {
            get { return txtNotes; }
            set { txtNotes = value; }
        }
        
        private System.Windows.Forms.Label lblValidate;
        public System.Windows.Forms.Label LblValidate
        {
            get { return lblValidate; }
            set { lblValidate = value; }
        }

        private System.Windows.Forms.Label lblExplinationForOther;
        public System.Windows.Forms.Label LblExplinationForOther
        {
            get { return lblExplinationForOther; }
            set { lblExplinationForOther = value; }
        }
        
        private System.Windows.Forms.ComboBox cbxSubject;
        public System.Windows.Forms.ComboBox CbxSubject
        {
            get { return cbxSubject; }
            set { cbxSubject = value; }
        }
#endregion
    }
}

