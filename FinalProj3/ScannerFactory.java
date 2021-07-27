/*
Jared Donayre - jdonay2
Project 3 - CS 342
This class allows other classes to access a Scanner that can take in someone's input for questions and answers.
*/


import java.util.*;

public class ScannerFactory
{
	private static Scanner keyboardScanner = new Scanner(System.in);
	
	public static Scanner getKeyboardScanner()
	{
		return keyboardScanner;
	}
	
}