using System.Collections.Generic;
using System.Threading.Tasks;
using Api_JoelSuarez.Domain.Repositories;
using Api_JoelSuarez.Domain.Services;
using Api_JoelSuarez.Models;
using Microsoft.EntityFrameworkCore;


namespace Api_JoelSuarez.Persistence.Repositories
{
    public class PersonRepository : BaseRepository, IPersonRepository
    {
        public PersonRepository(MainDbContext context) : base(context)
        {

        }


        public async Task<IEnumerable<Person>> ListPersonsAsync()
        {
            return await _context.person.ToListAsync();
        }
    }
}
