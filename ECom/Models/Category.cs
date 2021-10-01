using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECom.Models
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        public Guid? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public virtual Category ParentCategory { get; set; }
    }
}