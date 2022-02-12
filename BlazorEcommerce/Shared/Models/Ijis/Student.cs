using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Shared
{
    [Index(nameof(SubjectID), Name = "IX_Students_SubjectID")]
    public partial class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public int SchoolID { get; set; }
        public int? SubjectID { get; set; }
        [StringLength(10)]
        public string? aaa { get; set; }
    }
}
