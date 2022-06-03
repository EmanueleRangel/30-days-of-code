using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;

	// Add your code here
    public Difference (int[] _elements){
        this.elements = _elements;
    }
    
    public void computeDifference (){
        int max = 0;
        
        for (int i = 0; i < elements.Length; i++){
            for (int j= 0; j < elements.Length; j++){
                int absolute = Math.Abs(elements[i] - elements[j]);
                if (absolute > max) max = absolute;
            }
        }
        maximumDifference = max;
    }

} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}
