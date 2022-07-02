using CodoPolygon.DAL.ViewModels;
using System.Net.Http;
using System.Web.Http;

namespace CodoPolygon.Controllers
{
    [Authorize]
    [Route("api/author")]
    public class AuthorController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage SaveData([FromBody] ArticleViewModel article)
        {
            // TODO: Реализовать.
            return new HttpResponseMessage();
        }



        [HttpDelete]
        public HttpResponseMessage DeleteArticle([FromUri] string latShortName)
        {
            // TODO: Реализовать.
            return new HttpResponseMessage();
        }
    }
}