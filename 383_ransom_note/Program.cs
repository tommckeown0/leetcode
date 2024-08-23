public class Solution {
    public void DisplayDict(Dictionary<char, int> dict){
        foreach( KeyValuePair<char, int> kvp in dict )
        {
            Console.WriteLine("Key = {0}, Value = {1}",
                kvp.Key, kvp.Value);
        }
    }
    public bool CanConstruct(string ransomNote, string magazine) {
        bool canConstruct = true;
        Dictionary<char, int> charCountDict = new Dictionary<char, int>();        
        for (int i = 0; i < magazine.Length; i++){
            if (charCountDict.ContainsKey(magazine[i])){
                charCountDict[magazine[i]]++;
            }
            else {
                charCountDict.Add(magazine[i], 1);
            }
        }
        for (int i = 0; i < ransomNote.Length; i++){
            if (charCountDict.ContainsKey(ransomNote[i])){
                if (charCountDict[ransomNote[i]] > 0){
                    charCountDict[ransomNote[i]]--;
                    Console.WriteLine("char found and subtracted");
                    DisplayDict(charCountDict);              
                }
                else {
                    canConstruct = false;
                }
            }
            else{
                canConstruct = false;
            }
        }
        return canConstruct;
    }

    public static void Main(string[] args){
        //Test cases
        Solution sol = new Solution();
        Console.WriteLine(sol.CanConstruct("a", "b")); //false
        Console.WriteLine(sol.CanConstruct("aa", "ab")); //false
        Console.WriteLine(sol.CanConstruct("aa", "aab")); //true        
    }
}