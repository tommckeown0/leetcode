static IList<string> FizzBuzz(int n) {
        string[] output = new string[n];
        for (int i = 1; i <= n; i++){
            if ((i % 3 == 0) && (i % 5 == 0)){
                output[i - 1] = "FizzBuzz";
            }
            else if (i % 3 == 0){
                output[i - 1] = "Fizz";
            }
            else if (i % 5 == 0){
                output[i - 1] = "Buzz";
            }            
            else {
                output[i - 1] = i.ToString();
            }            
        }
        return output;
}

//Test case
int n = 15;
IList<string> result = FizzBuzz(n);
foreach (string item in result){
    Console.Write(item + " ");
}
//Expected output: 1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz
