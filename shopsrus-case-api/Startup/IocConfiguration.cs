﻿
using shopsrus.Domain.Interfaces;
using shopsrus.Infrastructure;
using StackExchange.Redis;

namespace shopsrus_case_api
{
    public static class IocConfiguration
    {
        public static void RegisterAllDependencies(IServiceCollection services, IConfiguration config)
        {

            //var redis = new RedisHelper(ConnectionMultiplexer.Connect(new ConfigurationOptions
            //{
            //    EndPoints = { config["Redis:Host"] },
            //    AbortOnConnectFail = config["Redis:AbortOnConnectFail"].TryParseBool(),
            //    Ssl = config["Redis:Ssl"].TryParseBool(),
            //    ConnectTimeout = config["Redis:ConnectTimeout"].TryParseInt(),
            //    ConnectRetry = config["Redis:ConnectRetry"].TryParseInt()
            //})) ;
            //services.AddSingleton<IRedisService>(opt => redis);




            //services.Scan(scan =>
            //{
            //    scan.FromApplicationDependencies(a => a.GetName().Name.StartsWith("shopsrus"))
            //    .AddClasses(classes => classes.AssignableTo<ITansientDependency>())
            //        .AsSelfWithInterfaces()
            //        .WithTransientLifetime()
            //    .AddClasses(classes => classes.AssignableTo<IScopedDependency>())
            //        .AsSelfWithInterfaces()
            //        .WithScopedLifetime()
            //    .AddClasses(classes => classes.AssignableTo<ISingletonDependency>())
            //        .AsSelfWithInterfaces()
            //        .WithSingletonLifetime();

            //});

        }

    }


}
