using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Shared
{
    public partial class Subject
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Total { get; set; }
    }
}
