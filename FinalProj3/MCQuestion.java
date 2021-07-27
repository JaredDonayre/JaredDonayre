/*
Jared Donayre - jdonay2
Project 2 - CS 342
MCQuestion class is going to be a class that inherits from the Question class. It creates a different type of question. More specifically it will create a multiple choice question.
This will allow for different type of questions.
*/

import java.util.*;
import java.io.*;

public abstract class MCQuestion extends Question
{
	protected Vector<Answer> answerList;
	
	
	protected MCQuestion(String mcString, double mValue)
	{
		super(mcString, mValue);
		this.rightAnswer = null;
		this.studentAnswer = null;
		answerList = new Vector<Answer>();
	}
	
	protected MCQuestion(Scanner s)
	{
		super(s);
		answerList = new Vector<Answer>();
	}
	
	public void print()
	{
		System.out.println(question);
		System.out.println();

		int position = 0;
		for(Answer a : answerList)
		{
			if(position == 0)
			{
				System.out.printf("A. ");
			}
			else if(position == 1)
			{
				System.out.printf("B. ");
			}

			else if(position == 2)
			{
				System.out.printf("C. ");
			}

			else if(position == 3)
			{
				System.out.printf("D. ");
			}

			else if(position == 4)
			{
				System.out.printf("E. ");
			}

			a.print();

			position++;
		}
	}
	
	public double getValue(MCAnswer ans)
	{
		if(studentAnswer.getCredit(ans) == 1.0)
			return studentAnswer.getCredit(ans) * maxValue;
		else
			return 0.0;
	}
	
	public void addAnswer(MCAnswer ans)
	{
		answerList.add(ans);
	}
	
	public void reorderAnswers()
	{
		Collections.shuffle(answerList);
	}
}