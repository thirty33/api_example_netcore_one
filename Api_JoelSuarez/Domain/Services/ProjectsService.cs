using Api_JoelSuarez.Domain.Repositories;
using Api_JoelSuarez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_JoelSuarez.Domain.Services
{
    public interface IProjectsService
    {
        //Task<IEnumerable<ProjectItemTwo>> ListAsync();
        Task<IEnumerable<Person>> ListPersonsAsync();
    }

    public class ProjectsService : IProjectsService
    {
        private readonly IPersonRepository _personRepository;

        public  ProjectsService(IPersonRepository categoryRepository)
        {
            this._personRepository = categoryRepository;
        }

        public async Task<IEnumerable<Person>> ListPersonsAsync()
        {
            return await _personRepository.ListPersonsAsync();
        }
    }
}
