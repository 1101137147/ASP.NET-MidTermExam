using Coursecode.Dao.Base;
using Coursecode.Dao.Mapper;
using Coursecode.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;


namespace Coursecode.Dao.Impl
{
    class CourseDao : GenericDao<Course>, ICourseDao
    {
        override protected IRowMapper<Course> GetRowMapper()
        {
            return new CourseRowMapper();
        }

        public IList<Course> GetAllCourse()
        {
            string command = @"SELECT * FROM Course ORDER BY CourseID ASC";
            IList<Course> Course = ExecuteQueryWithRowMapper(command);
            return Course;
        }

        public Course GetCourseByName(string CourseName)
        {
            string command = @"SELECT * FROM Course WHERE CourseName = @CourseName";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("CourseName", DbType.String).Value = CourseName;

            IList<Course> Course = ExecuteQueryWithRowMapper(command, parameters);
            if (Course.Count > 0)
            {
                return Course[0];
            }

            return null;
        }
    }
}
