// The SqlDataReader can retrieve multiple result sets and access them in the same manner it can access rows. 
// The reader is on the first result set by default, but if you have any subsequent result sets, you can 
// call NextResult and the reader will move to the next result set. 
// You can call Read again to move to the first row (if any). 
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

            try 
            {
                List<Khoa> khoa = new List<Khoa>();
                List<SinhVien> sinhvien = new List<SinhVien>();
                string connectionString = ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("SELECT MaKhoa, TenKhoa FROM Khoa;" + 
                    "SELECT MaSV, TenSV, Email, MaKhoa FROM SinhVien;", 
                    connection)) 
                { 
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //xử lý tập dữ liệu từ bảng Khoa
                        while (reader.Read())
                        {
                            var kh = new Khoa();                         
                            kh.MaKhoa = reader.GetString(0);
                            kh.TenKhoa = reader.GetString(1);
                            khoa.Add(kh);
                        }
                        //di chuyển đến tập dữ liệu từ bảng SinhVien
                        reader.NextResult();
                        // xử lý tập dữ liệu từ bảng SinhVien
                        while (reader.Read())
                        {
                            var sv = new SinhVien();
                            sv.MaSV = reader.GetString(0);
                            sv.TenSV = reader.GetString(1);
                            sv.Email = reader.GetString(2);
                            sv.MaKhoa = reader.GetString(3);
                            sinhvien.Add(sv);
                        }
                    }
                }
                Console.WriteLine("Mo va dong co so du lieu thanh cong.");
                Console.WriteLine("Du lieu tu bang Khoa:");
                foreach (Khoa kh in khoa) {
                    string sFormat = String.Format("Ma Khoa:{0} Ten Khoa: {1}",kh.MaKhoa,kh.TenKhoa);
                    Console.WriteLine(sFormat);
                }
                Console.WriteLine("Du lieu tu bang SinhVien:");
                foreach (SinhVien sv in sinhvien)
                {
                    string sFormat = String.Format("Ma Sinh Vien:{0} Ten Sinh Vien: {1} Email: {2} Ma Khoa: {3}", 
                        sv.MaSV,sv.TenSV,sv.Email,sv.MaKhoa);
                    Console.WriteLine(sFormat);
                }
            }   
            catch (Exception ex) 
            {
                Console.WriteLine("Loi khi mo  ket noi:" + ex.Message); 
            } 
            Console.WriteLine("Nhan phim bat ky de dong ung dung."); 
            Console.ReadKey(); 
        }
    }
    public class Khoa
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
    }
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string Email { get; set; }
        public string MaKhoa { get; set; } 
    }
}
