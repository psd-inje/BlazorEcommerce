using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Shared
{
    public partial class School
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Location { get; set; } = null!;
        public int StartedYear { get; set; }
        [StringLength(10)]
        public string? aaa1 { get; set; }
    }
}
