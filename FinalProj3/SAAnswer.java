/*
Jared Donayre - jdonay2
Project 2 - CS 342
The SAAnswer class deals with the answer object for Short Answer questions.
*/

import java.io.*;
import java.util.*;

public class SAAnswer extends Answer
{
	protected String saString;
	
	public SAAnswer(String ansString)
	{
		saString = ansString;
	}
	
	public SAAnswer(Scanner s)
	{	
		saString = s.nextLine();
		saString.trim();
	}
	
	public void print()
	{
		System.out.printf(saString);
	}
	
	public double getCredit(Answer rightAnswer)
	{
		if(saString.equalsIgnoreCase(((SAAnswer)rightAnswer).saString))
			return 1.0;
		else
			return 0.0;
	}
	
	public void save(PrintWriter p)
	{
		p.println(saString);
	}
}