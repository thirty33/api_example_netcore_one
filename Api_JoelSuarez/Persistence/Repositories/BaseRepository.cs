using Api_JoelSuarez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_JoelSuarez.Persistence.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly MainDbContext _context;
        public BaseRepository(MainDbContext context)
        {
            _context = context;
        }
    }
}
