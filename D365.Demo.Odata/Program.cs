using D365.Demo.Odata;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration(builder =>
    {
        builder
            .AddUserSecrets<Program>()
            .Build();
    })
    .ConfigureLogging((_, logging) =>
    {
        logging.AddConsole();
        logging.AddDebug();
    })
    .ConfigureServices((context, services) =>
    {

        var configurationRoot = context.Configuration;
        services.Configure<AppSettings>(configurationRoot.GetSection("App"));
        services.Configure<ADConfig>(configurationRoot.GetSection(nameof(ADConfig)));
        services.Configure<BlobConfig>(configurationRoot.GetSection(nameof(BlobConfig)));

        services.AddSingleton<AuthService, AuthService>();
        services.AddSingleton<D365Service, D365Service>();

        // List of demos to run
        services.AddTransient<IDemoService, DemoReadLegalEntities>();
        services.AddTransient<IDemoService, DemoReadCustomerGroups>();
        //services.AddTransient<IDemoService, DemoCreateCustomer>();
        //services.AddTransient<IDemoService, DemoReadCreatedCustomer>();
        //services.AddTransient<IDemoService, DemoUpdateCustomer>();
        services.AddTransient<IDemoService, DemoPackageExporter>();
    })
    .Build();

var demos = host.Services.GetServices<IDemoService>();

foreach (var demo in demos)
{
    Console.WriteLine($"\n\n*** DEMO : {demo.ToString()} ***\n");
    await demo.ExecuteAsync();
    Console.WriteLine("\n*** DEMO FINISHED ***\nPress ENTER");
    Console.ReadLine();
}


await host.RunAsync();


