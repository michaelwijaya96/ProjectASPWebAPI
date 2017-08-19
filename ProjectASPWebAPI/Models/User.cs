using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectASPWebAPI.Models
{
    public class User
    {
        public int UserID { get; set; }
        [Required, MaxLength(50)]
        public string UserName { get; set; }
        [Required, MaxLength(100)]
        public string UserPassword { get; set; }
        [Required, MaxLength(1)]
        public string UserRole { get; set; }
        [Required, MaxLength(100)]
        public string UserImg { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdDate { get; set; }
    }
}