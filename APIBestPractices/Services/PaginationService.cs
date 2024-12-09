namespace APIBestPractices.Services
{
    public static class PaginationService
    {
        public static IEnumerable<T> Paginate<T>(IEnumerable<T> source, int pageNumber, int pageSize)
        {
            return source.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }
    }
}
