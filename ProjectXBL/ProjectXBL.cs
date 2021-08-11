
using ProjectXDAL;
using ProjectXDTO;
using RevisedActivityDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectXBAL
{
    public class ProjectXBL
    {
        ProjectXDLFaculty facDALObj;
        ProjectXDLGrader graDALObj;
        ProjectXDLCourse courseDALObj;
        public ProjectXBL()
        {
            facDALObj = new ProjectXDLFaculty();
            graDALObj = new ProjectXDLGrader();
            courseDALObj = new ProjectXDLCourse();
        }


        //API
        public List<FacultyDTO> GetAllFaculties()
        {

            var facList = facDALObj.FetchAllFaculties();
            return facList;

        }

        //API
        public List<GraderDTO> GetAllGrader()
        {

            var graList = graDALObj.FetchAllGrader();
            return graList;

        }

        //API
        public List<CourseDTO> GetAllCourses()
        {

            var courseList = facDALObj.FetchAllCourses();
            return courseList;

        }
    }
}