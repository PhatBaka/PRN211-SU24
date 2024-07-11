using Microsoft.Extensions.DependencyInjection;
using Repositories;
using Repositories.Impls;
using Repositories.Interfaces;
using Services.Impls;
using Services.Interfaces;
using UI.Customers;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // Build the ServiceProvider
            var serviceProvider = serviceCollection.BuildServiceProvider();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<frmLogin>());
            // Application.Run(serviceProvider.GetRequiredService<frmCustomers>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<DiamondShopSystemContext>();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IAccountService, AccountService>();

            services.AddScoped<frmLogin>();
        }
    }
}