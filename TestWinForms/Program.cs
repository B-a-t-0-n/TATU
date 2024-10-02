using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TATU.Application;
using TATU.Infrastructure;

namespace TestWinForms
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = default!;

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddApplication();
                    services.AddInfrastructure();
                    services.AddTransient<Form1>();
                });
        }
    }
}