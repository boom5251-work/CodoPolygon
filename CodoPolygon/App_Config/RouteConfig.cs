using System.Web.Http;
using System.Web.Routing;

namespace CodoPolygon.AppConfig
{
    public sealed class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(
                "Index",
                "",
                "~/Pages/Index.aspx"
            );

            routes.MapPageRoute(
                "Admin",
                "admin.aspx",
                "~/Pages/DevPanel/Admin.aspx"
            );

            routes.MapPageRoute(
                "Author",
                "author.aspx",
                "~/Pages/DevPanel/Author.aspx"
            );

            routes.MapPageRoute(
                "Login",
                "login.aspx",
                "~/Pages/DevPanel/Login.aspx"
            );

            routes.MapPageRoute(
                "Editor",
                "editor.aspx",
                "~/Pages/DevPanel/Editor.aspx"
            );

            routes.MapPageRoute(
                "Article",
                "{latShortName}/article.aspx",
                "~/Pages/View/ArticleView.aspx"
            );

            routes.MapPageRoute(
                "Error",
                "error.aspx",
                "~/Pages/Error.aspx"
            );

            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}