using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        [HttpGet]

        public async Task<ActionResult<List<Project>>> GetProjects() 
        {
            return new List<Project>
            {
                new Project
                {
                    ProjectName="project1",
                    StartDateString="10.10.2022 10:45",
                    StopDateString="10.10.2022 10:55",
                    Duration="00:10"


                }

            };
        
        }
    }
}
