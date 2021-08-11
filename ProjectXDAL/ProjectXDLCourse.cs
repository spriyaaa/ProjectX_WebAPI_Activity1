using ProjectXDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectXDAL
{
    public class ProjectXDLCourse
    {
        public List<CourseDTO> FetchAllCourses()

        {
            try
            {
                List<CourseDTO> lstCourses = new List<CourseDTO>();
                MiniProjectConStr advContextDTO = new MiniProjectConStr();
                var courseDALListOfObjects = advContextDTO.Courses.ToList();
                foreach (var course in courseDALListOfObjects)
                {
                    lstCourses.Add(new CourseDTO
                    {
                        CourseID = course.CourseID,
                        CourseOwner= course.CourseOwner,
                        CourseTitle = course.CourseTitle,
                        AssessmentMode = course.AssessmentMode,
                        HoursAssigned = course.HoursAssigned,
                        CourseSyllabus = course.CourseSyllabus

                    }
                    );

                }
                return lstCourses;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}

