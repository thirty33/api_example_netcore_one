using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Api_JoelSuarez.Domain.Services;
using Api_JoelSuarez.Models;

namespace Api_JoelSuarez.Controllers
{
    //Creating a firts Controller
    [Route("/api/[controller]")]
    public class ReturnPersonsController : Controller
    {
        private readonly IProjectsService _projectsService;

        public ReturnPersonsController(IProjectsService projectsService)
        {
            _projectsService = projectsService;
        }

        [HttpGet]
        public async Task<IEnumerable<Person>> GetPersonsAsync()
        {
            var persons = await _projectsService.ListPersonsAsync();
            return persons;
        }
    }
}
