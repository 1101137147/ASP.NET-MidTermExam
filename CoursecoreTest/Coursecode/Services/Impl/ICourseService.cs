using Coursecode.Dao;
using Coursecode.Models;
using System.Collections.Generic;

namespace Coursecode.Services.Impl
{
    public interface ICourseService
    {
        IList<Course> GetAllCourse();

        Course GetCourseByName(string CourseName);
    }
}
