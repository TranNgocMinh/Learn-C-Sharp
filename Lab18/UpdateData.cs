using (var context = new QuanLySinhVienEntities())
            {
                // query and return Khoa element that has MaKhoa = 'KH05'
                var updated = (from kh in context.Khoas
                               where kh.MaKhoa == "KH05"
                               select kh).SingleOrDefault();
                // update the Khoa that has MaKhoa = 'MH06'
                updated.TenKhoa = "Cong nghe thong tin";
                // update database
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
