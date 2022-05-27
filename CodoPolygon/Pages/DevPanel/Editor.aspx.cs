using CodoPolygon.Business.Editor;
using System;
using System.Web;
using System.Web.UI;

namespace CodoPolygon.Pages.DevPanel
{
    public partial class Editor : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckQueries();
        }


        private void CheckQueries()
        {
            string article = Request.QueryString["article"];
            string chapter = Request.QueryString["chapter"];

            if (Inspector.HasArticle(article) && Inspector.HasChapter(article, chapter))
            {
                var articleCookie = new HttpCookie("article", article);
                var chapterCookie = new HttpCookie("chapter", chapter);

                Response.SetCookie(articleCookie);
                Response.SetCookie(chapterCookie);
            }
            else
            {
                // TODO: Добавить переадаресацию.
            }
        }
    }
}