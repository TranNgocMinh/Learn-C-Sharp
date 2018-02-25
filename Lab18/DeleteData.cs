using (var context = new QuanLySinhVienEntities())
            {
                // query and return Khoa element that has MaKhoa = 'MH06'
                var deleted = (from kh in context.Khoas
                               where kh.MaKhoa == "MH06"
                               select kh).SingleOrDefault();
                // delete the Khoa that has MaKhoa = 'MH06'
                context.Khoas.Remove(deleted);
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
