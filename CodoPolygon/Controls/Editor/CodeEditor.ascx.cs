using CodoPolygon.Business.Controls;
using CodoPolygon.DAL.DomainModels.Base;
using System;
using System.Text.RegularExpressions;
using System.Web.UI;

namespace CodoPolygon.Controls.Editor
{
    public partial class CodeEditor : UserControl
    {
        /// <summary>Название языка (кодовое название).</summary>
        public string Lang { get; private set; } = string.Empty;
        /// <summary>Содержимое контрола (код).</summary>
        public string Code { get; private set; } = string.Empty;

        /// <summary>Количество строк поля ввода.</summary>
        public int RowsCount => new Regex("\n").Matches(Lang).Count + 1;



        protected void Page_Load(object sender, EventArgs e)
        {
            code.Attributes["rows"] = RowsCount.ToString();
            langSelect.Items.FindByValue(Lang).Selected = true;
        }


        /// <summary>
        /// Инициализация контрола.
        /// </summary>
        /// <param name="code">Содержимое контрола (код).</param>
        /// <param name="type">Тип содержимого.</param>
        public void Initialize(string code, ContentItemType type)
        {
            Lang = CodeManager.GetLang(type);
            Code = code;
        }
    }
}