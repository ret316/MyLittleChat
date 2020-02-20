using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLittleChatDL.Service.Implementation
{
    public class BaseRepository
    {
        protected Settings Settings { get; set; }
        public BaseRepository(IOptions<Settings> options)
        {
            this.Settings = options.Value;
        }

        public ApplicationContext GetApplicationContext()
        {
            return new ApplicationContext(Settings.DBConString);
        }
    }
}
