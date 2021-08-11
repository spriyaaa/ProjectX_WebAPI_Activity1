using ProjectXDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectXDAL
{
    public class ProjectXDLGrader
    {
        public List<GraderDTO> FetchAllGrader()

        {
            try
            {
                List<GraderDTO> lstGrader = new List<GraderDTO>();
                MiniProjectConStr advContextDTO = new MiniProjectConStr();
                var courseDALListOfObjects = advContextDTO.Grader.ToList();
                foreach (var gra in courseDALListOfObjects)
                {
                    lstGrader.Add(new GraderDTO
                    {
                        CourseId = gra.CourseId,
                        NewBatchID = gra.NewBatchID,
                        Result = gra.Result
                    }
                    );

                }
                return lstGrader;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}

    