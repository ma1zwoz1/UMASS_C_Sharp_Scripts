using System;
using System.Collections.Generic;
using System.Collections;  // For old-style ArrayList
 
public class Lists 
{
    static void Main()
    {
 
            List<string> bookList = new List<string>();
 
            bookList.Add ("A Higher Loyalty");
            bookList.Add ("Fascism: A Warning");
            bookList.Add ("Fire and Fury");
            bookList.Add ("I'll Be Gone in the Dark");
            bookList.Add ("Killers of the Flower Moon");

 
            Console.WriteLine ("\nMy initial list of books is: ");
            foreach (string book in bookList)
            {
              Console.WriteLine ( book );
            }
 
            bookList.Remove ("A Higher Loyalty");
			bookList.Remove ("Fascism: A Warning");
            bookList.Insert (2, "An Innocent Client");
			bookList.Insert (2, "Miracle Man");
			bookList.Insert (2, "That Month in Tuscany");
 
 
            Console.WriteLine ("\nAfter removing A Higher Loyalty,Fascism A Warning and adding An Innocent Client, Miracle Man, and That Month in Tuscany my list is:");
            foreach (string book in bookList)
            {
              Console.WriteLine ( book );
            }
 
            
 
		 Console.WriteLine ("\nNow The Stack ");
         Stack bookStack = new Stack(); 
         bookStack.Push ("A Higher Loyalty"); 
         bookStack.Push ("Fascism: A Warning"); 
         bookStack.Push ("Fire and Fury"); 
         bookStack.Push ("I'll Be Gone in the Dark"); 
         bookStack.Push ("Killers of the Flower Moon"); 
         for(int i=0; i < 3 && bookStack.Count > 0; i++)
         bookStack.Pop();
		 bookStack.Push ("Miracle Man"); 
		 bookStack.Push ("That Month in Tuscany"); 
         Console.WriteLine("Contents of Zach Books ...");  

         // print all of my favorite books 
         foreach(string book in bookStack) { 
             Console.WriteLine(book); 
          } // foreach   

         
     }  // main
 
 
 
}  // public class lists

