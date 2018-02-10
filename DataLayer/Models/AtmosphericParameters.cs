using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    /// <summary>
    /// Defines atmosphere
    /// </summary>
    public class AtmosphericParameters
    {
        public bool IsPresent { get; set; }
        public bool IsBreathable { get; set; }
        public int Height { get; set; }
        public double SurfacePressure { get; set; }
        
        /// <summary>
        /// Parametrized constructor
        /// </summary>
        /// <param name="isPresent">Defines if given body has an atmosphere</param>
        /// <param name="isBreathable">Defines if jet engine operation possible</param>
        /// <param name="height">Defines height of an atmosphere</param>
        /// <param name="pressure">Defines surface pressure (kPa)</param>
        public AtmosphericParameters(bool isPresent, bool isBreathable, int height, double pressure)
        {
            this.IsPresent = isPresent;
            this.IsBreathable = isBreathable;
            this.Height = Height;
            this.SurfacePressure = pressure;
        }
    }
}
