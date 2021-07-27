/*
Jared Donayre - jdonay2
Project 3 - CS 342
This class creates an answer object for Multiple Choice Multiple Answer questions.
*/

import java.io.*;
import java.util.*;

public class MCMAAnswer extends MCAnswer
{
	public MCMAAnswer(String ansString, double creditInput)
	{
		super(ansString, creditInput);
	}
	
	public MCMAAnswer(Scanner s)
	{
		super(s);
	}
}