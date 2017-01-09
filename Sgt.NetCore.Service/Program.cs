/***
 * 描述：本项目只为了在NetCore上开发WebApi的一个示例。项目中使用了Ef、Autofac、Newtonsoft.Json、Async、Repository、SqlServer等技术
 * 作者：Andre
 * 邮箱：xifucom@163.com
 * Github： https://github.com/xifucom/Sgt.NetCore
 ***/


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;

namespace Sgt.NetCore.Wpf
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://*:5000")
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
