//**********Comparison for Equality 
string word1 = "C#"; 
string word2 = "c#"; 
Console.WriteLine(word1.Equals("C#")); 
Console.WriteLine(word1.Equals(word2)); 
Console.WriteLine(word1 == "C#"); 
Console.WriteLine(word1 == word2); 
// Console output: 
// True 
// False 
// True 
// False 
//*********Comparing Strings in Alphabetical Order 
//Ex1:
string score = "sCore"; 
string scary = "scary"; 
 
Console.WriteLine(score.CompareTo(scary)); 
Console.WriteLine(scary.CompareTo(score)); 
Console.WriteLine(scary.CompareTo(scary)); 
 
// Console output: 
// 1 
// -1 
// 0 
// Ex2:
string alpha = "alpha"; 
string score1 = "sCorE"; 
string score2 = "score"; 
 
Console.WriteLine(string.Compare(alpha, score1, false)); 
Console.WriteLine(string.Compare(score1, score2, false)); 
Console.WriteLine(string.Compare(score1, score2, true)); 
Console.WriteLine(string.Compare(score1, score2, 
  StringComparison.CurrentCultureIgnoreCase)); 
// Console output: 
// -1 
// 1 
// 0 
// 0 
//**********The == and != Operators 
string str1 = "Hello"; 
string str2 = str1; 
 
Console.WriteLine(str1 == str2); 
// Console output: 
// True 
//*************Strings Concatenation 
string greet = "Hello, "; 
string name = "reader!"; 
string result1 = string.Concat(greet, name); 
string result2 = greet + name; 
result3 = result3 + " How are you?"; 
result4 += " How are you?"; 
//*****concatenate other data  with  strings
string message = "The number of the beast is: "; 
int beastNum = 666; 
string result = message + beastNum; 
// The number of the beast is: 666 
