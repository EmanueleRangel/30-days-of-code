using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        
        for (int i = 0 ; i < n; i++){
            string[] fields = Console.ReadLine().Split(' ');
            string name = fields[0];
            string phone = fields[1];
            
            phoneBook.Add(name, phone);
        }
        
        string queryName;
        while((queryName = Console.ReadLine()) != null){
            if(phoneBook.ContainsKey(queryName)){
                Console.WriteLine(queryName +"="+ phoneBook[queryName]);
            } else {
                Console.WriteLine("Not found");
            }
        }
    }
}
