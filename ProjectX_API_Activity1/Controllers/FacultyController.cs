
using Newtonsoft.Json;
using ProjectXBAL;
using ProjectXDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectX_API_Activity1.Controllers
{
    public class FacultyController : ApiController
    { 
        ProjectXBL blObj;

        [HttpGet]
        [ActionName("GetAllFaculties")]
        public HttpResponseMessage GetAllFaculty()
        {
            try
            {
                blObj = new ProjectXBL();
                List<FacultyDTO> lst = blObj.GetAllFaculties();
                if (lst != null)
                {
                    var response = new HttpResponseMessage(HttpStatusCode.OK);
                    response.Content = new StringContent(JsonConvert.SerializeObject(lst));
                    response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    return response;
                }

            }


            catch (Exception ex)
            {
                var response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                response.Content = new StringContent("Something went wrong with the server");
                return response;
            }

        }


        ProjectXBL blObj1;

        [HttpGet]
        [ActionName("GetAllGrader")]
        public HttpResponseMessage GetAllGrader()
        {
            try
            {
                blObj1 = new ProjectXBL();
                List<GraderDTO> lst = blObj1.GetAllGrader();
                if (lst != null)
                {
                    var response = new HttpResponseMessage(HttpStatusCode.OK);
                    response.Content = new StringContent(JsonConvert.SerializeObject(lst));
                    response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    return response;
                }
            }


            catch (Exception ex)
            {
                var response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                response.Content = new StringContent("Something went wrong with the server");
                return response;
            }

        }


        ProjectXBL blObj2;

        [HttpGet]
        [ActionName("GetAllCourses")]
        public HttpResponseMessage GetAllCourses()
        {
            try
            {
                blObj2 = new ProjectXBL();
                List<CourseDTO> lst = blObj.GetAllCourses();
                if (lst != null)
                {
                    var response = new HttpResponseMessage(HttpStatusCode.OK);
                    response.Content = new StringContent(JsonConvert.SerializeObject(lst));
                    response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    return response;
                }
            }


            catch (Exception ex)
            {
                var response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                response.Content = new StringContent("Something went wrong with the server");
                return response;
            }

        }


    }
}
