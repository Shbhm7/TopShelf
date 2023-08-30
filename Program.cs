using System.Text.Json;
using Topshelf;
namespace JsonFileService
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(config =>
            {
                config.Service<FileService>(service =>
                {
                    service.ConstructUsing(s => new FileService());
                    service.WhenStarted(s => s.Start());
                    service.WhenStopped(s => s.Stop());
                });
                config.RunAsLocalSystem();
                config.SetDisplayName("JsonFileService");
                config.SetServiceName("JsonFileService");
                config.SetDescription("Reads and writes data to a JSON file.");
            });
        }
    }
}

    