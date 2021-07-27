/* 
Jared Donayre - jdonay2
Project 2 - CS 342
Question Class deals with the Question object that is contained in an exam. 
This class contains methods that lets the user interact with Question objects.
*/

import java.io.*;
import java.util.*;

public abstract class Question
{
/*
 private String question;
 private Vector<Answer> answerList;
 */
 
 protected String question;
 protected Answer rightAnswer;
 protected Answer studentAnswer;
 protected double maxValue;
 
 protected Question(String questionString, double mValue)
 {
	question = new String(questionString);
	maxValue = mValue;
 }
 
 public Question(Scanner s)
 {
	 maxValue = s.nextDouble();
	 s.nextLine();
	 question = (s.nextLine()).trim();
	 rightAnswer = null;
	 studentAnswer = null;
 } 
 
 public void print()
 {
	System.out.printf(question);
	System.out.println();
 }
 
 public void setRightAnswer(Answer ans)
 {
	 rightAnswer = ans;
 }
 
 public void saveStudentAnswer(PrintWriter p)
 {
	 String studentText = "";
	 if(studentAnswer instanceof MCAnswer)
	 {
		studentText = ((MCAnswer)studentAnswer).mcAString;
	 }
	 if(studentAnswer instanceof SAAnswer)
	 {
		studentText = ((SAAnswer)studentAnswer).saString; 
	 }
	 
	 p.println(studentText);
 }
 
 public void restoreStudentAnswers(Scanner s)
 {
	 String ansType = s.nextLine();
	 if(ansType.equals("SAAnswer"))
	 {
		 Answer tempAns = new SAAnswer(s);
		 studentAnswer = tempAns;
	 }
	 if(ansType.equals("MCSAAnswer"))
	 {
		 String ansText = s.nextLine();
		 Answer tempAns = new MCSAAnswer(ansText, 0.0);
		 studentAnswer = tempAns;
	 }
 }
 
 abstract public Answer getNewAnswer();
 abstract public void getAnswerFromStudent();
 abstract public double getValue();
 abstract public void save(PrintWriter p);
 
 
}