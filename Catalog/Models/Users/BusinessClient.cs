using System.Collections.Generic;
using Catalog.Models.Requests;

namespace Catalog.Models.Users
{
    public class BusinessClient : User
    {
        public List<Request> Requests { get; set; }

        public BusinessClient(string name) : base(name)
        {
        }
    }
}