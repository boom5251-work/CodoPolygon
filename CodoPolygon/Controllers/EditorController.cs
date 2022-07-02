using CodoPolygon.Business.Editor;
using CodoPolygon.DAL.ViewModels;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace CodoPolygon.Controllers
{
    [Authorize]
    [Route("api/editor")]
    public class EditorController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage SaveData([FromUri] string latShortName, [FromUri] int seqNum, [FromBody] List<ContentItemViewModel> content)
        {
            if (Inspector.HasArticle(latShortName) && Inspector.HasChapter(latShortName, seqNum))
            {
                ContentManager.SaveContent(latShortName, seqNum, content);
            }

            // TODO: Отправлять ответ об ошибке.
            return new HttpResponseMessage();
        }
    }
}