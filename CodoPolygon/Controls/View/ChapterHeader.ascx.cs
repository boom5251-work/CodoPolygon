using System;
using System.Web.UI;

namespace CodoPolygon.Controls.View
{
    public partial class ChapterHeader : UserControl
    {
        /// <summary>Название главы.</summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>Описание главы.</summary>
        public string Description { get; set; } = string.Empty;



        protected void Page_Load(object sender, EventArgs e)
        {
            return;
        }
    }
}