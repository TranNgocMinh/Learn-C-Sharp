//*****COLLECTION - ARRAYLIST************************
// It represents an ordered collection of an object that can be indexed individually.
using System;
using System.Collections;

namespace CollectionApplication {
   class Program {
      static void Main(string[] args) {
         ArrayList al = new ArrayList();
         
         Console.WriteLine("Adding some numbers:");
         al.Add(45);
         al.Add(78);
         al.Add(33);
         al.Add(56);
         al.Add(12);
         al.Add(23);
         al.Add(9);
         
         Console.WriteLine("Capacity: {0} ", al.Capacity);
         Console.WriteLine("Count: {0}", al.Count);
         
         Console.Write("Content: ");
         foreach (int i in al) {
            Console.Write(i + " ");
         }
         
         Console.WriteLine();
         Console.Write("Sorted Content: ");
         al.Sort();
         foreach (int i in al) {
            Console.Write(i + " ");
         }
         Console.WriteLine();
         Console.ReadKey();
      }
   }
}
