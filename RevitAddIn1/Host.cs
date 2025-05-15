using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RevitAddIn1.Config.Logging;
using RevitAddIn1.Config.Options;
using RevitAddIn1.Services;
using RevitAddIn1.ViewModels;
using RevitAddIn1.Views;
using System.IO;
using System.Net.Http;
using System.Reflection;
using Wpf.Ui;
using Wpf.Ui.Abstractions;

namespace RevitAddIn1
{
    /// <summary>
    ///     Provides a host for the application's services and manages their lifetimes
    /// </summary>
    public static class Host
    {
        private static IHost? _host;

        /// <summary>
        ///     Starts the host and configures the application's services
        /// </summary>
        public static void Start()
        {
            var builder = new HostApplicationBuilder(new HostApplicationBuilderSettings
            {
                ContentRootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                DisableDefaults = true
            });

            //Logging
            builder.Logging.ClearProviders();
            builder.Logging.AddSerilogConfiguration();

            //Options
            builder.Services.AddApplicationOptions();

            //MVVM
            builder.Services.AddTransient<RevitAddIn1ViewModel>();
            builder.Services.AddTransient<RevitAddIn1View>();
            builder.Services.AddTransient<Page1ViewModel>();
            builder.Services.AddTransient<Page1>();
            builder.Services.AddTransient<Page2ViewModel>();
            builder.Services.AddTransient<Page2>();
            builder.Services.AddScoped<INavigationViewPageProvider, NavigationViewPageProvider>();
            //builder.Services.AddNavigationViewPageProvider();
            builder.Services.AddSingleton<INavigationService, NavigationService>();

            _host = builder.Build();
            _host.Start();
        }

        /// <summary>
        ///     Stops the host and handle <see cref="IHostedService"/> services
        /// </summary>
        public static void Stop()
        {
            _host!.StopAsync().GetAwaiter().GetResult();
            _host.Dispose();
        }

        /// <summary>
        ///     Get service of type <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The type of service object to get</typeparam>
        /// <exception cref="System.InvalidOperationException">There is no service of type <typeparamref name="T"/></exception>
        public static T GetService<T>() where T : class
        {
            return _host!.Services.GetRequiredService<T>();
        }
    }
}