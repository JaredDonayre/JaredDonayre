--
-- SQL DDL to create Coursemo database
--
-- Jared Donayre
-- jdonay2
-- University of Illinois at Chicago
-- CS 480, Summer 2018, Professor Hummel
-- Project 4
--

CREATE TABLE Students (
	NetID		NVARCHAR(128) PRIMARY KEY,
	StudFName	NVARCHAR(128) NOT NULL,
	StudLName	NVARCHAR(128) NOT NULL
);

CREATE TABLE Courses (
	CRN		INT PRIMARY KEY,
	Department	NVARCHAR(128) NOT NULL,
	CourseNum	INT NOT NULL,
	Semester	NVARCHAR(128) NOT NULL,
	Year		SMALLINT NOT NULL,
	Type		NVARCHAR(128) NOT NULL,
	Day		NVARCHAR(128) NOT NULL,
	Time		NVARCHAR(128) NOT NULL,
	ClassSize	SMALLINT NOT NULL
);

CREATE TABLE Enrolled (
	CRN		INT FOREIGN KEY REFERENCES Courses(CRN) NOT NULL,
	NetID		NVARCHAR(128) FOREIGN KEY REFERENCES Students(NetID) NOT NULL,
	PRIMARY KEY (CRN, NetID)
);

CREATE TABLE WaitList (
	CRN		INT FOREIGN KEY REFERENCES Courses(CRN) NOT NULL,
	NetID		NVARCHAR(128) FOREIGN KEY REFERENCES Students(NetID) NOT NULL
	PRIMARY KEY (CRN, NetID)
);



	