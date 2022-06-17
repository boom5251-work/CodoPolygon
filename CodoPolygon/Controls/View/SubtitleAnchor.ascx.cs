using System;
using System.Web.UI;

namespace CodoPolygon.Controls.View
{
    public partial class SubtitleAnchor : UserControl
    {
        /// <summary>Номер якоря.</summary>
        public int Index { get; set; }
        /// <summary>Текст подзаголовка.</summary>
        public string Text { get; set; } = string.Empty;
        /// <summary>Идентификатор подзаголовка (якоря).</summary>
        public string HeaderId => $"subtitle-anchor-{Index}";



        protected void Page_Load(object sender, EventArgs e)
        {
            return;
        }
    }
}