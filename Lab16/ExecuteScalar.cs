 public string GetPersonName(int MaSV) 
{ 
    string connectionString = ConfigurationManager.ConnectionStrings["QLSV"]?.ConnectionString; 
    using (SqlConnection connection = new SqlConnection(connectionString)) 
    using (SqlCommand command = new SqlCommand( 
        "SELECT TenSV FROM SinhVien WHERE MaSV = @MaSV", connection)) 
    { 
        command.Parameters.Add("MaSV", SqlDbType.NVarChar).Value = MaSV; 
        connection.Open(); 
        object result = command.ExecuteScalar(); 
        string TenSV = null; 
        if (result != DBNull.Value) 
        { 
            TenSV = (string)result; 
        } 
        return TenSV; 
    } 
} 
