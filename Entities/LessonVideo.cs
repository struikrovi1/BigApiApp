using Core.Abstract;

namespace Entities
{
    public class LessonVideo : IEntity
    {

        public int Id { get; set; } 

        public string Name { get; set; }    

        public string? VideoUrl { get; set; }   

        public TimeSpan VideoTime { get; set; }

        public int LessonId { get; set; }   

     
    }
}