namespace Schol_project
{
    partial class Form1
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
            this.Stackpanel = new Schol_project.StackPanel();
            this.student_login = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tbpassword_student = new System.Windows.Forms.TextBox();
            this.tbusername_student = new System.Windows.Forms.TextBox();
            this.teacher_login = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.TeacherView = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.ViewMusic0 = new System.Windows.Forms.Button();
            this.StudentView = new System.Windows.Forms.TabPage();
            this.AssessedTask = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Transcribe1 = new System.Windows.Forms.Button();
            this.ViewMusic1 = new System.Windows.Forms.Button();
            this.MusicView = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Login_Page = new System.Windows.Forms.TabPage();
            this.teacher_button = new System.Windows.Forms.Button();
            this.student_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Stackpanel.SuspendLayout();
            this.student_login.SuspendLayout();
            this.teacher_login.SuspendLayout();
            this.TeacherView.SuspendLayout();
            this.StudentView.SuspendLayout();
            this.MusicView.SuspendLayout();
            this.Login_Page.SuspendLayout();
            this.SuspendLayout();
            // 
            // Stackpanel
            // 
            this.Stackpanel.Controls.Add(this.student_login);
            this.Stackpanel.Controls.Add(this.teacher_login);
            this.Stackpanel.Controls.Add(this.TeacherView);
            this.Stackpanel.Controls.Add(this.StudentView);
            this.Stackpanel.Controls.Add(this.MusicView);
            this.Stackpanel.Controls.Add(this.Login_Page);
            this.Stackpanel.Location = new System.Drawing.Point(3, 0);
            this.Stackpanel.Margin = new System.Windows.Forms.Padding(4);
            this.Stackpanel.Name = "Stackpanel";
            this.Stackpanel.SelectedIndex = 0;
            this.Stackpanel.Size = new System.Drawing.Size(1063, 553);
            this.Stackpanel.TabIndex = 5;
            // 
            // student_login
            // 
            this.student_login.Controls.Add(this.button2);
            this.student_login.Controls.Add(this.tbpassword_student);
            this.student_login.Controls.Add(this.tbusername_student);
            this.student_login.Location = new System.Drawing.Point(4, 25);
            this.student_login.Margin = new System.Windows.Forms.Padding(4);
            this.student_login.Name = "student_login";
            this.student_login.Padding = new System.Windows.Forms.Padding(4);
            this.student_login.Size = new System.Drawing.Size(1055, 524);
            this.student_login.TabIndex = 5;
            this.student_login.Text = "student login";
            this.student_login.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 270);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tbpassword_student
            // 
            this.tbpassword_student.Location = new System.Drawing.Point(412, 225);
            this.tbpassword_student.Margin = new System.Windows.Forms.Padding(4);
            this.tbpassword_student.Name = "tbpassword_student";
            this.tbpassword_student.Size = new System.Drawing.Size(132, 22);
            this.tbpassword_student.TabIndex = 1;
            // 
            // tbusername_student
            // 
            this.tbusername_student.Location = new System.Drawing.Point(412, 166);
            this.tbusername_student.Margin = new System.Windows.Forms.Padding(4);
            this.tbusername_student.Name = "tbusername_student";
            this.tbusername_student.Size = new System.Drawing.Size(132, 22);
            this.tbusername_student.TabIndex = 0;
            this.tbusername_student.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // teacher_login
            // 
            this.teacher_login.Controls.Add(this.label1);
            this.teacher_login.Controls.Add(this.button1);
            this.teacher_login.Controls.Add(this.tbUsername);
            this.teacher_login.Controls.Add(this.label2);
            this.teacher_login.Controls.Add(this.tbPassword);
            this.teacher_login.Location = new System.Drawing.Point(4, 25);
            this.teacher_login.Margin = new System.Windows.Forms.Padding(4);
            this.teacher_login.Name = "teacher_login";
            this.teacher_login.Padding = new System.Windows.Forms.Padding(4);
            this.teacher_login.Size = new System.Drawing.Size(1055, 524);
            this.teacher_login.TabIndex = 0;
            this.teacher_login.Text = "Teacher login";
            this.teacher_login.UseVisualStyleBackColor = true;
            this.teacher_login.Click += new System.EventHandler(this.LoginPage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Musio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 321);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(459, 203);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(132, 22);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teacher log in";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(459, 257);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(132, 22);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // TeacherView
            // 
            this.TeacherView.Controls.Add(this.button4);
            this.TeacherView.Controls.Add(this.button3);
            this.TeacherView.Controls.Add(this.listView2);
            this.TeacherView.Controls.Add(this.ViewMusic0);
            this.TeacherView.Location = new System.Drawing.Point(4, 25);
            this.TeacherView.Margin = new System.Windows.Forms.Padding(4);
            this.TeacherView.Name = "TeacherView";
            this.TeacherView.Padding = new System.Windows.Forms.Padding(4);
            this.TeacherView.Size = new System.Drawing.Size(1055, 524);
            this.TeacherView.TabIndex = 1;
            this.TeacherView.Text = "TeacherView";
            this.TeacherView.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(153, 7);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(745, 381);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // ViewMusic0
            // 
            this.ViewMusic0.Location = new System.Drawing.Point(445, 395);
            this.ViewMusic0.Margin = new System.Windows.Forms.Padding(4);
            this.ViewMusic0.Name = "ViewMusic0";
            this.ViewMusic0.Size = new System.Drawing.Size(100, 28);
            this.ViewMusic0.TabIndex = 0;
            this.ViewMusic0.Text = "Music View";
            this.ViewMusic0.UseVisualStyleBackColor = true;
            this.ViewMusic0.Click += new System.EventHandler(this.button2_Click);
            // 
            // StudentView
            // 
            this.StudentView.Controls.Add(this.AssessedTask);
            this.StudentView.Controls.Add(this.label3);
            this.StudentView.Controls.Add(this.comboBox1);
            this.StudentView.Controls.Add(this.Transcribe1);
            this.StudentView.Controls.Add(this.ViewMusic1);
            this.StudentView.Location = new System.Drawing.Point(4, 25);
            this.StudentView.Margin = new System.Windows.Forms.Padding(4);
            this.StudentView.Name = "StudentView";
            this.StudentView.Padding = new System.Windows.Forms.Padding(4);
            this.StudentView.Size = new System.Drawing.Size(1055, 524);
            this.StudentView.TabIndex = 2;
            this.StudentView.Text = "StudentView";
            this.StudentView.UseVisualStyleBackColor = true;
            // 
            // AssessedTask
            // 
            this.AssessedTask.Location = new System.Drawing.Point(409, 255);
            this.AssessedTask.Margin = new System.Windows.Forms.Padding(4);
            this.AssessedTask.Name = "AssessedTask";
            this.AssessedTask.Size = new System.Drawing.Size(252, 28);
            this.AssessedTask.TabIndex = 4;
            this.AssessedTask.Text = "Transcribe for assessment";
            this.AssessedTask.UseVisualStyleBackColor = true;
            this.AssessedTask.Click += new System.EventHandler(this.AssessedTask_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Task";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(453, 186);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // Transcribe1
            // 
            this.Transcribe1.Location = new System.Drawing.Point(483, 219);
            this.Transcribe1.Margin = new System.Windows.Forms.Padding(4);
            this.Transcribe1.Name = "Transcribe1";
            this.Transcribe1.Size = new System.Drawing.Size(100, 28);
            this.Transcribe1.TabIndex = 1;
            this.Transcribe1.Text = "Transcribe!";
            this.Transcribe1.UseVisualStyleBackColor = true;
            this.Transcribe1.Click += new System.EventHandler(this.Transcribe1_Click);
            // 
            // ViewMusic1
            // 
            this.ViewMusic1.Location = new System.Drawing.Point(483, 414);
            this.ViewMusic1.Margin = new System.Windows.Forms.Padding(4);
            this.ViewMusic1.Name = "ViewMusic1";
            this.ViewMusic1.Size = new System.Drawing.Size(100, 28);
            this.ViewMusic1.TabIndex = 0;
            this.ViewMusic1.Text = "View Music";
            this.ViewMusic1.UseVisualStyleBackColor = true;
            this.ViewMusic1.Click += new System.EventHandler(this.ViewMusic_Click);
            // 
            // MusicView
            // 
            this.MusicView.Controls.Add(this.listView1);
            this.MusicView.Location = new System.Drawing.Point(4, 25);
            this.MusicView.Margin = new System.Windows.Forms.Padding(4);
            this.MusicView.Name = "MusicView";
            this.MusicView.Padding = new System.Windows.Forms.Padding(4);
            this.MusicView.Size = new System.Drawing.Size(1055, 524);
            this.MusicView.TabIndex = 3;
            this.MusicView.Text = "MusicView";
            this.MusicView.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(229, 44);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(580, 436);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Login_Page
            // 
            this.Login_Page.Controls.Add(this.teacher_button);
            this.Login_Page.Controls.Add(this.student_button);
            this.Login_Page.Location = new System.Drawing.Point(4, 25);
            this.Login_Page.Margin = new System.Windows.Forms.Padding(4);
            this.Login_Page.Name = "Login_Page";
            this.Login_Page.Padding = new System.Windows.Forms.Padding(4);
            this.Login_Page.Size = new System.Drawing.Size(1055, 524);
            this.Login_Page.TabIndex = 4;
            this.Login_Page.Text = "Login page";
            this.Login_Page.UseVisualStyleBackColor = true;
            // 
            // teacher_button
            // 
            this.teacher_button.Location = new System.Drawing.Point(415, 208);
            this.teacher_button.Margin = new System.Windows.Forms.Padding(4);
            this.teacher_button.Name = "teacher_button";
            this.teacher_button.Size = new System.Drawing.Size(189, 28);
            this.teacher_button.TabIndex = 1;
            this.teacher_button.Text = "Login as teacher";
            this.teacher_button.UseVisualStyleBackColor = true;
            this.teacher_button.Click += new System.EventHandler(this.teacher_button_Click);
            // 
            // student_button
            // 
            this.student_button.Location = new System.Drawing.Point(415, 153);
            this.student_button.Margin = new System.Windows.Forms.Padding(4);
            this.student_button.Name = "student_button";
            this.student_button.Size = new System.Drawing.Size(189, 28);
            this.student_button.TabIndex = 0;
            this.student_button.Text = "Login as Student";
            this.student_button.UseVisualStyleBackColor = true;
            this.student_button.Click += new System.EventHandler(this.student_button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(934, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(934, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Stackpanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Stackpanel.ResumeLayout(false);
            this.student_login.ResumeLayout(false);
            this.student_login.PerformLayout();
            this.teacher_login.ResumeLayout(false);
            this.teacher_login.PerformLayout();
            this.TeacherView.ResumeLayout(false);
            this.StudentView.ResumeLayout(false);
            this.StudentView.PerformLayout();
            this.MusicView.ResumeLayout(false);
            this.Login_Page.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private StackPanel Stackpanel;
        private System.Windows.Forms.TabPage teacher_login;
        private System.Windows.Forms.TabPage TeacherView;
        private System.Windows.Forms.TabPage StudentView;
        private System.Windows.Forms.TabPage MusicView;
        private System.Windows.Forms.Button ViewMusic0;
        private System.Windows.Forms.Button ViewMusic1;
        private System.Windows.Forms.Button Transcribe1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AssessedTask;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage Login_Page;
        private System.Windows.Forms.Button teacher_button;
        private System.Windows.Forms.Button student_button;
        private System.Windows.Forms.TabPage student_login;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbpassword_student;
        private System.Windows.Forms.TextBox tbusername_student;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

