using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ManagingData
{
    public class Khoa
    {
        [Key]
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string EmailKH { get; set; } 
        // Navigation property
        //You’ll notice that we’re making the two navigation properties (Blog.Posts and Post.Blog) virtual. 
        //This enables the Lazy Loading feature of Entity Framework. 
       // Lazy Loading means that the contents of these properties 
        // will be automatically loaded from the database when you try to access them.
        public virtual List<SinhVien> SinhViens { get; set; }
    }
}
