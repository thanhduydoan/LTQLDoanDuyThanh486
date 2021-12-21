using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_1721050486.Models
{
    public class DDTSinhVien486
    {
        [Key]
        [Display(Name = "Mã sinh viên")]
        [StringLength(20)]
        public string MaSinhVien { get; set; }
        [Display(Name = "Họ và tên")]
        [StringLength(50)]
        public string HoTen { get; set; }
        [Display(Name = "Mã lớp")]
        public int MaLop { get; set; }
        [ForeignKey("MaLop")]
        public virtual LopHoc486 LopHoc486 { get; set; }
    }
}