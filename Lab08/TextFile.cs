                                      //***********Reading from and Writing to Text Files****************
//**********************reading a text file named Jamaica.txt
using System;
using System.IO;

namespace FileApplication {
   class Program {
      static void Main(string[] args) {
         try {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader("c:/jamaica.txt")) {
               string line;

               // Read and display lines from the file until 
               // the end of the file is reached. 
               while ((line = sr.ReadLine()) != null) {
                  Console.WriteLine(line);
               }
            }
         } catch (Exception e) {
            // Let the user know what went wrong.
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
         }
         Console.ReadKey();
      }
   }
}
//*****************writing text data into a file
using System;
using System.IO;

namespace FileApplication {
   class Program {
      static void Main(string[] args) {
         string[] names = new string[] {"Zara Ali", "Nuha Ali"};
         
         using (StreamWriter sw = new StreamWriter("names.txt")) {

            foreach (string s in names) {
               sw.WriteLine(s);
            }
         }
         
         // Read and show each line from the file.
         string line = "";
         using (StreamReader sr = new StreamReader("names.txt")) {
            while ((line = sr.ReadLine()) != null) {
               Console.WriteLine(line);
            }
         }
         Console.ReadKey();
      }
   }
}
