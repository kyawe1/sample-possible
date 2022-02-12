using System.Web.Mvc;

namespace WebApplicationPOS.Areas.SpaMyanamar
{
    public class SpaMyanamarAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SpaMyanamar";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "SpaMyanamar_default",
                "SpaMyanamar/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}