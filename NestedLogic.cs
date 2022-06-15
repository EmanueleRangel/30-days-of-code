using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var returnedDate = Console.ReadLine().Split(" ");
        var returnedDay = int.Parse(returnedDate[0]);
        var returnedMonth= int.Parse(returnedDate[1]);
        var returnedYear = int.Parse(returnedDate[2]);
        
        var dueDate = Console.ReadLine().Split(" ");
        var dueDay = int.Parse(dueDate[0]);
        var dueMonth = int.Parse(dueDate[1]);
        var dueYear = int.Parse(dueDate[2]);
        
        var fine = 0;
        if (returnedYear > dueYear){
            fine = 10000;
        }
        else if (dueYear == returnedYear) {
            if(returnedMonth > dueMonth){
                fine = 500 * (returnedMonth - dueMonth);
            }
            else if (returnedMonth == dueMonth && returnedDay > dueDay){
                fine = 15 * (returnedDay - dueDay);
            }
        }
       
        Console.WriteLine(fine);
    }
}
