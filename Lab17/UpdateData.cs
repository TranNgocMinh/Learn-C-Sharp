 public static void UpdateData()
        {
            try
            {
                DataTable khoa = new DataTable();
                string connectionString = ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("SELECT*FROM Khoa", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                using (SqlCommandBuilder builder = new SqlCommandBuilder(adapter))
                {
                    adapter.FillSchema(khoa, SchemaType.Source);
                    adapter.Fill(khoa);
                    DataRow[] dt = khoa.Select("MaKhoa = 'KH07'");
                    dt[0]["TenKhoa"] = "Cat got kim loai";                 
                    adapter.Update(dt);
                }
                Console.WriteLine("Cap nhat du lieu thanh cong!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi khi mo  ket noi:" + ex.Message);

            }
        }
