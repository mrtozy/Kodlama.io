
using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes;
using Entities.Concretes;




ICategoryService _categoryService = new CategoryManager(new CategoryDal());
Console.WriteLine("List All Categories.");

foreach (var category in _categoryService.GetAll())
{
    Console.WriteLine("Category Name: " + category.Name);
}
Console.WriteLine();
Console.WriteLine("Adding a New Category.");


_categoryService.Add(new Category() { CategoryId = 3,Name="Python"});
_categoryService.Add(new Category() { CategoryId = 4, Name = "Sql" });

foreach (var category in _categoryService.GetAll())
{
    Console.WriteLine("Category Name: " + category.Name);
}
Console.WriteLine();

Console.WriteLine("Category Delete.");

_categoryService.Delete(new Category() { CategoryId = 1});

foreach (var category in _categoryService.GetAll())
{
    Console.WriteLine("Category Name: " + category.Name);
}
Console.WriteLine();

Console.WriteLine("Category Update ");

_categoryService.Update(new Category() { CategoryId = 3,Name="Python Güncelleme" });

foreach (var category in _categoryService.GetAll())
{
    Console.WriteLine("Category Name : " + category.Name);
}


Console.WriteLine();


IInstructorService _instructorService = new InstructorManager(new InstructorDal());
Console.WriteLine("List All Instructors.");

foreach (var instructor in _instructorService.GetAll())
{
    Console.WriteLine("Instructor Name: " + instructor.FirstName);
}
Console.WriteLine();
Console.WriteLine("Adding a New Instructor.");


_instructorService.Add(new Instructor() { InstructorId = 3, FirstName = "Ahmet", LastName="Mehmet"});
_instructorService.Add(new Instructor() { InstructorId = 4, FirstName = "Necdet", LastName = "Fırtına" });

foreach (var instructor in _instructorService.GetAll())
{
    Console.WriteLine("Instructor Name " + instructor.FirstName);
}
Console.WriteLine();

Console.WriteLine("Instructor Delete");

_instructorService.Delete(new Instructor() { InstructorId = 2 });

foreach (var instructor in _instructorService.GetAll())
{
    Console.WriteLine("Instructor Name " + instructor.FirstName);
}
Console.WriteLine();


_instructorService.Update(new Instructor() { InstructorId = 1, FirstName = "Umut", LastName ="Gün" });
Console.WriteLine("Instructor Update Process Successful");

foreach (var instructor in _instructorService.GetAll())
{
    Console.WriteLine("Instructor : " + instructor.FirstName);
}




Console.WriteLine();




ICourseService _courseService = new CourseManager(new CourseDal());
Console.WriteLine(" Course All ");

foreach (var course in _courseService.GetAll())
{
    Console.WriteLine("Course Name: " + course.Name);
}
Console.WriteLine();
Console.WriteLine("Added New Course");


_courseService.Add(new Course() {CourseId=3,Description= "Python kursu", CategoryId=3,Name= "Python", InstructorId=1 });
_courseService.Add(new Course() { CourseId = 4, Description = "Sql kursu", CategoryId = 3, Name = "Sql", InstructorId = 1 });

foreach (var course in _courseService.GetAll())
{
    Console.WriteLine("Course Name " + course.Name);
}
Console.WriteLine();

Console.WriteLine("Course Delete.");

_courseService.Delete(new Course() { CourseId = 2 });

foreach (var course in _courseService.GetAll())
{
    Console.WriteLine("Course Name " + course.Name);
}
Console.WriteLine();

Console.WriteLine("Course Update Process");
_courseService.Update(new Course() { CourseId = 1, Description = "C# kursu", Name = "C#", CategoryId=1,InstructorId = 1 });

foreach (var course in _courseService.GetAll())
{
    Console.WriteLine("Course Name " + course.Name);
}

