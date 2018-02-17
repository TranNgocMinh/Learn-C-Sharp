//********declaring a string**********
string str; 
string greeting = "Hello, C#"; 
string source = "Some source"; 
string assigned = source; 
//*********Strings and Char Arrays****** 
string str = "abcde"; 
char ch = str[1]; // ch == 'b' 
str[1] = 'a'; // Compilation error! 
ch = str[50]; // IndexOutOfRangeException
//******an example for using variables from the type string
string message = "This is a sample string message."; 
Console.WriteLine("message = {0}", message); 
Console.WriteLine("message.Length = {0}", message.Length); 
for (int i = 0; i < message.Length; i++) 
{ 
  Console.WriteLine("message[{0}] = {1}", i, message[i]); 
} 
// Console output: 
// message = This is a sample string message. 
// message.Length = 31 
// message[0] = T 
// message[1] = h 
// message[2] = i 
// message[3] = s 
//*******************Strings Escaping 
string quote = "Book's title is \"Intro to C#\""; 
// Book's title is "Intro to C#" 
//**************Passing a String Expression 
string email = "some@gmail.com"; 
string info = "My mail is: " + email; 
// My mail is: some@gmail.com 
//**************Reading Strings 
string name = Console.ReadLine();
//***********Printing Strings 
Console.WriteLine("Your name is: " + name); 
