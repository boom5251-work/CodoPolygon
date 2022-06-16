using CodoPolygon.DAL.DomainModels;
using CodoPolygon.DAL.Repository;
using CodoPolygon.DAL.ViewModels;

namespace CodoPolygon.DAL.Map
{
    public sealed class ArticleMap
    {
        /// <summary>
        /// Добавляет новую статью или обновляет существующую. 
        /// </summary>
        /// <param name="viewModel">Модель представления статьи.</param>
        /// <param name="articleId">Выход: новый идентификатор добавленной статьи.</param>
        /// <returns>True, если действие выполнено успешно. False — нет.</returns>
        public bool AddOrUpdate(ArticleViewModel viewModel, out int articleId)
        {
            var domain = new Article
            {
                Id = viewModel.Id,
                LatShortName = viewModel.LatShortName,
                Name = viewModel.Name,
                Description = viewModel.Description,
                IsPublished = viewModel.IsPublished
            };

            using (var repository = new ArticleRepository())
            {
                bool result = repository.AddOrUpdate(domain);

                if (result)
                    articleId = repository.GetByLatName(viewModel.LatShortName).Id;
                else
                    articleId = viewModel.Id;

                return result;
            }
        }
    }
}