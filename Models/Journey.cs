using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class Journey
    {
        public int Id { get; set; }
        public string JourneyTitle{ get; set; }
        public string Address { get; set; }

        public Journey()
        {

        }
    }
}
