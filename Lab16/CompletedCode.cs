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

           // LoadData();
            Khoa kh = new Khoa();
            kh.MaKhoa = "KH08";
            kh.TenKhoa = "May";
            if(InsertData(kh) >= 0)
                Console.WriteLine("Them du lieu thanh cong!");
            else
                Console.WriteLine("Them du lieu that bai!");
            
        /*  Khoa kh = new Khoa();
          kh.MaKhoa = "KH03";
          kh.TenKhoa = "Cong nghe sinh hoc";
          if(UpdateData(kh) > 0)
              Console.WriteLine("Cap nhat du lieu thanh cong!"); 
          else
              Console.WriteLine("Cap nhat du lieu that bai!");*/
         /*   Khoa kh = new Khoa();
            kh.MaKhoa = "KH03";
           
            if (DeleteData(kh) > 0)
                Console.WriteLine("Xoa du lieu thanh cong!");
            else
                Console.WriteLine("Xoa du lieu that bai!");
            */
            Console.WriteLine("Nhan phim bat ky de dong ung dung."); 
            Console.ReadKey(); 
        }
        public static void LoadData()
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
                foreach (Khoa kh in khoa)
                {
                    string sFormat = String.Format("Ma Khoa:{0} Ten Khoa: {1}", kh.MaKhoa, kh.TenKhoa);
                    Console.WriteLine(sFormat);
                }
                Console.WriteLine("Du lieu tu bang SinhVien:");
                foreach (SinhVien sv in sinhvien)
                {
                    string sFormat = String.Format("Ma Sinh Vien:{0} Ten Sinh Vien: {1} Email: {2} Ma Khoa: {3}",
                        sv.MaSV, sv.TenSV, sv.Email, sv.MaKhoa);
                    Console.WriteLine(sFormat);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi khi mo  ket noi:" + ex.Message);
            } 

            
        }
        public static int InsertData(Khoa khoa)
        {
            try
            {
               
                string connectionString = ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("InsertData",connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("MaKhoa", SqlDbType.NChar, 10).Value = khoa.MaKhoa;
                    object dbTenKhoa = khoa.TenKhoa;
                    if (dbTenKhoa == null)
                    {
                        dbTenKhoa = DBNull.Value;
                    }
                    command.Parameters.Add("TenKhoa", SqlDbType.NVarChar, 50).Value = dbTenKhoa; 
                    connection.Open();
                    command.ExecuteNonQuery();
                    return 1;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi khi mo  ket noi:" + ex.Message);
                return -1;
            }

            
        }
        public static int UpdateData(Khoa khoa)
        {
            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("UPDATE Khoa " +
                    "SET TenKhoa = @TenKhoa " +
                    "WHERE MaKhoa = @MaKhoa",
                    connection))
                {
                    command.Parameters.Add("MaKhoa", SqlDbType.NChar, 10).Value = khoa.MaKhoa;
                    command.Parameters.Add("TenKhoa", SqlDbType.NVarChar, 50).Value = khoa.TenKhoa; 
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
                //Console.WriteLine("Mo va dong co so du lieu thanh cong.");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi khi mo  ket noi:" + ex.Message);
                return -1;
            }
        }
        public static int DeleteData(Khoa khoa)
        {
            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("DELETE FROM Khoa " +
                    "WHERE MaKhoa = @MaKhoa",
                    connection))
                {
                    command.Parameters.Add("MaKhoa", SqlDbType.NChar, 10).Value = khoa.MaKhoa;
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
              //  Console.WriteLine("Mo va dong co so du lieu thanh cong.");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi khi mo  ket noi:" + ex.Message);
                return -1;
            }

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
