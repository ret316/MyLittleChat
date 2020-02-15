using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLittleChat.Model
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string login { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public Guid password { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 3)]
        public string name { get; set; }
    }
}
