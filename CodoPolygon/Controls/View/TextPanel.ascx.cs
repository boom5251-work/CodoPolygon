using System;
using System.Web.UI;

namespace CodoPolygon.Controls.View
{
    public partial class TextPanel : UserControl
    {
        /// <summary>Содержимое текстовой панели.</summary>
        public string Text { get; set; } = string.Empty;



        protected void Page_Load(object sender, EventArgs e)
        {
            htmlContent.InnerHtml = Text;
        }
    }
}