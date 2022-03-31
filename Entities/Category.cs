using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category : IEntity
    {

        public int Id { get; set; }

        public int? ParentCategoryId { get; set; }

        public string Name { get; set; } = null!;

        public int SeqNo { get; set; }  

        public virtual Category? ParentCategory { get; set; }

        public bool IsFeatured { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime ModifiedOn { get; set; }

        public DateTime PublishDate { get; set; }


    }
}
