using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class CourseDal:ICourseDal
    {
        public List<Course> courses;
        public CourseDal()
        {
            courses = new List<Course>() { new Course { Name="C#,",CourseId=1,Description="C# Kursu",InstructorId=1,CategoryId=1},
            new Course { Name="JAVA,",CourseId=2,Description="JAVA Kursu",InstructorId=3,CategoryId=2 } };

        }
        public void Add(Course entity)
        {
            courses.Add(entity);
        }

        public void Delete(Course entity)
        {
            var deletedCourse = courses.First(c => c.CourseId == entity.CourseId);
            courses.Remove(deletedCourse);
        }

        public Course Get(int CourseId)
        {
            return courses.First(c => c.CourseId == CourseId); ;
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Update(Course entity)
        {
            var updatedCourse = courses.First(c => c.CourseId == entity.CourseId);
            updatedCourse.CourseId = entity.CourseId;
            updatedCourse.Description = entity.Description;
            updatedCourse.Name = entity.Name;
            updatedCourse.InstructorId=entity.InstructorId;
            updatedCourse.CategoryId = entity.CategoryId;

        }
    }
}
