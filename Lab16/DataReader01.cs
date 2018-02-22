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
                string connectionString = ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString)) 
                using (SqlCommand command = new SqlCommand( "SELECT MaKhoa, TenKhoa FROM Khoa;", connection)) 
                { 
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var kh = new Khoa();                         
                            kh.MaKhoa = reader.GetString(0);
                            kh.TenKhoa = reader.GetString(1);
                            khoa.Add(kh);
                        }
                    }
                }
                Console.WriteLine("Mo va dong co so du lieu thanh cong.");
                foreach (Khoa kh in khoa) {
                    string sFormat = String.Format("Ma Khoa:{0} Ten Khoa: {1}",kh.MaKhoa,kh.TenKhoa);
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
}
