// using query with LINQ
static void Main(string[] args)
        {

            using (var context = new QuanLySinhVienEntities())
            {
                // Access and query the database. 
                var query = from kh in context.Khoas
                            orderby kh.MaKhoa descending
                            select kh;
                foreach (Khoa kh in query) 
                {
                    Console.WriteLine(kh.ThongTinKhoa);
                }
            } 

            Console.WriteLine("Nhan phim bat ky de dong ung dung.");
            Console.ReadKey();
        }
