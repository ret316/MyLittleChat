using Microsoft.Extensions.DependencyInjection;
using MyLittleChatDL.Service;
using MyLittleChatDL.Service.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLittleChatDL
{
    public static class DataLayerCollectionExtentions
    {
        public static IServiceCollection AddDataLayerCollection(this IServiceCollection services)
        {
            services.AddTransient<IUserRepositoryDL, UserRepositoryDL>();
            return services;
        }
    }
}
