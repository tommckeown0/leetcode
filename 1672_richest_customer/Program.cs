static int MaximumWealth(int[][] accounts) {
    int currentMax = 0;
    int prevMax = 0;
    for (int i = 0; i < accounts.Length; i++){
        for (int j = 0; j < accounts[i].Length; j++){
            currentMax += accounts[i][j];
        }
        if (currentMax > prevMax){
            prevMax = currentMax;
        }
        currentMax = 0;          
    }
    return prevMax;
}

//Test cases
int[][] accounts1 = new int[][] { new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 } };
int[][] accounts2 = new int[][] { new int[] { 1, 5 }, new int[] { 7, 3 }, new int[] { 3, 5 } };
int[][] accounts3 = new int[][] { new int[] { 2, 8, 7 }, new int[] { 7, 1, 3 }, new int[] { 1, 9, 5 } };
Console.WriteLine(MaximumWealth(accounts1)); //6
Console.WriteLine(MaximumWealth(accounts2)); //10
Console.WriteLine(MaximumWealth(accounts3)); //17
