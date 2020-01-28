using MyGameStore.Abstract;
using MyGameStore.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MyGameStore.Infrastructure
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IGameRepository>().To<EFGameRepository>();

            EmailSettings emailSettings = new EmailSettings
            {
                WriteAsFile = bool.Parse(ConfigurationManager
                    .AppSettings["Email.WriteAsFile"] ?? "false")
            };

            Bind<IOrderProcessor>().To<EmailOrderProcessor>()
                .WithConstructorArgument("settings", emailSettings);
        }
    }
}