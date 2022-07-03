using CodoPolygon.Business.Controls;
using CodoPolygon.DAL.DomainModels.Base;
using System;
using System.Web.UI;

namespace CodoPolygon.Controls.View
{
    public partial class CodePanel : UserControl
    {
        /// <summary>Название языка (кодовое название).</summary>
        public string Lang { get; private set; } = string.Empty;
        /// <summary>Заголовок панели (название языка).</summary>
        public string Title { get; private set; } = string.Empty;
        /// <summary>Содержимое контрола (код).</summary>
        public string Code { get; private set; } = string.Empty;



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Lang))
                code.Attributes["class"] = $"language-{Lang.ToLower()}";
        }


        /// <summary>
        /// Инициализация контрола.
        /// </summary>
        /// <param name="code">Содержимое контрола (код).</param>
        /// <param name="type">Тип содержимого.</param>
        public void Initialize(string code, ContentItemType type)
        {
            Lang = CodeManager.GetLang(type);
            Title = CodeManager.GetTitle(type);
            Code = code;
        }
    }
}