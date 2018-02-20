//The ToString(…) Method 
//The method ToString(…)  is called automatically when we print objects from 
//different classes to the console. For example, when printing dates  the 
//submitted date is converted to text by calling the ToString(…): 
DateTime currentDate = DateTime.Now; 
Console.WriteLine(currentDate); 
// Output: 01.02.2012 13:34:27 (depends on the culture settings) 
//In fact, the sample code above is equivalent to the following: 
DateTime currentDate = DateTime.Now; 
Console.WriteLine(currentDate.ToString()); 
//Using of String.Format(…)
DateTime date = DateTime.Now; 
string name = "David Scott"; 
string task = "Introduction to C# book"; 
string location = "his office"; 
 
string formattedText = String.Format( 
  "Today is {0:MM/dd/yyyy} and {1} is working on {2} in {3}.",
  date, name, task, location); 
Console.WriteLine(formattedText); 
 
// Output: Today is 01.02.2012 and David Scott is working on 
// Introduction to C# book in his office. 
