 using (var context = new QuanLySinhVienEntities())
            {
                // create a new Khoa object
                Khoa khoamoi = new Khoa();
                khoamoi.MaKhoa = "MH06";
                khoamoi.TenKhoa = "Dien-Dien Tu";
                // insert a new Khoa
                context.Khoas.Add(khoamoi);
                context.SaveChanges();
                // display all Khoas from database ordered
                //query for descending sort by MaKhoa
                var DSKhoa = from kh in context.Khoas
                             orderby kh.MaKhoa descending
                             select kh;
                // Execute the query
                foreach(Khoa kh in DSKhoa)
                {
                    Console.WriteLine(kh.ThongTinKhoa);
                }
            } 
