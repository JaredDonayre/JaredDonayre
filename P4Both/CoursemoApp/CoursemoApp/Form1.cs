/*
 Jared Donayre - jdonay2
 University of Illinois at Chicago
 CS 480 , Summer 2018
 Project #4
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoursemoApp
{
    public partial class Form1 : Form
    {
        private CoursemoDataContext db;

        public Form1()
        {
            InitializeComponent();

            db = new CoursemoDataContext();
        }

        //method to displayStudentInformation when student is selected or to reset displayed information when changes are made
        private void displayStudentInformation()
        {
            this.studentEnrolled.Items.Clear();
            this.studentWaiting.Items.Clear();

            Student s = (Student)this.studentList.SelectedItem;

            var enrolledQuery = from en in db.Enrolleds
                                where en.NetID == s.NetID
                                select en;

            var waitingQuery = from wa in db.WaitLists
                               where wa.NetID == s.NetID
                               select wa;

            var classes = from c in db.Courses
                          orderby c.Department, c.CourseNum
                          select c;

            if (enrolledQuery.Count() == 0)
            {
                this.studentEnrolled.Items.Add("Not enrolled in any courses currently.");
            }
            else
            {
                foreach (Course c in classes)
                {
                    foreach (Enrolled en in enrolledQuery)
                    {
                        if (en.CRN == c.CRN)
                        {
                            this.studentEnrolled.Items.Add(c.Department + " " + c.CourseNum + " : " + c.CRN);
                        }
                    }
                }
            }

            if (waitingQuery.Count() == 0)
            {
                this.studentWaiting.Items.Add("Not waiting on any courses currently.");
            }
            else
            {
                foreach (Course c in classes)
                {
                    foreach (WaitList wa in waitingQuery)
                    {
                        if (wa.CRN == c.CRN)
                        {
                            this.studentWaiting.Items.Add(c.Department + " " + c.CourseNum + " : " + c.CRN);
                        }
                    }
                }
            }

        }

        //method to display course information when course is selected or to reset displayed information after changes are made
        private void displayCourseInformation()
        {
            this.courseSemester.Clear();
            this.courseYear.Clear();
            this.courseType.Clear();
            this.courseDay.Clear();
            this.courseTime.Clear();
            this.courseClassSize.Clear();
            this.courseEnrolled.Clear();
            this.courseWaiting.Clear();
            this.enrolledList.Items.Clear();
            this.waitingList.Items.Clear();

            Course c = (Course)this.courseList.SelectedItem;

            this.courseSemester.Text = "Semester: " + c.Semester;
            this.courseYear.Text = "Year: " + c.Year.ToString();
            this.courseType.Text = "Type: " + c.Type;
            this.courseDay.Text = "Days: " + c.Day;
            this.courseTime.Text = "Time: " + c.Time;
            this.courseClassSize.Text = "Class Size: " + c.ClassSize.ToString();

            var enrolledQuery = from en in db.Enrolleds
                                where en.CRN == c.CRN
                                select en;

            var waitingQuery = from wa in db.WaitLists
                               where wa.CRN == c.CRN
                               select wa;

            this.courseEnrolled.Text = "Currently Enrolled: " + enrolledQuery.Count().ToString();
            this.courseWaiting.Text = "Currently Waiting: " + waitingQuery.Count().ToString();

            if (enrolledQuery.Count() == 0)
            {
                this.enrolledList.Items.Add("No students currently enrolled. ");
            }
            else
            {
                foreach (Enrolled en in enrolledQuery)
                {
                    this.enrolledList.Items.Add(en.NetID);
                }
            }

            if (waitingQuery.Count() == 0)
            {
                this.waitingList.Items.Add("No students currently waiting. ");
            }
            else
            {
                foreach (WaitList wa in waitingQuery)
                {
                    this.waitingList.Items.Add(wa.NetID);
                }
            }
        }

        //displays all students into listboxes
        private void displayStudents_Click(object sender, EventArgs e)
        {
            this.studentList.Items.Clear();

            var query = from s in db.Students
                        orderby s.StudLName, s.StudFName
                        select s;

            foreach(Student s in query)
            {
                this.studentList.Items.Add(s);
                this.studentList2.Items.Add(s);
            }

        }

        //displays all courses into listboxes
        private void displayCourses_Click(object sender, EventArgs e)
        {
            this.courseList.Items.Clear();

            var query = from c in db.Courses
                        orderby c.Department, c.CourseNum
                        select c;

            foreach(Course c in query)
            {
                this.courseList.Items.Add(c);
                this.courseList2.Items.Add(c);
            }
        }

        private void courseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayCourseInformation();
        }

        private void studentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayStudentInformation();
        }

        //Enrolls selected student into selected course
        private void Enroll_Click(object sender, EventArgs e)
        {
            Student s = (Student)this.studentList.SelectedItem;
            Course c = (Course)this.courseList.SelectedItem;

            var enrolledQuery = from en in db.Enrolleds
                                where en.CRN == c.CRN
                                select en;

            var waitingQuery = from wa in db.WaitLists
                               where wa.CRN == c.CRN
                               select wa;

            foreach(Enrolled en in enrolledQuery)
            {
                if (s.NetID == en.NetID)
                {
                    MessageBox.Show(s.NetID + " is already enrolled into this class.");
                    return;
                }
            }

            foreach(WaitList wa in waitingQuery)
            {
                if(s.NetID == wa.NetID)
                {
                    MessageBox.Show(s.NetID + " is already waiting to enroll.");
                    return;
                }
            }

            if (c.ClassSize == enrolledQuery.Count())
            {
                WaitList wa = new WaitList();
                wa.CRN = c.CRN;
                wa.NetID = s.NetID;

                db.WaitLists.InsertOnSubmit(wa);
                db.SubmitChanges();

                MessageBox.Show(s.NetID + " added to waiting list for " + c.CRN);
            }
            else
            {
                Enrolled en = new Enrolled();

                en.CRN = c.CRN;
                en.NetID = s.NetID;

                db.Enrolleds.InsertOnSubmit(en);
                db.SubmitChanges();
                MessageBox.Show(s.NetID + " enrolled into " + c.CRN);
            }

            displayStudentInformation();
            displayCourseInformation();
        }

        //Drops selected student from selected course
        private void Drop_Click(object sender, EventArgs e)
        {
            Student s = (Student)this.studentList.SelectedItem;
            Course c = (Course)this.courseList.SelectedItem;

            int timeInMS;

            if (System.Int32.TryParse(this.delayTime.Text, out timeInMS) == true)
                ;
            else
                timeInMS = 0;

            var enrolledQuery = from en in db.Enrolleds
                                where en.CRN == c.CRN
                                select en;

            var waitingQuery = from wa in db.WaitLists
                               where wa.CRN == c.CRN
                               select wa;

            var tranOptions = new System.Transactions.TransactionOptions();

            tranOptions.IsolationLevel = System.Transactions.IsolationLevel.Serializable;

            foreach(Enrolled en in enrolledQuery)
            {
                if(s.NetID == en.NetID)
                {
                    using (var tran = new System.Transactions.CommittableTransaction(tranOptions))
                    {
                        System.Threading.Thread.Sleep(timeInMS);

                        db.Enrolleds.DeleteOnSubmit(en);
                        MessageBox.Show(s.NetID + " dropped from enrollment to " + en.CRN);

                        foreach (WaitList wa in waitingQuery)
                        {
                            if (c.CRN == wa.CRN)
                            {
                                Enrolled temp = new Enrolled();
                                temp.CRN = wa.CRN;
                                temp.NetID = wa.NetID;

                                db.Enrolleds.InsertOnSubmit(temp);
                                db.WaitLists.DeleteOnSubmit(wa);
                                MessageBox.Show(temp.NetID + " was enrolled into " + temp.CRN);
                            }
                        }

                        db.SubmitChanges();
                        tran.Commit();
                        displayCourseInformation();
                        displayStudentInformation();
                        return;
                    }
                    
                }
            }
            
            foreach(WaitList wa in waitingQuery)
            {
                if(s.NetID == wa.NetID)
                {
                    db.WaitLists.DeleteOnSubmit(wa);
                    MessageBox.Show(s.NetID + " was dropped from waiting list for " + wa.CRN);
                    db.SubmitChanges();
                    displayCourseInformation();
                    displayStudentInformation();
                    return;
                }
            }
        }

        //Swaps selected students and courses
        private void Swap_Click(object sender, EventArgs e)
        {
            Student s = (Student)this.studentList.SelectedItem;
            Student s2 = (Student)this.studentList2.SelectedItem;

            Course c = (Course)this.courseList.SelectedItem;
            Course c2 = (Course)this.courseList2.SelectedItem;

            int timeInMS;

            if (System.Int32.TryParse(this.delayTime.Text, out timeInMS) == true)
                ;
            else
                timeInMS = 0;

            var student1enrolledQuery = from en in db.Enrolleds
                                        where s.NetID == en.NetID && c.CRN == en.CRN
                                        select en;

            var student2enrolledQuery = from en in db.Enrolleds
                                        where s2.NetID == en.NetID && c2.CRN == en.CRN
                                        select en;

            if(student1enrolledQuery.Count() == 0 && student2enrolledQuery.Count() == 0)
            {
                MessageBox.Show(s.NetID + " was not enrolled in " + c.CRN + " and " + s2.NetID + " was not enrolled in " + c2.CRN);
            }
            else if(student1enrolledQuery.Count() == 1 && student2enrolledQuery.Count() == 0)
            {
                MessageBox.Show(s2.NetID + " was not enrolled in " + c2.CRN);
            }
            else if(student1enrolledQuery.Count() == 0 && student2enrolledQuery.Count() == 1)
            {
                MessageBox.Show(s.NetID + " was not enrolled in " + c.CRN);
            }
            else
            {
                Enrolled temp = new Enrolled();
                Enrolled temp2 = new Enrolled();

                var tranOptions = new System.Transactions.TransactionOptions();

                tranOptions.IsolationLevel = System.Transactions.IsolationLevel.Serializable;

                using (var tran = new System.Transactions.CommittableTransaction(tranOptions))
                {
                    System.Threading.Thread.Sleep(timeInMS);

                    temp.NetID = s.NetID;
                    temp.CRN = c2.CRN;

                    foreach(Enrolled en in student1enrolledQuery)
                    {
                        if(en.NetID == s.NetID)
                        {
                            db.Enrolleds.DeleteOnSubmit(en);
                        }
                    }

                    foreach(Enrolled en in student2enrolledQuery)
                    {
                        if(en.NetID == s2.NetID)
                        {
                            db.Enrolleds.DeleteOnSubmit(en);
                        }
                    }

                    db.Enrolleds.InsertOnSubmit(temp);

                    temp2.NetID = s2.NetID;
                    temp2.CRN = c.CRN;

                    db.Enrolleds.InsertOnSubmit(temp2);

                    db.SubmitChanges();

                    tran.Commit();

                    displayCourseInformation();
                    displayStudentInformation();

                    MessageBox.Show(s.NetID + " and " + s2.NetID + " have swapped classes. ");
                }
            }


        }

        //resets database
        private void resetDatabase_Click(object sender, EventArgs e)
        {
            var deleteEnrolledQuery = from en in db.Enrolleds
                                      select en;

            var deleteWaitingQuery = from wa in db.WaitLists
                                     select wa;

            var tranOptions = new System.Transactions.TransactionOptions();

            tranOptions.IsolationLevel = System.Transactions.IsolationLevel.Serializable;

            using (var tran = new System.Transactions.CommittableTransaction(tranOptions))
            {
                foreach(Enrolled en in deleteEnrolledQuery)
                {
                    db.Enrolleds.DeleteOnSubmit(en);
                }

                foreach(WaitList wa in deleteWaitingQuery)
                {
                    db.WaitLists.DeleteOnSubmit(wa);
                }

                db.SubmitChanges();

                tran.Commit();

                displayCourseInformation();
                displayStudentInformation();

                MessageBox.Show("Database has been reset.");
            }
        }
    }
}
