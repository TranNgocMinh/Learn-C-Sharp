using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // nhập chiều dài và rộng của hình chữ nhật
            double CD = 4.5;
            double CR = 3.0;
            // tính chu vi hình chữ nhật
            double CV = (CD+CR)*2;
            // tính diện tích hình chữ nhật
            double DT = CD*CR;
            // hiển thị chu vi
            System.Console.WriteLine(CV.toString());
            // hiển thị diện tích
            System.Console.WriteLine(DT.toString());
        }
        // Yêu cầu:
        // 1. Viết phương thức có kiểu trả về:
        //   a. Phương thức Chu_vi gồm hai tham số tính chu vi hình chữ nhật
        Chu_vi () 
        {
            ...
        }
        //   b. Phương thức Dien_tich gồm hai tham số tính diện tích hình chữ nhật
        Dien_tich()
        {
            ...
        }
        // 2. Viết phương thức không có kiểu trả về:
        //   a. Phương thức Chu_vi gồm hai tham số tính chu vi hình chữ nhật
        Chu_vi () 
        {
            ...
        }
        //   b. Phương thức Dien_tich gồm hai tham số tính diện tích hình chữ nhật
        Dien_tich()
        {
            ...
        }
     
    }
}
