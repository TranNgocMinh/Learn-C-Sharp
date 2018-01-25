using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
           //*****Cách sử dụng phương thức Chan_Le***************
            Console.WriteLine("Vui long nhap mot so nguyen:");
            int number = int.Parse(Console.ReadLine());
            if (Chan_Le(number))
                Console.WriteLine("Toi la so chan!");
            else
                Console.WriteLine("Toi la so le!");
            //****************************************************
            //**Sử dụng phương thức Phep_Tinh**********************
             Console.WriteLine("Vui long nhap so thu nhat:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Vui long nhap so thu hai:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Vui long nhap phep tinh +, -, *, hay /");
            char pt = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Phep_Tinh(a, b, pt);
            //*******************************************************
            Console.ReadKey();
        }
        // Yêu cầu:
        //1. Viết phương thức Chan_Le để kiểm tra một số nguyên là số chẵn hay lẻ.
        // Nếu là chẵn thì hiển thị "Toi la so chan!", nếu là lẻ thì hiển thị
        // "Toi la so le!".
        public static bool Chan_Le(int number) {
            ....
        }
        // 2. Viết phương thức Phep_Tinh để thực hiện +, -, *, / hai số thực
        // được nhập từ bàn phím và phép tính cũng được nhập từ bàn phím.
         public static void Phep_Tinh(double a, double b, char pt) {
            switch (pt) { 
                case '+':
                    Console.WriteLine(a.ToString()+"+"+b.ToString()+"="+(a+b).ToString());
                    break;
               ........
                default:
                    Console.WriteLine("Vui long nhap phep tinh + - * /");
                    break;
            
            }
        
        }
    }
}
