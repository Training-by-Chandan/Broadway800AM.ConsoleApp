using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECom.Models
{
    public class Vendor
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        public bool IsActive { get; set; } = true;
        public double Rating { get; set; } = 0;
    }
}