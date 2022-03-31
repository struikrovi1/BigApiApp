using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Lesson : IEntity
    {

        public int Id { get; set; }
        public string Name { get; set; } = null!;

   

        public List<LessonVideo>? LessonVideos { get; set; }



    }
}
