/*
Jared Donayre - jdonay2
Project 2 - CS 342
SAQuestion class is a child of the Question class. This class deals specifically with questions that are short answer. 
*/

import java.util.*;
import java.io.*;

public class SAQuestion extends Question
{
	public SAQuestion(String saString, double mValue)
	{
		super(saString, mValue);
		this.rightAnswer = null;
		this.studentAnswer = null;
	}
	
	public SAQuestion(Scanner s)
	{
		super(s);
		this.rightAnswer = new SAAnswer(s);
		this.studentAnswer = null;
	}
	
	public Answer getNewAnswer()
	{
		Scanner s = ScannerFactory.getKeyboardScanner();
		
		System.out.println("Enter an answer for the question.");
		String ansInput = s.nextLine();
		SAAnswer ans = new SAAnswer(ansInput);
		
		
		return ans;
	}
	
	public Answer getNewAnswer(String ansText)
	{
		SAAnswer ans = new SAAnswer(ansText);
		
		return ans;
	}
	
	public void getAnswerFromStudent()
	{
		Scanner s = ScannerFactory.getKeyboardScanner();
		
		System.out.println(this.question);
		
		System.out.println("Please enter your answer. ");
		
		String studentText = "";
		
		studentText = s.nextLine();

		Answer studentAns = new SAAnswer(studentText);
		
		this.studentAnswer = studentAns;
	}
	
	public double getValue()
	{
		if(studentAnswer.getCredit(rightAnswer) == 1.0)
			return studentAnswer.getCredit(rightAnswer) * maxValue;
		else
			return 0.0;
	}
	
	public void save(PrintWriter p)
	{
		p.println(this.maxValue);
		p.println(this.question);
		p.println(((SAAnswer)this.rightAnswer).saString);
	}
	
}