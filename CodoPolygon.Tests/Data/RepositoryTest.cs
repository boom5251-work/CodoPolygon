using CodoPolygon.DAL.DomainModels;
using CodoPolygon.DAL.Map;
using CodoPolygon.DAL.Repository;
using CodoPolygon.DAL.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodoPolygon.Tests.Data
{
    [TestClass]
    public class RepositoryTests
    {
        private int ArticleId { get; set; }
        private int ChapterId { get; set; }


        [TestMethod]
        public void CreateArticle_NewOne_Added()
        {
            ArticleId = AddArticle();
            ChapterId = AddChapter();
            AddContentItem();
        }


        [TestMethod]
        public void RemoveArticle_GotOne_Removed()
        {
            using (var repository = new ArticleRepository())
            {
                var article = repository.GetByLatName("test-article");

                Assert.IsTrue(repository.Remove(article));
            }
        }


        private int AddArticle()
        {
            var article = new Article
            {
                Name = "Тестовое имя статьи",
                Description = "Тестовое описание статьи",
                LatShortName = "test-article",
                IsPublished = false
            };

            using (var repository = new ArticleRepository())
            {
                Assert.IsTrue(repository.AddOrUpdate(article));
            }

            return article.Id;
        }


        private int AddChapter()
        {
            var chapter = new Chapter
            {
                ArticleId = ArticleId,
                Name = "Тестовое имя главы",
                SequenceNumber = 1
            };

            using (var repository = new ChapterRepository())
            {
                Assert.IsTrue(repository.AddOrUpdate(chapter));                
            }

            return chapter.Id;
        }


        private void AddContentItem()
        {
            var viewModel = new ContentItemViewModel
            {
                Content = "Контент",
                SeqNum = 1,
                TypeCode = "NotSet"
            };

            var contentMap = new ContentMap();
            contentMap.AddOrUpdate(ChapterId, viewModel);
        }
    }
}