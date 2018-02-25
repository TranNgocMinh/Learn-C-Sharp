using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagingData
{
    public partial class Khoa
    {
        public string ThongTinKhoa 
        {
            get 
            {
                return "Ma Khoa: " + MaKhoa + " " + "Ten Khoa: " + TenKhoa;
            }
        }
    }
}
