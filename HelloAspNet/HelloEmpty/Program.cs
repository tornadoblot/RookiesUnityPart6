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

    // M
    // C
    // 뷰가 없음!
    // webapi를 사용할 때는 json 파일로 보냄
    // 굳이 html로 보낼 필요가 없는 통신을 할 때 사용

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
