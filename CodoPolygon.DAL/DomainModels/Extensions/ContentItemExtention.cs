using CodoPolygon.DAL.DomainModels.Base;
using CodoPolygon.DAL.Repository;

namespace CodoPolygon.DAL.DomainModels.Extensions
{
    public static class ContentItemExtention
    {
        public static ContentItemType GetContentItemType(this ContentItem contentItem)
        {
            using (var repository = new ContentTypeRepository())
            {
                var contentType = repository.GetById(contentItem.TypeId);
                return (ContentItemType)contentType.UniqueCode;
            }
        }
    }
}