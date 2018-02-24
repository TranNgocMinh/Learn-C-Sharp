//using SqlDataAdapter and DataTable
 try
            {
                DataTable khoa = new DataTable();
                string connectionString = ConfigurationManager.ConnectionStrings["QLSV"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("SELECT MaKhoa, TenKhoa FROM Khoa;",
                    connection))
                {

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {

                        adapter.Fill(khoa);
                    }
                }
               
                Console.WriteLine("Du lieu tu bang Khoa:");
                foreach (DataRow r in khoa.Rows)
                {
                    string sFormat = String.Format("Ma Khoa:{0} Ten Khoa: {1}", r["MaKhoa"], r["TenKhoa"]);
                    Console.WriteLine(sFormat);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi khi mo  ket noi:" + ex.Message);
            } 
