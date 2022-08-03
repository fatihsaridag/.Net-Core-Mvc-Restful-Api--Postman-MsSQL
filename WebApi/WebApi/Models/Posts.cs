using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Posts
    {
        [Required]                                      //Data Annotation kütüphanesi
        public int UserId { get; set; }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Title{ get; set; }
        [Required]
        [MaxLength(500)]
        public string Body { get; set; }
    }
}
