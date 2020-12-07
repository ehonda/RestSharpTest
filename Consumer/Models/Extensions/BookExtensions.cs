namespace Consumer.Models.Extensions
{
    public static class BookExtensions
    {
        public static string ToBookString(this Book book)
            => $"{book.Id} - {book.Title} - {book.Author}";
    }
}
