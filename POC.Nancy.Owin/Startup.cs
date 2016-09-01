using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Extensions;
using Microsoft.Owin.StaticFiles;
using POC.Nancy.Owin.Infrastructure;

[assembly: OwinStartup(typeof(POC.Nancy.Owin.Startup))]

namespace POC.Nancy.Owin
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var options = new FileServerOptions {
                EnableDefaultFiles = true,
                FileSystem = new WebPhysicalFileSystem(".\\wwwroot")
            };


            app.UseFileServer(options)
                .UseNancy()
                .UseStageMarker(PipelineStage.MapHandler);
        }
    }
}
