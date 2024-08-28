public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int firstNum = 0;
        int secondNum = 0;
        int[] sumValues = new int[2];
        for (int i = 0;i < nums.Length; i++){
            firstNum = nums[i];
            Console.WriteLine("nums[i] = " + nums[i]);
            for (int j = 0; j < nums.Length; j++){
                if (j == i){
                    continue;
                }
                secondNum = nums[j];
                Console.WriteLine("nums[j] = " + nums[j]);
                if (firstNum + secondNum == target){
                    Console.WriteLine("index of sum values = " + i + j);
                    sumValues[0] = i;
                    sumValues[1] = j;
                }
            }
        }
        return sumValues;
    }

    public static void Main(string[] args){
        //Test cases
        Solution sol = new Solution();
        int[] nums = {2, 7, 11, 15};
        int target = 9;
        int[] result = sol.TwoSum(nums, target);
        Console.WriteLine("[" + result[0] + ", " + result[1] + "]");
    }
}