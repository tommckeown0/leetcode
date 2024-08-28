public class Solution {
    public int PivotInteger(int n) {
        int runningTotal = 0;
        int sum = n * (n + 1) / 2;
        for (int i = n; i > 0; i--){            
            runningTotal += i;
            Console.WriteLine($"runningTotal = {runningTotal}, sum = {sum}, i = {i}");
            if (runningTotal == sum){
                return i;
            }
            sum -= i;
        }
        return -1;
    }

    public static void Main(string[] args){
        //Test cases
        Solution sol = new Solution();
        Console.WriteLine(sol.PivotInteger(8)); //6
        Console.WriteLine(sol.PivotInteger(1)); //1
        Console.WriteLine(sol.PivotInteger(4)); //-1
    }
}