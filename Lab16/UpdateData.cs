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
