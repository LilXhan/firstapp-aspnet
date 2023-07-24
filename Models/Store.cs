using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(60, ErrorMessage = "Exceded 60 characters")]
        public int Name { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [MaxLength(100, ErrorMessage = "Exceded 100 characters")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Status is required")]
        public bool Status { get; set; }
    }
}
