public static void DeleteData()
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
                    DataRow[] dt = khoa.Select("MaKhoa = 'MH09'");
                    dt[0].Delete();
                    adapter.Update(dt);
                }
                Console.WriteLine("Xoa du lieu thanh cong!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi khi mo  ket noi:" + ex.Message);

            }

        }
