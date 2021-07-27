/* 
Jared Donayre - jdonay2
Project 2 - CS 342
Answer class deals with the answers of the questions. Questions in the Exam class.
*/

import java.io.*;
import java.util.*;

public abstract class Answer
{
 protected Answer()
 {
	 
 }
 
 public Answer(Scanner s)
 {
	 
 }
 
 abstract public void print();
 abstract public double getCredit(Answer rightAnswer);
 abstract public void save(PrintWriter p);
}