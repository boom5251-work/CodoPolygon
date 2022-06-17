using System;
using System.Web.UI;

namespace CodoPolygon.Controls.View
{
    public partial class NotePanel : UserControl
    {
        /// <summary>Содержимое панели примечания.</summary>
        public string Content { get; set; } = string.Empty;



        protected void Page_Load(object sender, EventArgs e)
        {
            return;
        }
    }
}