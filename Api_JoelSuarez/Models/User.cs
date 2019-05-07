using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api_JoelSuarez.Models
{
    public class User
    {
        [Key]
        public string name { get; set; }
        public string last_name { get; set; }
        public string password { get; set; }
    }
}
