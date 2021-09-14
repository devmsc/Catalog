using System;

namespace Catalog.Models.Base
{
    public class ModelBase
    {
        public ModelBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}