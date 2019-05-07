using Api_JoelSuarez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_JoelSuarez.Domain.Repositories
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> ListPersonsAsync();
    }
}
