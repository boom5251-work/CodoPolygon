using CodoPolygon.Business.ArticleContent;
using CodoPolygon.Business.Controls;
using CodoPolygon.Controls.View;
using CodoPolygon.DAL.DomainModels;
using CodoPolygon.DAL.DomainModels.Base;
using CodoPolygon.DAL.DomainModels.Extensions;
using System;
using System.Web.UI;

namespace CodoPolygon.Pages.View
{
    public partial class Article : Page
    {
        private ContentItemType allTypes = ContentItemType.NotSet;



        /// <summary>Все типы содержимого, отображаемы на странице.</summary>
        public ContentItemType AllTypes
        {
            get => allTypes;
            set => allTypes = allTypes | value;
        }

        /// <summary>Сокращенное латинское название статьи.</summary>
        public string ArticleLatName => RouteData.Values["latShortName"]?.ToString();

        /// <summary>Порядковый номер главы.</summary>
        public int ChapterSeqNum
        {
            get => int.TryParse(Request.QueryString["chapter"], out int chapterSeqNum) == true ? chapterSeqNum : 0;
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ArticleLatName))
            {
                InitializeContent();
                InitializeScripts();
            }
            else
            {
                Response.RedirectPermanent("~/index.aspx");
            }
        }



        /// <summary>
        /// Начинает процесс отображения элементов содержимого.
        /// </summary>
        private void InitializeContent()
        {
            if (Inspector.HasArticle(ArticleLatName) && Inspector.HasChapter(ArticleLatName, ChapterSeqNum))
            {
                if (Inspector.IsPublished(ArticleLatName))
                {
                    var contentItems = ContentManager.GetContent(ArticleLatName, ChapterSeqNum);

                    foreach (var item in contentItems)
                    {
                        var contentControl = CreateContentControl(item);

                        if (contentControl != null)
                            contentContainer.Controls.Add(contentControl);
                    }
                }
                else RedirectToNotFound();
            }
            else RedirectToNotFound();
        }



        /// <summary>
        /// 
        /// </summary>
        private void InitializeScripts()
        {
            foreach (ContentItemType flag in Enum.GetValues(typeof(ContentItemType)))
            {
                if (AllTypes.HasFlag(flag))
                {
                    string lang = CodeManager.GetLang(flag);

                    if (!string.IsNullOrEmpty(lang))
                    {
                        string scriptTag = $"<script src=\"/root/libs/highlight/{lang}.min.js\"></script>";
                        var scriptLiteral = new LiteralControl(scriptTag);
                        hljsLangsContainer.Controls.Add(scriptLiteral);
                    }
                }
            }
        }



        /// <summary>
        /// Создает элемент управления на основе элемента содержимого.
        /// </summary>
        /// <param name="contentItem">Элемент содержимого.</param>
        /// <returns>Элемент управления.</returns>
        private Control CreateContentControl(ContentItem contentItem)
        {
            var type = contentItem.GetContentItemType();
            AllTypes = type;

            Control contentControl = null;

            // Панель кода.
            if ((type & ContentItemType.AnyCode) != ContentItemType.NotSet)
            {
                var codePanel = LoadControl("~/Controls/View/CodePanel.ascx") as CodePanel;
                codePanel.Initialize(contentItem.Content, type);
                contentControl = codePanel;
            }
            // Другое содержимое.
            else
            {
                // Форматированный текст.
                if (type == ContentItemType.FormattedText)
                {
                    var textPanel = LoadControl("~/Controls/View/TextPanel.ascx") as TextPanel;
                    textPanel.Text = contentItem.Content;
                    contentControl = textPanel;
                }
                // Форматированное примечание.
                else if (type == ContentItemType.FormattedNote)
                {
                    var notePanel = LoadControl("~/Controls/View/NotePanel.ascx") as NotePanel;
                    notePanel.Content = contentItem.Content;
                    contentControl = notePanel;
                }
                // Подзаголовок якорь.
                else if (type == ContentItemType.SubtitleAnchor)
                {
                    var subtitleAnchor = LoadControl("~/Controls/View/SubtitleAnchor.ascx") as SubtitleAnchor;
                    subtitleAnchor.Index = contentItem.Id;
                    subtitleAnchor.Text = contentItem.Content;
                    contentControl = subtitleAnchor;
                }
            }

            return contentControl;
        }



        /// <summary>
        /// Совершает переход на страницу с ошибкой.
        /// </summary>
        private void RedirectToNotFound()
        {
            //Response.RedirectPermanent("~/error.aspx?status-code=404");
        }
    }
}