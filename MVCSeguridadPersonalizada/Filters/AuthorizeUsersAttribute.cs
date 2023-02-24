using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MVCSeguridadPersonalizada.Filters
{
    public class AuthorizeUsersAttribute:AuthorizeAttribute,IAuthorizationFilter     
    {
        public void OnAuthorization(AutorizationFilterContext context)
        {
            var user =context.HttpContext.User;
            if (user.identity.IsAutheticated == false)
            {
                RouteValueDictionary rutalogin =
                    new RouteValueDictionary(new
                    {
                        Controller = "Manager",
                        Action = "Login"
                    });
                context.Result = new RedirectToRouteResult(rutalogin);
            }
        }
    }
}
