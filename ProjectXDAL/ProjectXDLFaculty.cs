
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectXDTO;


namespace RevisedActivityDAL
{
    public class ProjectXDLFaculty
    {
        public List<FacultyDTO> FetchAllFaculties()

        {
            try
            {
                List<FacultyDTO> lstFaculties = new List<FacultyDTO>();
                MiniProjectConStr advContextDTO = new MiniProjectConStr();
                var facDALListOfObjects = advContextDTO.Faculties.ToList();
                foreach (var fac in facDALListOfObjects)
                {
                    lstFaculties.Add(new FacultyDTO
                    {
                        Name = fac.Name,
                        Psnumber = fac.Psnumber,
                        EmailId = fac.EmailId

                    }
                    );

                }
                return lstFaculties;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
