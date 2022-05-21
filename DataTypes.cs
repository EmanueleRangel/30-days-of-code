using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
      
        // Declare second integer, double, and String variables.
        int secondInteger;
        double secondDouble;
        string secondString;
        
        // Read and save an integer, double, and String to your variables.
        secondInteger = int.Parse(Console.ReadLine());
        secondDouble = double.Parse(Console.ReadLine());
        secondString = Console.ReadLine();
        
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + secondInteger);
        // Print the sum of the double variables on a new line.
        double sum = d + secondDouble;
        Console.WriteLine(sum.ToString("F1"));
        // Concatenate and print the String variables on a new line
        Console.WriteLine(s + secondString);
        // The 's' variable above should be printed first.
    }
}
