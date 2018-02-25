//using DbSet and DbContext
static void Main(string[] args)
        {

            using (var context = new QuanLySinhVienEntities())
            {
                // Access the database. 
                List<Khoa> DSkhoa = context.Khoas.ToList();
               
                foreach(Khoa kh in DSkhoa)
                    Console.WriteLine(kh.ThongTinKhoa);
            } 

            Console.WriteLine("Nhan phim bat ky de dong ung dung.");
            Console.ReadKey();
        }
