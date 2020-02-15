using System;
using System.Collections.Generic;
using System.Text;

namespace MyLittleChatBL.Model
{
    public class UserBL
    {
        public int id { get; set; }
        public string login { get; set; }
        public Guid password { get; set; }
        public string name { get; set; }
    }
}
