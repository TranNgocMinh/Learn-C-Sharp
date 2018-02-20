class ElegantNumbersConcatenator 
{ 
  static void Main() 
  { 
    Console.WriteLine(DateTime.Now); 
 
    StringBuilder sb = new StringBuilder(); 
    sb.Append("Numbers: "); 
 
    for (int index = 1; index <= 200000; index++) 
        { 
      sb.Append(index); 
    } 
 
    Console.WriteLine(sb.ToString().Substring(0, 1024)); 
    Console.WriteLine(DateTime.Now); 
  } 
} 
//Reversing a String
public class WordReverser 
{ 
  static void Main() 
  { 
    string text = "EM edit"; 
    string reversed = ReverseText(text); 
      Console.WriteLine(reversed); 
 
    // Console output: 
    // tide ME 
  } 
 
  static string ReverseText(string text) 
  { 
    StringBuilder sb = new StringBuilder(); 
    for (int i = text.Length - 1; i >= 0; i--) 
    { 
      sb.Append(text[i]); 
    } 
    return sb.ToString(); 
  } 
}
//Extracting All Capital Letters from a Text 
public static string ExtractCapitals(string str) 
{ 
  StringBuilder result = new StringBuilder(); 
  for (int i = 0; i < str.Length; i++) 
  { 
    char ch = str[i]; 
    if (char.IsUpper(ch)) 
    { 
      result.Append(ch); 
    } 
  } 
  return result.ToString(); 
} 
