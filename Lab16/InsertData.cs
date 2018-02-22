 static void Main(string[] args)
        {

          
           Khoa kh = new Khoa();
            kh.MaKhoa = "KH03";
            kh.TenKhoa = "Moi Truong";
            if(InsertData(kh) > 0)
                Console.WriteLine("Them du lieu thanh cong!"); 
            else
                Console.WriteLine("Them du lieu that bai!");

            Console.WriteLine("Nhan phim bat ky de dong ung dung."); 
            Console.ReadKey(); 
        }
 public static int InsertData(Khoa khoa)
        {
            try
            {
               
                string connectionString = ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("INSERT INTO Khoa(MaKhoa,TenKhoa)" +
                    "VALUES(@MaKhoa,@TenKhoa)",
                    connection))
                {
                    command.Parameters.Add("MaKhoa", SqlDbType.NChar, 10).Value = khoa.MaKhoa;
                    object dbTenKhoa = khoa.TenKhoa;
                    if (dbTenKhoa == null)
                    {
                        dbTenKhoa = DBNull.Value;
                    }
                    command.Parameters.Add("TenKhoa", SqlDbType.NVarChar, 50).Value = dbTenKhoa; 
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
