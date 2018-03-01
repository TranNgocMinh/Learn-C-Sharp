using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace ManagingData
{
    public class SinhVien
    {
        [Key]
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string Email { get; set; }
        public string MaKhoa { get; set; }
        //  Navigation property
        //You’ll notice that we’re making the two navigation properties (Blog.Posts and Post.Blog) virtual. 
        //This enables the Lazy Loading feature of Entity Framework. 
        // Lazy Loading means that the contents of these properties 
        // will be automatically loaded from the database when you try to access them.
        public virtual Khoa Khoa { get; set; }
    }
}
