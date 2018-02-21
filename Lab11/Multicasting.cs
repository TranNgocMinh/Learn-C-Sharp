// Delegate objects can be composed using the "+" operator. 
// A composed delegate calls the two delegates it was composed from. Only delegates of the same type can be composed. 
// The "-" operator can be used to remove a component delegate from a composed delegate.
// Using this property of delegates you can create an invocation list of methods that will be called when a delegate is invoked. 
// This is called multicasting of a delegate.
using System;

delegate int NumberChanger(int n);
namespace DelegateAppl {
   class TestDelegate {
      static int num = 10;
      
      public static int AddNum(int p) {
         num += p;
         return num;
      }
      public static int MultNum(int q) {
         num *= q;
         return num;
      }
      public static int getNum() {
         return num;
      }
      static void Main(string[] args) {
         //create delegate instances
         NumberChanger nc;
         NumberChanger nc1 = new NumberChanger(AddNum);
         NumberChanger nc2 = new NumberChanger(MultNum);
         
         nc = nc1;
         nc += nc2;
         
         //calling multicast
         nc(5);
         Console.WriteLine("Value of Num: {0}", getNum());
         Console.ReadKey();
      }
   }
}
