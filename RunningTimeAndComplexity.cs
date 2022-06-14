using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < n; i++){
            int number = int.Parse(Console.ReadLine());
            isPrime(number);
        }
    }
    
    public static void isPrime(int number){
        bool isPrime = number > 1;
        for(int i = 2; i <= Math.Sqrt(number); i++){
            if (number % i == 0){
                isPrime = false;
                break;
            }
        }
        Console.WriteLine(isPrime ? "Prime" : "Not prime");
    }
}
