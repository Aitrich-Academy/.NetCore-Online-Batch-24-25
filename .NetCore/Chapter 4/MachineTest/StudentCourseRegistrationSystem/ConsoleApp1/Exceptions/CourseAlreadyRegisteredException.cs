using System;

namespace StudentCourseRegistrationSystem.Exceptions
{
    public class CourseAlreadyRegisteredException : Exception
    {
        public CourseAlreadyRegisteredException(string message) : base(message) { }
    }
}
