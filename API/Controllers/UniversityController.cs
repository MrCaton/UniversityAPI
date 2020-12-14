using API.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class UniversityController: ControllerBase
    {
        private UniversityRepostiory repo;

        public UniversityController(UniversityContext context)
        {
            repo = new UniversityRepostiory(context);
        }
    }
}
