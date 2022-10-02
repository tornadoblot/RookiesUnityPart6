using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace HelloEmpty
{
    // MVC
    // M (Model)        데이터(원자재)
    // V (View)         UI(인테리어)
    // C (Controller)   Controller(액션)

    // Razor
    // M 모델
    // VC 뷰+컨트롤러 두파츠로 나뉜 느낌
    // M - V - VM(뷰 모델)

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
