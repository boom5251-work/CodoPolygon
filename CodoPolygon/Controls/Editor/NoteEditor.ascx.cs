using System;
using System.Web.UI;

namespace CodoPolygon.Controls.Editor
{
    public partial class NoteEditor : UserControl
    {
        public string Content { get; set; } = string.Empty;



        protected void Page_Load(object sender, EventArgs e)
        {
            contentArea.InnerHtml = Content;
        }
    }
}