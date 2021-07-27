/* 
Jared Donayre - jdonay2
Project 2 - CS 342
Exam Class deals with the Exam Object and contains methods that interact with the object
such as adding questions or printing the whole exam to the screen.
*/

import java.io.*;
import java.util.*;

public class Exam
{
 private String examTitle;
 private Vector<Question> questionList;
 
 public Exam(String examString)
 {
  examTitle = new  String(examString);
  questionList = new Vector<Question>();
 }
 
 public Exam(Scanner s)
 {
	examTitle = s.nextLine();
	questionList = new Vector<Question>();
	
	//Skips empty line
	s.nextLine();
	 
	String questionType = "Waiting";

	 while(s.hasNextLine())
	 {
		Question tempQ = null;
		
		questionType = s.nextLine();
		
		if(questionType.equalsIgnoreCase("SAQuestion"))
		{
			tempQ = new SAQuestion(s);
			questionList.add(tempQ);
		}
		else if(questionType.equalsIgnoreCase("MCMAQuestion"))
		{
			tempQ = new MCMAQuestion(s);
			questionList.add(tempQ);
		}
		else if(questionType.equalsIgnoreCase("MCSAQuestion"))
		{
			tempQ = new MCSAQuestion(s);
			questionList.add(tempQ);
		}
		
		//Skips empty line
		//s.nextLine();
		
	 }

	 
 }
 
 public void addQuestion(Question quest)
 {
  questionList.add(quest);
 }
 
 public void print()
 {
  System.out.printf("%-20s %n%n", examTitle);
  
  int position = 0;
  for(Question q : questionList)
  {
	System.out.printf((position + 1) + ". ");
	q.print();
	System.out.println();
	position++;
  }
  
  
 }
 

 public void reorderQuestions()
 {
  Collections.shuffle(questionList);
 }
 
 public void reorderMCAnswers(int position)
 {
	 if(position < 0)
	 {
		 for(Question q: questionList)
		 {
			 if(q instanceof MCQuestion)
				 ((MCQuestion)q).reorderAnswers();
			 
		 }
	 }
	 else
		 if(questionList.get(position).getClass() == MCQuestion.class)
			 ((MCQuestion)questionList.get(position)).reorderAnswers();
 }
 
 public void getAnswerFromStudent(int position)
 {
	if(position < 0)
	{
		position = 0;
		for(Question q: questionList)
		{
			System.out.printf("Question %d: %n", position + 1);
			if(q instanceof SAQuestion)
				((SAQuestion)q).getAnswerFromStudent();
			if(q instanceof MCSAQuestion)
				((MCSAQuestion)q).getAnswerFromStudent();
			if(q instanceof MCMAQuestion)
				((MCMAQuestion)q).getAnswerFromStudent();
			
			position++;
		}
	}
	else
		questionList.get(position).getAnswerFromStudent();
 }
 
 public double getValue()
 {
  double totalScore = 0.0;
  for(Question q : questionList)
  {
   totalScore = totalScore + q.getValue();
  }
  
  return totalScore;
 }
 
 public void reportQuestionValues()
 {
	 double totalScore = 0.0;
	 System.out.printf("%15s %-25s \n", "Question   |", "Score");
	 System.out.println("--------------------------------");
	 
	 int questionNumber = 0;
	 for(Question q: questionList)
	 {
		 System.out.printf("%10d", (questionNumber + 1));
		 System.out.printf("    | ");
		 System.out.printf("%-25f \n", q.getValue());
		 totalScore = totalScore + q.getValue();
		 questionNumber++;
	 }
	 
	System.out.println("--------------------------------");
	System.out.printf("%10s %-25f \n", "Total     |", totalScore);
 }
 
 public void save(PrintWriter p)
 {
	 p.println(examTitle);
	 
	 for(Question q: questionList)
	 {
		 p.println();
		 
		 if(q instanceof SAQuestion)
		 {
			p.println("SAQuestion"); 
			((SAQuestion)q).save(p);
		 }
		 
		 if(q instanceof MCSAQuestion)
		 {
			p.println("MCSAQuestion");
			((MCSAQuestion)q).save(p);			
		 }
		 
		 if(q instanceof MCMAQuestion)
		 {
			p.println("MCMAQuestion");
			((MCMAQuestion)q).save(p);			
		 }
	 }
 }
 
 public void saveStudentAnswers(PrintWriter p)
 {
	p.println("Jared Donayre");
	p.println();
	
	for(Question q: questionList)
	{
		if(q instanceof SAQuestion)
		{
			p.println("SAAnswer");
		}
		if(q instanceof MCSAQuestion)
		{
			p.println("MCSAAnswer");
		}
		if(q instanceof MCMAQuestion)
		{
			p.println("MCMAAnswer");
		}
		
		q.saveStudentAnswer(p);
		
		p.println();
	}
 }
 
 public void restoreStudentAnswers(Scanner s)
 {
	 String studentName = s.nextLine();
	 
	 System.out.printf("Student: %s%n", studentName);
	 
	 s.nextLine();
	 
	 for(Question q: questionList)
	 {
		q.restoreStudentAnswers(s);
		s.nextLine();
	 }
 }
 
}