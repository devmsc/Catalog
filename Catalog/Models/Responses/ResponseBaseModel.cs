namespace Catalog.Models.Responses
{
    public class ResponseBaseModel<T>
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}