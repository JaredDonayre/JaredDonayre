/* 
Jared Donayre - jdonay2
Project 3 - CS 342
ExamTester class sets up an exam and tests out the methods of the Answer, Question and Exam class created.

NOTE: Was not able to get the printing of the grade done correctly.
 */

 import java.io.*;
 import java.util.*;

public class ExamTester
{
 
 public static void main (String[] args) throws FileNotFoundException
 {
	 System.out.println("Name: Jared Donayre");
	 System.out.println("NetID: jdonay2");
	 System.out.println();
	 
	 File file = new File("RandomFruitExam.txt");
	 
	 file.exists();
	 
	 Scanner ExamScanner = new Scanner(file);
	 
	 Exam startExam = new Exam(ExamScanner); 
	
	 startExam.reorderQuestions(); 
	 startExam.reorderMCAnswers(-1);
	 
	 startExam.print();
	 
	 File newExam = new File("NewExamFile.txt");
	 
	 PrintWriter p = new PrintWriter(newExam);
	 
	 startExam.save(p);
	 
	 p.close();
	 
	 startExam.getAnswerFromStudent(-1);
	 
	 File studentAnswers = new File("studentAns.txt");
	 
	 PrintWriter p2 = new PrintWriter(studentAnswers);
	 
	 startExam.saveStudentAnswers(p2);
	 
	 p2.close();
	 
	 startExam = null;
	 
	 Scanner ExamScanner2 = new Scanner(newExam);
	 
	 newExam.exists();
	 
	 Exam revisedExam = new Exam(ExamScanner2);
	 
	 Scanner ansScanner = new Scanner(studentAnswers);
	 
	 revisedExam.restoreStudentAnswers(ansScanner);
	 
	 revisedExam.reportQuestionValues();
	 
 }

}