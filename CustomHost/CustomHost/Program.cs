﻿using CustomHost.Internal;
using CustomHost.Internal.Implementation;
using System;

namespace CustomHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var host=
            BuildHost().Run();
        }

        public static IServiceHost BuildHost()=>
            new ServiceHostBuilder()
                .RegisterServices(builder =>
                {

                })
                .UseStartup<StartupImplementation>()
                .Build();
    }
}
