using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api_JoelSuarez.Models
{
    public class ProjectItemTwo
    {
        //[Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public System.TimeSpan Creation_Date { get; set; }
        public bool IsActive { get; set; }

        //[ForeignKey("Owner")]
        //public Person PersonOwner { get; set; }

        // Other foreing key implementation
        public int PersonId { get; set; }
        //public Person Person { get; set; }
    }
}
