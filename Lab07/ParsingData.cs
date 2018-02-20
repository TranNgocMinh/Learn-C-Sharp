//Parsing Numeric Types
string text = "53"; 
int intValue = int.Parse(text); // intValue = 53 
string text = "True"; 
bool boolValue = bool.Parse(text); // boolValue = true 
//Parsing Dates 
string text = "11/11/2001"; 
DateTime parsedDate = DateTime.Parse(text); 
Console.WriteLine(parsedDate); // 11-Nov-01 0:00:00 AM 
string text = "11/12/2001"; 
string format = "MM/dd/yyyy"; 
DateTime parsedDate = DateTime.ParseExact( 
  text, format, CultureInfo.InvariantCulture); 
Console.WriteLine("Day: {0}\nMonth: {1}\nYear: {2}", 
  parsedDate.Day, parsedDate.Month, parsedDate.Year); 
// Day: 12 
// Month: 11 
// Year: 2001 
