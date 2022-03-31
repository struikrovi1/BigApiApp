using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CourseSpecification : IEntity
    {
        public int Id { get; set; } 
        public int CourseId { get; set; }   

        public int SpecificationId { get; set; }    

        public virtual Specification? Specification { get; set; }
    }
}
