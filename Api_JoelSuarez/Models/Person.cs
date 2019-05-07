using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api_JoelSuarez.Models
{
    public class Person
    {
        //[Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public string Password { get; set; }

        public System.TimeSpan Creation_Date { get; set; }

        public System.DateTime creation_information { get; set; }
        public bool isActive { get; set; }

        //Entity relationShip, collection navigation property.
        //public List<ItemProject> personProjects { get; set; }

        //One to Many relationship
        public IList<ProjectItemTwo> projectsByPerson  { get; set; } = new List<ProjectItemTwo>();

    }
}
