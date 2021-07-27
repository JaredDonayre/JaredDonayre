

import java.io.*;
import java.util.*;

public class MCMAQuestion extends MCQuestion
{
	
	protected Vector<Answer> studentAnswer;
	public double baseCredit;
	
	public MCMAQuestion(String mcmaString, double maxVal, double baseCred)
	{
		super(mcmaString, maxVal);
		baseCredit = baseCred;
		studentAnswer = new Vector<Answer>();
	}
	
	public MCMAQuestion(Scanner s)
	{
		super(s);
		baseCredit = s.nextDouble();
		studentAnswer = new Vector<Answer>();
		
		s.nextLine();
		
		int numberOfAnswers = s.nextInt();
		
		s.nextLine();
		
		while(numberOfAnswers > 0)
		{
			Answer tempAns = new MCMAAnswer(s);
			this.answerList.add(tempAns);
			numberOfAnswers--;
		}
	}
	
	public Answer getNewAnswer()
	{
		Scanner s = ScannerFactory.getKeyboardScanner();

		System.out.println("Enter an answer for the question.");
		String ansInput = s.nextLine();
		MCMAAnswer ans = new MCMAAnswer(ansInput, 0.0);

		return ans;
	}
	
	public Answer getNewAnswer(String ansText, double creditIfSel)
	{
		MCMAAnswer ans = new MCMAAnswer(ansText, creditIfSel);
		
		return ans;
	}
	
	public void getAnswerFromStudent()
	{
		Scanner s = ScannerFactory.getKeyboardScanner();
		
		System.out.println(this.question);
		
		System.out.println("Enter number of answers you want to choose: ");
		
		int numberOfAnswers = s.nextInt();
		s.nextLine();
		
		while(numberOfAnswers > 0)
		{
			System.out.println("Please enter your answer. ");
		
			String studentText = "";
		
			studentText = s.nextLine();
		
			Answer studentAns = new MCMAAnswer(studentText, 0.0);
		
			studentAnswer.add(studentAns);
			
			numberOfAnswers--;
		}
		
	}
	
	public double getValue()
	{
		double totalEarned = baseCredit;
		
		for(Answer a: studentAnswer)
		{
			System.out.println(((MCAnswer)a).mcAString);
			for(Answer r: this.answerList)
			{
				totalEarned = totalEarned + ((MCAnswer)a).getCredit(r);
			}
		}
		
		return baseCredit + totalEarned;
	}
	
	public void save(PrintWriter p)
	{
		p.println(this.maxValue);
		p.println(this.question);
		p.println(baseCredit);
		p.println(this.answerList.size());
		
		for(Answer a: this.answerList)
		{
			a.save(p);
		}
	}
	
	public void saveStudentAnswer(PrintWriter p)
	{
		p.println(studentAnswer.size());
		
		for(Answer a: studentAnswer)
		{
			String studentText = ((MCAnswer)a).mcAString;
			p.println(studentText);
		}
	}
	
	public void restoreStudentAnswer(Scanner s)
	{
		String ansType = s.nextLine();
		
		if(ansType.equals("MCMAAnswer"))
		{
			int numberOfAnswers = s.nextInt();
			s.nextLine();
			
			while(numberOfAnswers > 0)
			{
				String ansText = s.nextLine();
				Answer tempAns = new MCMAAnswer(ansText, 0.0);
				studentAnswer.add(tempAns);
				
				numberOfAnswers--;
			}
			
		}
	}
	
}