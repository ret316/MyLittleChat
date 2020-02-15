using Microsoft.Extensions.DependencyInjection;
using MyLittleChatBL.Service;
using MyLittleChatBL.Service.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLittleChatBL
{
    public static class BusinessLayerCollectionExtentions
    {
        public static IServiceCollection AddBusinessLayerCollection(this IServiceCollection services)
        {
            services.AddTransient<IUserRepositoryBL, UserRepositoryBL>();
            return services;
        }
    }
}
