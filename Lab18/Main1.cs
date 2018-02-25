// Exmaple about using Database First and partial classes
static void Main(string[] args)
        {

            Khoa kh = new Khoa();
            kh.MaKhoa = "KH06";
            kh.TenKhoa = "Co khi";
            Console.WriteLine("Thong tin ve khoa");
            Console.WriteLine(kh.ThongTinKhoa);

            Console.WriteLine("Nhan phim bat ky de dong ung dung.");
            Console.ReadKey();
        }
