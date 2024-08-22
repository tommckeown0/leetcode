static int NumberOfSteps(int num) {
        int count = 0;
        while (num > 0){
            if (num % 2 == 0){
                num /= 2;
                count++;
            }
            else if (num % 2 == 1){
                num--;
                count++;
            }
        }
        return count;
}

//Test cases
int num1 = 14;
int num2 = 8;
int num3 = 123;
Console.WriteLine(NumberOfSteps(num1)); //6
Console.WriteLine(NumberOfSteps(num2)); //4
Console.WriteLine(NumberOfSteps(num3)); //12
