using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Course : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;  

        public string? Description { get; set; }

        public string? Summary { get; set; }
        public string PhotoUrl { get; set; } =null!;
        private decimal Price { get; set; }

        public decimal Discount { get; set; }

        public decimal? Rating { get; set; }

        public int InstructorId { get; set; }   

        public bool IsFeatured { get; set; }    

        public bool IsDeleted { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime PublishDate { get; set; }   


        public virtual Instructor? Instructor { get; set; }

        public List <Lesson>? Lessons { get; set; } 

        public List<CourseSpecification>? CourseSpecifications { get; set; } 

    }
}
