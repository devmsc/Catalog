using Catalog.Models.Base;

namespace Catalog.Models.Users
{
    public class User : ModelBase
    {
        public User(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}