/*
Jared Donayre - jdonay2
Project 2 - CS 342
The MCSAQuestion class deals with specifically the single answer multiple choice questions. This means
this multiple choice question has only one right answer.
*/


import java.util.*;
import java.io.*;

public class MCSAQuestion extends MCQuestion
{
	public MCSAQuestion(String mscaString, double mValue)
	{
		super(mscaString, mValue);
	}
	
	public MCSAQuestion(Scanner s)
	{
		super(s);
		
		int numberOfAnswers = s.nextInt();
		s.nextLine();
		
		Answer tempAns;
		
		while(numberOfAnswers > 0)
		{
			tempAns = new MCSAAnswer(s);
			
			if(((MCAnswer)tempAns).creditIfSelected == 1.0)
				this.rightAnswer = tempAns;
			
			this.answerList.add(tempAns);
			numberOfAnswers--;
		}
		
	}
	
	public Answer getNewAnswer()
	{
		Scanner s = ScannerFactory.getKeyboardScanner();
		
		System.out.println("Enter an answer for the question.");
		String ansInput = s.nextLine();
		MCSAAnswer ans = new MCSAAnswer(ansInput, 0.0);
		
		return ans;
	}
	
	public Answer getNewAnswer(String ansText)
	{
		MCSAAnswer ans = new MCSAAnswer(ansText, 0.0);
		
		return ans;
	}
	
	public Answer getNewAnswer(String ansText, double creditIfSelected)
	{
		MCSAAnswer ans = new MCSAAnswer(ansText, creditIfSelected);
		
		return ans;
	}
	
	public void getAnswerFromStudent()
	{
		Scanner s = ScannerFactory.getKeyboardScanner();
		
		System.out.println(this.question);
		
		System.out.println("Please enter your answer. ");
		
		String studentText = "";
		
		studentText = s.nextLine();
		
		Answer studentAns = new MCSAAnswer(studentText, 0.0);
		
		this.studentAnswer = studentAns;
	}
	
	public double getValue()
	{
		return super.getValue((MCAnswer)(this.rightAnswer));
	}
	
	public void save(PrintWriter p)
	{
		p.println(this.maxValue);
		p.println(this.question);
		p.println(this.answerList.size());
		
		for(Answer a: this.answerList)
		{
			((MCAnswer)a).save(p);
		}
	}
}