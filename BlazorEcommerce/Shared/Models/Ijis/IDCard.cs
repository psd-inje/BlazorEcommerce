using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Shared
{
    [Index(nameof(StudentID), Name = "IX_IDCards_StudentID", IsUnique = true)]
    public partial class IDCard
    {
        [Key]
        public int Id { get; set; }
        public Guid UniqueIdentifier { get; set; }
        public int StudentID { get; set; }
    }
}
