using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ManagingData
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new QLSVContext()) 
            { 
                //tạo một khoa mới
                Khoa kh = new Khoa();
                kh.MaKhoa = "KH04";
                kh.TenKhoa = "Cat Got Kim Loai";
                //thêm khoa mới và cập nhật đến cơ sở dữ liệu
                var khoamoi = db.Khoas.Add(kh);
                db.SaveChanges();
                var query = from Khoa khoa in db.Khoas
                            select khoa;
                foreach (Khoa k in query) 
                {
                    Console.WriteLine("Ma Khoa: " + k.MaKhoa + " Ten Khoa: " + k.TenKhoa);
                }
            }

            Console.WriteLine("Nhan phim bat ky de dong ung dung.");
            Console.ReadKey();
        }
    }
  
}
