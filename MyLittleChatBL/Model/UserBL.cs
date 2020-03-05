using System;
using System.Collections.Generic;
using System.Text;

namespace MyLittleChatBL.Model
{
    public class UserBL
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public Guid Password { get; set; }
        public string Name { get; set; }
    }
}
