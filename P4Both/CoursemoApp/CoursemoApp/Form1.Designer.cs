namespace CoursemoApp
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
            this.studentList = new System.Windows.Forms.ListBox();
            this.courseList = new System.Windows.Forms.ListBox();
            this.displayStudents = new System.Windows.Forms.Button();
            this.displayCourses = new System.Windows.Forms.Button();
            this.courseSemester = new System.Windows.Forms.TextBox();
            this.courseYear = new System.Windows.Forms.TextBox();
            this.courseType = new System.Windows.Forms.TextBox();
            this.courseDay = new System.Windows.Forms.TextBox();
            this.courseTime = new System.Windows.Forms.TextBox();
            this.courseClassSize = new System.Windows.Forms.TextBox();
            this.courseEnrolled = new System.Windows.Forms.TextBox();
            this.courseWaiting = new System.Windows.Forms.TextBox();
            this.enrolledList = new System.Windows.Forms.ListBox();
            this.waitingList = new System.Windows.Forms.ListBox();
            this.studentEnrolled = new System.Windows.Forms.ListBox();
            this.studentWaiting = new System.Windows.Forms.ListBox();
            this.Enroll = new System.Windows.Forms.Button();
            this.Drop = new System.Windows.Forms.Button();
            this.Swap = new System.Windows.Forms.Button();
            this.courseList2 = new System.Windows.Forms.ListBox();
            this.studentList2 = new System.Windows.Forms.ListBox();
            this.resetDatabase = new System.Windows.Forms.Button();
            this.delayTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // studentList
            // 
            this.studentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentList.FormattingEnabled = true;
            this.studentList.ItemHeight = 15;
            this.studentList.Location = new System.Drawing.Point(13, 13);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(215, 199);
            this.studentList.TabIndex = 0;
            this.studentList.SelectedIndexChanged += new System.EventHandler(this.studentList_SelectedIndexChanged);
            // 
            // courseList
            // 
            this.courseList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseList.FormattingEnabled = true;
            this.courseList.ItemHeight = 15;
            this.courseList.Location = new System.Drawing.Point(12, 261);
            this.courseList.Name = "courseList";
            this.courseList.Size = new System.Drawing.Size(215, 199);
            this.courseList.TabIndex = 1;
            this.courseList.SelectedIndexChanged += new System.EventHandler(this.courseList_SelectedIndexChanged);
            // 
            // displayStudents
            // 
            this.displayStudents.Location = new System.Drawing.Point(12, 218);
            this.displayStudents.Name = "displayStudents";
            this.displayStudents.Size = new System.Drawing.Size(215, 23);
            this.displayStudents.TabIndex = 2;
            this.displayStudents.Text = "Display Students";
            this.displayStudents.UseVisualStyleBackColor = true;
            this.displayStudents.Click += new System.EventHandler(this.displayStudents_Click);
            // 
            // displayCourses
            // 
            this.displayCourses.Location = new System.Drawing.Point(12, 466);
            this.displayCourses.Name = "displayCourses";
            this.displayCourses.Size = new System.Drawing.Size(215, 23);
            this.displayCourses.TabIndex = 3;
            this.displayCourses.Text = "Display Courses";
            this.displayCourses.UseVisualStyleBackColor = true;
            this.displayCourses.Click += new System.EventHandler(this.displayCourses_Click);
            // 
            // courseSemester
            // 
            this.courseSemester.Location = new System.Drawing.Point(291, 261);
            this.courseSemester.Name = "courseSemester";
            this.courseSemester.Size = new System.Drawing.Size(110, 20);
            this.courseSemester.TabIndex = 4;
            // 
            // courseYear
            // 
            this.courseYear.Location = new System.Drawing.Point(291, 287);
            this.courseYear.Name = "courseYear";
            this.courseYear.Size = new System.Drawing.Size(110, 20);
            this.courseYear.TabIndex = 5;
            // 
            // courseType
            // 
            this.courseType.Location = new System.Drawing.Point(291, 313);
            this.courseType.Name = "courseType";
            this.courseType.Size = new System.Drawing.Size(110, 20);
            this.courseType.TabIndex = 6;
            // 
            // courseDay
            // 
            this.courseDay.Location = new System.Drawing.Point(291, 339);
            this.courseDay.Name = "courseDay";
            this.courseDay.Size = new System.Drawing.Size(110, 20);
            this.courseDay.TabIndex = 7;
            // 
            // courseTime
            // 
            this.courseTime.Location = new System.Drawing.Point(291, 365);
            this.courseTime.Name = "courseTime";
            this.courseTime.Size = new System.Drawing.Size(110, 20);
            this.courseTime.TabIndex = 8;
            // 
            // courseClassSize
            // 
            this.courseClassSize.Location = new System.Drawing.Point(291, 391);
            this.courseClassSize.Name = "courseClassSize";
            this.courseClassSize.Size = new System.Drawing.Size(110, 20);
            this.courseClassSize.TabIndex = 9;
            // 
            // courseEnrolled
            // 
            this.courseEnrolled.Location = new System.Drawing.Point(291, 417);
            this.courseEnrolled.Name = "courseEnrolled";
            this.courseEnrolled.Size = new System.Drawing.Size(110, 20);
            this.courseEnrolled.TabIndex = 10;
            // 
            // courseWaiting
            // 
            this.courseWaiting.Location = new System.Drawing.Point(291, 443);
            this.courseWaiting.Name = "courseWaiting";
            this.courseWaiting.Size = new System.Drawing.Size(110, 20);
            this.courseWaiting.TabIndex = 11;
            // 
            // enrolledList
            // 
            this.enrolledList.FormattingEnabled = true;
            this.enrolledList.Location = new System.Drawing.Point(407, 261);
            this.enrolledList.Name = "enrolledList";
            this.enrolledList.Size = new System.Drawing.Size(150, 95);
            this.enrolledList.TabIndex = 12;
            // 
            // waitingList
            // 
            this.waitingList.FormattingEnabled = true;
            this.waitingList.Location = new System.Drawing.Point(407, 368);
            this.waitingList.Name = "waitingList";
            this.waitingList.Size = new System.Drawing.Size(150, 95);
            this.waitingList.TabIndex = 13;
            // 
            // studentEnrolled
            // 
            this.studentEnrolled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentEnrolled.FormattingEnabled = true;
            this.studentEnrolled.ItemHeight = 15;
            this.studentEnrolled.Location = new System.Drawing.Point(291, 12);
            this.studentEnrolled.Name = "studentEnrolled";
            this.studentEnrolled.Size = new System.Drawing.Size(266, 94);
            this.studentEnrolled.TabIndex = 14;
            // 
            // studentWaiting
            // 
            this.studentWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentWaiting.FormattingEnabled = true;
            this.studentWaiting.ItemHeight = 15;
            this.studentWaiting.Location = new System.Drawing.Point(291, 113);
            this.studentWaiting.Name = "studentWaiting";
            this.studentWaiting.Size = new System.Drawing.Size(266, 94);
            this.studentWaiting.TabIndex = 15;
            // 
            // Enroll
            // 
            this.Enroll.Location = new System.Drawing.Point(291, 218);
            this.Enroll.Name = "Enroll";
            this.Enroll.Size = new System.Drawing.Size(130, 37);
            this.Enroll.TabIndex = 16;
            this.Enroll.Text = "Enroll";
            this.Enroll.UseVisualStyleBackColor = true;
            this.Enroll.Click += new System.EventHandler(this.Enroll_Click);
            // 
            // Drop
            // 
            this.Drop.Location = new System.Drawing.Point(427, 218);
            this.Drop.Name = "Drop";
            this.Drop.Size = new System.Drawing.Size(130, 37);
            this.Drop.TabIndex = 17;
            this.Drop.Text = "Drop";
            this.Drop.UseVisualStyleBackColor = true;
            this.Drop.Click += new System.EventHandler(this.Drop_Click);
            // 
            // Swap
            // 
            this.Swap.Location = new System.Drawing.Point(617, 218);
            this.Swap.Name = "Swap";
            this.Swap.Size = new System.Drawing.Size(215, 37);
            this.Swap.TabIndex = 18;
            this.Swap.Text = "Swap";
            this.Swap.UseVisualStyleBackColor = true;
            this.Swap.Click += new System.EventHandler(this.Swap_Click);
            // 
            // courseList2
            // 
            this.courseList2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseList2.FormattingEnabled = true;
            this.courseList2.ItemHeight = 15;
            this.courseList2.Location = new System.Drawing.Point(617, 261);
            this.courseList2.Name = "courseList2";
            this.courseList2.Size = new System.Drawing.Size(215, 199);
            this.courseList2.TabIndex = 19;
            // 
            // studentList2
            // 
            this.studentList2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentList2.FormattingEnabled = true;
            this.studentList2.ItemHeight = 15;
            this.studentList2.Location = new System.Drawing.Point(617, 13);
            this.studentList2.Name = "studentList2";
            this.studentList2.Size = new System.Drawing.Size(215, 199);
            this.studentList2.TabIndex = 20;
            // 
            // resetDatabase
            // 
            this.resetDatabase.Location = new System.Drawing.Point(291, 466);
            this.resetDatabase.Name = "resetDatabase";
            this.resetDatabase.Size = new System.Drawing.Size(266, 23);
            this.resetDatabase.TabIndex = 21;
            this.resetDatabase.Text = "Reset Database";
            this.resetDatabase.UseVisualStyleBackColor = true;
            this.resetDatabase.Click += new System.EventHandler(this.resetDatabase_Click);
            // 
            // delayTime
            // 
            this.delayTime.Location = new System.Drawing.Point(617, 467);
            this.delayTime.Name = "delayTime";
            this.delayTime.Size = new System.Drawing.Size(215, 20);
            this.delayTime.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(844, 501);
            this.Controls.Add(this.delayTime);
            this.Controls.Add(this.resetDatabase);
            this.Controls.Add(this.studentList2);
            this.Controls.Add(this.courseList2);
            this.Controls.Add(this.Swap);
            this.Controls.Add(this.Drop);
            this.Controls.Add(this.Enroll);
            this.Controls.Add(this.studentWaiting);
            this.Controls.Add(this.studentEnrolled);
            this.Controls.Add(this.waitingList);
            this.Controls.Add(this.enrolledList);
            this.Controls.Add(this.courseWaiting);
            this.Controls.Add(this.courseEnrolled);
            this.Controls.Add(this.courseClassSize);
            this.Controls.Add(this.courseTime);
            this.Controls.Add(this.courseDay);
            this.Controls.Add(this.courseType);
            this.Controls.Add(this.courseYear);
            this.Controls.Add(this.courseSemester);
            this.Controls.Add(this.displayCourses);
            this.Controls.Add(this.displayStudents);
            this.Controls.Add(this.courseList);
            this.Controls.Add(this.studentList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox studentList;
        private System.Windows.Forms.ListBox courseList;
        private System.Windows.Forms.Button displayStudents;
        private System.Windows.Forms.Button displayCourses;
        private System.Windows.Forms.TextBox courseSemester;
        private System.Windows.Forms.TextBox courseYear;
        private System.Windows.Forms.TextBox courseType;
        private System.Windows.Forms.TextBox courseDay;
        private System.Windows.Forms.TextBox courseTime;
        private System.Windows.Forms.TextBox courseClassSize;
        private System.Windows.Forms.TextBox courseEnrolled;
        private System.Windows.Forms.TextBox courseWaiting;
        private System.Windows.Forms.ListBox enrolledList;
        private System.Windows.Forms.ListBox waitingList;
        private System.Windows.Forms.ListBox studentEnrolled;
        private System.Windows.Forms.ListBox studentWaiting;
        private System.Windows.Forms.Button Enroll;
        private System.Windows.Forms.Button Drop;
        private System.Windows.Forms.Button Swap;
        private System.Windows.Forms.ListBox courseList2;
        private System.Windows.Forms.ListBox studentList2;
        private System.Windows.Forms.Button resetDatabase;
        private System.Windows.Forms.TextBox delayTime;
    }
}

