using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ProductCatalog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }
        //IWebHost é a uma abstração do servidor web
        //, ou seja, a aplicação é selfie host, ela mesmo tem um próprio servidor integrado
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
