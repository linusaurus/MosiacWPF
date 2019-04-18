using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using Database;
using Mosiac.Services;
using Mosiac.ViewModels;
using System.Threading.Tasks;
using Prism.Events;
using Mosiac.Views.Services;
using Mosiac.Views;
using Mosiac.Repository;

namespace Mosiac.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Main>().AsSelf();
            

            builder.RegisterType<DatabaseContext>().AsSelf();
            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();
            builder.RegisterType<PartDetailView>().AsSelf();
            builder.RegisterType<PartDetailViewModel>().As<IPartDetailViewModel>();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();


            builder.RegisterType<LookupDataService>().AsImplementedInterfaces();

            builder.RegisterType<MessageDialogService>().As<IMessageDialogService>();
            builder.RegisterType<AssetService>().As<IAssetService>();
            builder.RegisterType<PartRepository>().As<IPartRepository>();
            builder.RegisterType<PartService>().As<IPartService>();

            return builder.Build();
        }
    }
}
