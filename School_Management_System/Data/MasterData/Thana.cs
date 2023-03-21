﻿using System.ComponentModel.DataAnnotations.Schema;
using School_Management_System.Data.Entity;

namespace School_Management_System.Data.MasterData
{
    public class Thana : Base
    {
        public int? districtId { get; set; }
        public District district { get; set; }
        [Column(TypeName ="NVARCHAR(20)")]
        public string thanaCode { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string thanaName { get; set; }        
        [Column(TypeName = "NVARCHAR(120)")]
        public string thanaNameBn { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string shortName { get; set; }
        [Column(TypeName = "NVARCHAR(10)")]
        public string isActive { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string latitude { get; set; }
        [Column(TypeName = "NVARCHAR(120)")]
        public string longitude { get; set; }

    }
}
