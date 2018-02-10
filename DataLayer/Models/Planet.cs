using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    /// <summary>
    /// Defines planet/body charachteristics
    /// </summary>
    public class Planet
    {
        public string Name { get; set; }
        public int Radius { get; set; }
        public int Mass { get; set; }
        public long SphereOfInfluence { get; }
        public OrbitalParameters Orbit { get; set; }
        public AtmosphericParameters Atmosphere { get; set; }
    }
}
