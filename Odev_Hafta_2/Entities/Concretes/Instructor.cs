using Entities.Abstracts;


namespace Entities.Concretes
{
    public class Instructor:IEntity
    {
        public int InstructorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
      
        


    }
}
