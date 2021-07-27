/*
Jared Donayre - jdonay2
Project 2 - CS 342
The MCSAAnswer class deals with the single answer object for multiple choice questions with only one right answer.
*/

import java.io.*;
import java.util.*;

public class MCSAAnswer extends MCAnswer
{
	public MCSAAnswer(String ansString, double creditInput)
	{
		super(ansString, creditInput);
	}
	
	public MCSAAnswer(Scanner s)
	{
		super(s);
	}
}