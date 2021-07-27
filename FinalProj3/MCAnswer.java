/*
Jared Donayre - jdonay2
Project 2 - CS 342
The MCAnswer class deals with the answer objects for Multiple choice answer objects. Creates general methods/variables shared by multiple choice answer objects.
*/

import java.util.*;
import java.io.*;

public abstract class MCAnswer extends Answer
{
	protected String mcAString;
	protected double creditIfSelected;
	
	protected MCAnswer(String ansString, double creditInput)
	{
		mcAString = ansString;
		creditIfSelected = creditInput;
	}
	
	public MCAnswer(Scanner s)
	{
		creditIfSelected = s.nextDouble();
		mcAString = s.nextLine();
		mcAString.trim();
	}
	
	public void print()
	{
		System.out.println(mcAString);
	}
	
	public double getCredit(Answer rightAns)
	{
		if(mcAString.equalsIgnoreCase(((MCAnswer)rightAns).mcAString))
			return ((MCAnswer)rightAns).creditIfSelected;
		else
			return 0.0;
	}
	
	public void save(PrintWriter p)
	{
		p.print(creditIfSelected);
		p.print(" ");
		p.print(mcAString);
		p.print("\n");
	}
}