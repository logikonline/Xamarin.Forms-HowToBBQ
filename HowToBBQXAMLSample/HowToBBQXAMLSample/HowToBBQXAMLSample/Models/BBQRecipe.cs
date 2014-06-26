using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToBBQXAMLSample.Models
{
    public class BBQRecipe
    {
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string Ingredients { get; set; }
        public string Directions { get; set; }
        public int PrepTime { get; set; }
        public int TotalTime { get; set; }
        public int Serves { get; set; }
        public string ImageSource { get; set; }
    }
}
