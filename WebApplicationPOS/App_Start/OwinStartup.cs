using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

[assembly: OwinStartup(typeof(WebApplicationPOS.App_Start.OwinStartup))]

namespace WebApplicationPOS.App_Start
{
    public class OwinStartup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
