﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MCC61_API_Project.Models
{
    [Table("tb_m_university")]
    public class University
    {
        [Key]
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public ICollection<Education> Educations { get; set; }
    }
}
