// Stored Procedure
-- =============================================
-- Author:		ngocminhtran.com
-- Create date: 22/2/2018
-- Description:	
-- =============================================
CREATE PROCEDURE InsertData 
	-- Add the parameters for the stored procedure here
	@MaKhoa nchar(10) = NULL, 
	@TenKhoa nvarchar(50) = NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Khoa(MaKhoa,TenKhoa)
	VALUES(@MaKhoa,@TenKhoa);
END
// InsertData method
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
