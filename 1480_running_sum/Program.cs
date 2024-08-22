static int[] RunningSum(int[] nums) {
    int[] output = new int[nums.Length];
    int runningTotal = 0;
    for (int i = 0; i < nums.Length; i++){
        output[i] = nums[i] + runningTotal;   
        runningTotal += nums[i];   
    }
    for (int i = 0; i < output.Length; i++){
        Console.Write(output[i] + " ");
    }
    return output;
}

//Test cases
int[] nums1 = { 1, 2, 3, 4 };
int[] nums2 = { 1, 1, 1, 1, 1 };
int[] nums3 = { 3, 1, 2, 10, 1 };
RunningSum(nums1);
RunningSum(nums2);
RunningSum(nums3);
