using System;
using Catalog.Models.Base;
using Catalog.Models.Requests;

namespace Catalog.Models.Comments
{
    public class Comment : ModelBase
    {
        public Comment()
        {
            
        }

        public Comment(string content)
        {
            Content = content;
            CreatedAt = DateTime.Now;
            UpdatedAt = CreatedAt;
        }
        public Request Request { get; set; }
        public Guid RequestId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}