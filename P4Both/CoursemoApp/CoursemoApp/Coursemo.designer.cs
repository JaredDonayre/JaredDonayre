﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoursemoApp
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Coursemo")]
	public partial class CoursemoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCourse(Course instance);
    partial void UpdateCourse(Course instance);
    partial void DeleteCourse(Course instance);
    partial void InsertEnrolled(Enrolled instance);
    partial void UpdateEnrolled(Enrolled instance);
    partial void DeleteEnrolled(Enrolled instance);
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    partial void InsertWaitList(WaitList instance);
    partial void UpdateWaitList(WaitList instance);
    partial void DeleteWaitList(WaitList instance);
    #endregion
		
		public CoursemoDataContext() : 
				base(global::CoursemoApp.Properties.Settings.Default.CoursemoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CoursemoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CoursemoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CoursemoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CoursemoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Course> Courses
		{
			get
			{
				return this.GetTable<Course>();
			}
		}
		
		public System.Data.Linq.Table<Enrolled> Enrolleds
		{
			get
			{
				return this.GetTable<Enrolled>();
			}
		}
		
		public System.Data.Linq.Table<Student> Students
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
		
		public System.Data.Linq.Table<WaitList> WaitLists
		{
			get
			{
				return this.GetTable<WaitList>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Courses")]
	public partial class Course : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CRN;
		
		private string _Department;
		
		private int _CourseNum;
		
		private string _Semester;
		
		private short _Year;
		
		private string _Type;
		
		private string _Day;
		
		private string _Time;
		
		private short _ClassSize;
		
		private EntitySet<Enrolled> _Enrolleds;
		
		private EntitySet<WaitList> _WaitLists;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCRNChanging(int value);
    partial void OnCRNChanged();
    partial void OnDepartmentChanging(string value);
    partial void OnDepartmentChanged();
    partial void OnCourseNumChanging(int value);
    partial void OnCourseNumChanged();
    partial void OnSemesterChanging(string value);
    partial void OnSemesterChanged();
    partial void OnYearChanging(short value);
    partial void OnYearChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnDayChanging(string value);
    partial void OnDayChanged();
    partial void OnTimeChanging(string value);
    partial void OnTimeChanged();
    partial void OnClassSizeChanging(short value);
    partial void OnClassSizeChanged();
    #endregion
		
		public Course()
		{
			this._Enrolleds = new EntitySet<Enrolled>(new Action<Enrolled>(this.attach_Enrolleds), new Action<Enrolled>(this.detach_Enrolleds));
			this._WaitLists = new EntitySet<WaitList>(new Action<WaitList>(this.attach_WaitLists), new Action<WaitList>(this.detach_WaitLists));
			OnCreated();
		}

        public override string ToString()
        {
            return this.Department + " " + this.CourseNum + " : " + this.CRN;
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CRN", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CRN
		{
			get
			{
				return this._CRN;
			}
			set
			{
				if ((this._CRN != value))
				{
					this.OnCRNChanging(value);
					this.SendPropertyChanging();
					this._CRN = value;
					this.SendPropertyChanged("CRN");
					this.OnCRNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this.OnDepartmentChanging(value);
					this.SendPropertyChanging();
					this._Department = value;
					this.SendPropertyChanged("Department");
					this.OnDepartmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseNum", DbType="Int NOT NULL")]
		public int CourseNum
		{
			get
			{
				return this._CourseNum;
			}
			set
			{
				if ((this._CourseNum != value))
				{
					this.OnCourseNumChanging(value);
					this.SendPropertyChanging();
					this._CourseNum = value;
					this.SendPropertyChanged("CourseNum");
					this.OnCourseNumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Semester", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string Semester
		{
			get
			{
				return this._Semester;
			}
			set
			{
				if ((this._Semester != value))
				{
					this.OnSemesterChanging(value);
					this.SendPropertyChanging();
					this._Semester = value;
					this.SendPropertyChanged("Semester");
					this.OnSemesterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="SmallInt NOT NULL")]
		public short Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Day", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string Day
		{
			get
			{
				return this._Day;
			}
			set
			{
				if ((this._Day != value))
				{
					this.OnDayChanging(value);
					this.SendPropertyChanging();
					this._Day = value;
					this.SendPropertyChanged("Day");
					this.OnDayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string Time
		{
			get
			{
				return this._Time;
			}
			set
			{
				if ((this._Time != value))
				{
					this.OnTimeChanging(value);
					this.SendPropertyChanging();
					this._Time = value;
					this.SendPropertyChanged("Time");
					this.OnTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClassSize", DbType="SmallInt NOT NULL")]
		public short ClassSize
		{
			get
			{
				return this._ClassSize;
			}
			set
			{
				if ((this._ClassSize != value))
				{
					this.OnClassSizeChanging(value);
					this.SendPropertyChanging();
					this._ClassSize = value;
					this.SendPropertyChanged("ClassSize");
					this.OnClassSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_Enrolled", Storage="_Enrolleds", ThisKey="CRN", OtherKey="CRN")]
		public EntitySet<Enrolled> Enrolleds
		{
			get
			{
				return this._Enrolleds;
			}
			set
			{
				this._Enrolleds.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_WaitList", Storage="_WaitLists", ThisKey="CRN", OtherKey="CRN")]
		public EntitySet<WaitList> WaitLists
		{
			get
			{
				return this._WaitLists;
			}
			set
			{
				this._WaitLists.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Enrolleds(Enrolled entity)
		{
			this.SendPropertyChanging();
			entity.Course = this;
		}
		
		private void detach_Enrolleds(Enrolled entity)
		{
			this.SendPropertyChanging();
			entity.Course = null;
		}
		
		private void attach_WaitLists(WaitList entity)
		{
			this.SendPropertyChanging();
			entity.Course = this;
		}
		
		private void detach_WaitLists(WaitList entity)
		{
			this.SendPropertyChanging();
			entity.Course = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Enrolled")]
	public partial class Enrolled : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CRN;
		
		private string _NetID;
		
		private EntityRef<Course> _Course;
		
		private EntityRef<Student> _Student;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCRNChanging(int value);
    partial void OnCRNChanged();
    partial void OnNetIDChanging(string value);
    partial void OnNetIDChanged();
    #endregion
		
		public Enrolled()
		{
			this._Course = default(EntityRef<Course>);
			this._Student = default(EntityRef<Student>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CRN", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CRN
		{
			get
			{
				return this._CRN;
			}
			set
			{
				if ((this._CRN != value))
				{
					if (this._Course.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCRNChanging(value);
					this.SendPropertyChanging();
					this._CRN = value;
					this.SendPropertyChanged("CRN");
					this.OnCRNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NetID", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string NetID
		{
			get
			{
				return this._NetID;
			}
			set
			{
				if ((this._NetID != value))
				{
					if (this._Student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNetIDChanging(value);
					this.SendPropertyChanging();
					this._NetID = value;
					this.SendPropertyChanged("NetID");
					this.OnNetIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_Enrolled", Storage="_Course", ThisKey="CRN", OtherKey="CRN", IsForeignKey=true)]
		public Course Course
		{
			get
			{
				return this._Course.Entity;
			}
			set
			{
				Course previousValue = this._Course.Entity;
				if (((previousValue != value) 
							|| (this._Course.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Course.Entity = null;
						previousValue.Enrolleds.Remove(this);
					}
					this._Course.Entity = value;
					if ((value != null))
					{
						value.Enrolleds.Add(this);
						this._CRN = value.CRN;
					}
					else
					{
						this._CRN = default(int);
					}
					this.SendPropertyChanged("Course");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Enrolled", Storage="_Student", ThisKey="NetID", OtherKey="NetID", IsForeignKey=true)]
		public Student Student
		{
			get
			{
				return this._Student.Entity;
			}
			set
			{
				Student previousValue = this._Student.Entity;
				if (((previousValue != value) 
							|| (this._Student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Student.Entity = null;
						previousValue.Enrolleds.Remove(this);
					}
					this._Student.Entity = value;
					if ((value != null))
					{
						value.Enrolleds.Add(this);
						this._NetID = value.NetID;
					}
					else
					{
						this._NetID = default(string);
					}
					this.SendPropertyChanged("Student");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Students")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _NetID;
		
		private string _StudFName;
		
		private string _StudLName;
		
		private EntitySet<Enrolled> _Enrolleds;
		
		private EntitySet<WaitList> _WaitLists;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNetIDChanging(string value);
    partial void OnNetIDChanged();
    partial void OnStudFNameChanging(string value);
    partial void OnStudFNameChanged();
    partial void OnStudLNameChanging(string value);
    partial void OnStudLNameChanged();
    #endregion
		
		public Student()
		{
			this._Enrolleds = new EntitySet<Enrolled>(new Action<Enrolled>(this.attach_Enrolleds), new Action<Enrolled>(this.detach_Enrolleds));
			this._WaitLists = new EntitySet<WaitList>(new Action<WaitList>(this.attach_WaitLists), new Action<WaitList>(this.detach_WaitLists));
			OnCreated();
		}

        public override string ToString()
        {
            return this.StudLName + "," + this.StudFName + " : " + this.NetID;
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NetID", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string NetID
		{
			get
			{
				return this._NetID;
			}
			set
			{
				if ((this._NetID != value))
				{
					this.OnNetIDChanging(value);
					this.SendPropertyChanging();
					this._NetID = value;
					this.SendPropertyChanged("NetID");
					this.OnNetIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudFName", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string StudFName
		{
			get
			{
				return this._StudFName;
			}
			set
			{
				if ((this._StudFName != value))
				{
					this.OnStudFNameChanging(value);
					this.SendPropertyChanging();
					this._StudFName = value;
					this.SendPropertyChanged("StudFName");
					this.OnStudFNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudLName", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string StudLName
		{
			get
			{
				return this._StudLName;
			}
			set
			{
				if ((this._StudLName != value))
				{
					this.OnStudLNameChanging(value);
					this.SendPropertyChanging();
					this._StudLName = value;
					this.SendPropertyChanged("StudLName");
					this.OnStudLNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Enrolled", Storage="_Enrolleds", ThisKey="NetID", OtherKey="NetID")]
		public EntitySet<Enrolled> Enrolleds
		{
			get
			{
				return this._Enrolleds;
			}
			set
			{
				this._Enrolleds.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_WaitList", Storage="_WaitLists", ThisKey="NetID", OtherKey="NetID")]
		public EntitySet<WaitList> WaitLists
		{
			get
			{
				return this._WaitLists;
			}
			set
			{
				this._WaitLists.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Enrolleds(Enrolled entity)
		{
			this.SendPropertyChanging();
			entity.Student = this;
		}
		
		private void detach_Enrolleds(Enrolled entity)
		{
			this.SendPropertyChanging();
			entity.Student = null;
		}
		
		private void attach_WaitLists(WaitList entity)
		{
			this.SendPropertyChanging();
			entity.Student = this;
		}
		
		private void detach_WaitLists(WaitList entity)
		{
			this.SendPropertyChanging();
			entity.Student = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.WaitList")]
	public partial class WaitList : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CRN;
		
		private string _NetID;
		
		private EntityRef<Course> _Course;
		
		private EntityRef<Student> _Student;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCRNChanging(int value);
    partial void OnCRNChanged();
    partial void OnNetIDChanging(string value);
    partial void OnNetIDChanged();
    #endregion
		
		public WaitList()
		{
			this._Course = default(EntityRef<Course>);
			this._Student = default(EntityRef<Student>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CRN", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CRN
		{
			get
			{
				return this._CRN;
			}
			set
			{
				if ((this._CRN != value))
				{
					if (this._Course.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCRNChanging(value);
					this.SendPropertyChanging();
					this._CRN = value;
					this.SendPropertyChanged("CRN");
					this.OnCRNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NetID", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string NetID
		{
			get
			{
				return this._NetID;
			}
			set
			{
				if ((this._NetID != value))
				{
					if (this._Student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNetIDChanging(value);
					this.SendPropertyChanging();
					this._NetID = value;
					this.SendPropertyChanged("NetID");
					this.OnNetIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_WaitList", Storage="_Course", ThisKey="CRN", OtherKey="CRN", IsForeignKey=true)]
		public Course Course
		{
			get
			{
				return this._Course.Entity;
			}
			set
			{
				Course previousValue = this._Course.Entity;
				if (((previousValue != value) 
							|| (this._Course.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Course.Entity = null;
						previousValue.WaitLists.Remove(this);
					}
					this._Course.Entity = value;
					if ((value != null))
					{
						value.WaitLists.Add(this);
						this._CRN = value.CRN;
					}
					else
					{
						this._CRN = default(int);
					}
					this.SendPropertyChanged("Course");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_WaitList", Storage="_Student", ThisKey="NetID", OtherKey="NetID", IsForeignKey=true)]
		public Student Student
		{
			get
			{
				return this._Student.Entity;
			}
			set
			{
				Student previousValue = this._Student.Entity;
				if (((previousValue != value) 
							|| (this._Student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Student.Entity = null;
						previousValue.WaitLists.Remove(this);
					}
					this._Student.Entity = value;
					if ((value != null))
					{
						value.WaitLists.Add(this);
						this._NetID = value.NetID;
					}
					else
					{
						this._NetID = default(string);
					}
					this.SendPropertyChanged("Student");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
