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
//Switching to Uppercase and Lowercase Letters 
string text = "All Kind OF LeTTeRs"; 
Console.WriteLine(text.ToLower()); 
Console.WriteLine(text.ToUpper()); 
//Searching with IndexOf(…)
string str = "C# Programming Course"; 
int index = str.IndexOf("C#"); // index = 0 
index = str.IndexOf("Course"); // index = 15 
index = str.IndexOf("COURSE"); // index = -1 
index = str.IndexOf("ram");    // index = 7 
index = str.IndexOf("r");      // index = 4 
index = str.IndexOf("r", 5);   // index = 7 
index = str.IndexOf("r", 10);  // index = 18 
//Finding All Occurrences of a Substring 
string quote = "The main intent of the \"Intro C#\"" + " book is to introduce the C# programming to newbies."; 
string keyword = "C#"; 
int index = quote.IndexOf(keyword); 
while (index != -1) 
{ 
  Console.WriteLine("{0} found at index: {1}", keyword, index); 
  index = quote.IndexOf(keyword, index + 1); 
} 
//Extracting a Portion of a String 
string path = "C:\\Pics\\CoolPic.jpg"; 
string fileName = path.Substring(8, 7); // fileName = "CoolPic" 
//Extracting a File Name and File Extension
string path = "C:\\Pics\\CoolPic.jpg"; 
int index = path.LastIndexOf("\\"); // index = 7 
string fullName = path.Substring(index + 1); // fullName = "CoolPic.jpg" 
//Splitting the String by a Separator 
string listOfBeers = "Amstel, Heineken, Tuborg, Becks";
//Splitting Strings by Multiple Separators
char[] separators = new char[] {' ', ',', '.'}; 
string[] beersArr = listOfBeers.Split(separators);
//How to Remove the Empty Elements after Splitting
foreach (string beer in beersArr) 
{ 
  if (beer != "") 
  { 
    Console.WriteLine(beer); 
  } 
} 
//*************replacing a substring with another
string doc = "Hello, some@gmail.com, " + "you have been using some@gmail.com in your registration."; 
string fixedDoc = doc.Replace("some@gmail.com", "john@smith.com"); 
Console.WriteLine(fixedDoc); 
 
// Console output: 
// Hello, john@smith.com, you have been using 
// john@smith.com in your registration. 
//*************Removing Unnecessary Characters at the Beginningand at the End of a String 
string fileData = "   \n\n     David Allen      "; 
string reduced = fileData.Trim();
//Removing Unnecessary Characters by a Given List 
string fileData = "   111 $  %    David Allen  ### s   "; 
char[] trimChars = new char[] {' ', '1', '$', '%', '#', 's'}; 
string reduced = fileData.Trim(trimChars); // reduced = "David Allen" 
string reduced = fileData.TrimEnd(trimChars); // reduced = "   111 $  %    David Allen" 

