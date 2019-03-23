﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolRegister.BLL.Entities
{
    public class SubjectGroup
    {
        [Key]
        public int GroupId { get; set; }
        public Group Group { get; set; }
        [Key]
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

    }
}
