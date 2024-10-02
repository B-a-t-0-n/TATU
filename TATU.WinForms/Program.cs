using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TATU.Application;
using TATU.Infrastructure;

namespace TATU.WinForms
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = default!;

        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            System.Windows.Forms.Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddApplication();
                    services.AddInfrastructure();
                    services.AddTransient<LoginForm>();
                });
        }
    }
}