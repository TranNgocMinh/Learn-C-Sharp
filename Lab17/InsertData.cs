public static void InsertData()
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
                    DataRow khoamoi = khoa.NewRow();
                    khoamoi["MaKhoa"] = "MH09";
                    khoamoi["TenKhoa"] = "Cong nghe Sinh Hoc";
                    khoa.Rows.Add(khoamoi);
                    adapter.Update(khoa);
                }
                Console.WriteLine("Them du lieu thanh cong!");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi khi mo  ket noi:" + ex.Message);
               
            }
            
        }
