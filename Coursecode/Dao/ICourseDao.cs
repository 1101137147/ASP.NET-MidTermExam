using Coursecode.Models;
using System;
using System.Collections.Generic;

namespace Coursecode.Dao
{
    public interface ICourseDao
    {

        IList<Course> GetAllEmployees();

        Course GetCourseByName(string CourseName);

    }
}
