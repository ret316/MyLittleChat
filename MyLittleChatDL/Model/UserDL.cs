using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyLittleChatDL.Model
{
    public class UserDL
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Login { get; set; }
        [Required]
        public Guid Password { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 3)]
        public string Name { get; set; }
    }
}
