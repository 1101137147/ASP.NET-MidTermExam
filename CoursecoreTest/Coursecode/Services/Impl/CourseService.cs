using Coursecode.Dao;
using Coursecode.Dao.Impl;
using Coursecode.Models;
using System.Collections.Generic;

namespace Coursecode.Services.Impl
{
    public class CourseService : ICourseService
    {
        public ICourseDao CourseDao = new CourseDao();

        public IList<Course> GetAllEmployees()
        {
            return CourseDao.GetAllEmployees();
        }

        public Course GetCourseByName(string CourseName)
        {
            return CourseDao.GetCourseByName(CourseName);
        }

    }
}
