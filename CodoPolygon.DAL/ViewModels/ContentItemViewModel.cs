namespace CodoPolygon.DAL.ViewModels
{
    public sealed class ContentItemViewModel
    {
        /// <summary>Идентификатор элемента содержимого.</summary>
        public int Id { get; set; }
        /// <summary>Порядковый номер элемента содержимого.</summary>
        public int SeqNum { get; set; }
        /// <summary>Строка, указывающая тип содержимого.</summary>
        public string TypeCode { get; set; }
        /// <summary>Содержимое, представленное в различном формате.</summary>
        public string Content { get; set; }
    }
}