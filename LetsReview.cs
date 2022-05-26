using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string s;
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++){
            s = Console.ReadLine();
            MyFunction(s);
        }
    }
    
    public static void MyFunction (string s) {
        for(int i = 0; i < s.Length; i++) {
            if (i % 2 ==0) {
                Console.Write(s[i]);
            }
        }
        Console.Write(" ");
        
        for(int i = 0; i < s.Length; i++){
            if(i % 2 != 0) {
                Console.Write(s[i]);
            }
        }
        Console.WriteLine();
    }
}
