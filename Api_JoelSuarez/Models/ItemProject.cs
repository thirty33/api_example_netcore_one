using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api_JoelSuarez.Models
{
    public class ItemProject
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public System.TimeSpan Creation_Date { get; set; }
        public bool isActive { get; set; }

        //Entity relationShip

        //Foreing Key
        public int UserId { get; set; }

        //Reference Navigation Property
        public Person Owner { get; set; }
    }
}
