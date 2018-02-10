using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.ViewModels
{
    public class BodySystem
    {
        public Planet CentralBody { get; set; }
        public List<Planet> OrbitingBodys { get; set; }
    }
}
