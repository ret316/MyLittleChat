using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyLittleChatDL.Model
{
    public class UserDL
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string login { get; set; }
        [Required]
        public Guid password { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 3)]
        public string name { get; set; }
    }
}
