using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        public int? ParentCategoryId { get; set; }

        public string Name { get; set; } = null!;

        public int SeqNo { get; set; }

        public bool IsFeatured { get; set; }

        public bool IsDeleted { get; set; }

      

    }
}
