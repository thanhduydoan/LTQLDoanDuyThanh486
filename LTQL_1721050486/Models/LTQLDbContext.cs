using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTQL_1721050486.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDb")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<LTQL_1721050486.Models.LopHoc486> LopHoc486 { get; set; }

        public System.Data.Entity.DbSet<LTQL_1721050486.Models.DDTSinhVien486> DDTSinhVien486 { get; set; }
    }
}
