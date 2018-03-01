using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ManagingData
{
    public class QLSVContext:DbContext
    {
        public DbSet<Khoa> Khoas { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }  
    }
}
