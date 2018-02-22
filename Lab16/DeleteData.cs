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
              

            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi khi mo  ket noi:" + ex.Message);
                return -1;
            }

        }
