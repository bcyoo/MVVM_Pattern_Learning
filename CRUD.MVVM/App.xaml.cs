using CRUD.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Threading.Tasks;
using System.Windows;

using Microsoft.Extensions.DependencyInjection;

namespace CRUD.MVVM
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            
            Services = ConfigureServices();
            this.InitializeComponent(); 
        }

        public new static App Current => (App)Application.Current;

        public IServiceProvider Services { get; }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // ViewModel을 IoC에 등록
            // services = ConfigureServices
            // ConfigureServices()에 MainViewModel을 추가
            // MainViewModel은 한번 생성되면,
            // app이 종료 되기 전까지 유지되기 때문에 AddTransient로 등록하면된다.
            services.AddTransient(typeof(MainViewModel));
            return services.BuildServiceProvider();
        }
    }
}
