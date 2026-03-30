using ConsoleApp1.Managers;
using ConsoleApp1.Repository;

internal class Program
{
    private static void Main(string[] args)
    {
        CourseRepository courseRepo = new CourseRepository();
        StudentRepository studentRepo = new StudentRepository();

        CourseManager courseManager = new CourseManager(courseRepo);
        StudentManager studentManager = new StudentManager(studentRepo, courseRepo);

        MainMenu menu = new MainMenu();
        menu.ShowMenu();
    }
}