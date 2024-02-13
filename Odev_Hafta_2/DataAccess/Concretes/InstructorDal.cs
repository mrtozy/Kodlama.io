using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class InstructorDal : IInsturctorDal
    {
        public List<Instructor> instructors;
        public InstructorDal()
        {
            instructors = new List<Instructor>() { new Instructor {  InstructorId = 1,FirstName="Engin", LastName="Demiroğ"
                },
                new Instructor {  InstructorId = 2,  FirstName = "Halit Enes", LastName = "Kalaycı"
               } };

        }
        public void Add(Instructor entity)
        {
            instructors.Add(entity);
        }

        public void Delete(Instructor entity)
        {
            var deletedInstructor = instructors.First(c => c.InstructorId == entity.InstructorId);
            instructors.Remove(deletedInstructor);
        }

        public Instructor Get(int InstructorId)
        {
            return instructors.First(c => c.InstructorId == InstructorId); ;
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Update(Instructor entity)
        {
            var updatedInstructor = instructors.First(c => c.InstructorId == entity.InstructorId);
            updatedInstructor.InstructorId = entity.InstructorId;
           
            updatedInstructor.FirstName = entity.FirstName;
            updatedInstructor.LastName = entity.LastName;
            
        }
    }
}
