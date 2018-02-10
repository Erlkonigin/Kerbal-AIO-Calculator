using System;

namespace DataLayer.Models
{
    /// <summary>
    /// Defines orbital parameters for a given body
    /// </summary>
    public class OrbitalParameters
    {
        public long SemimajorAxis { get; set; }
        public long SemiminorAxis { get; }
        public double Eccentricty { get; set; }
        public TimeSpan SolarDay { get; set; }
        public TimeSpan OrbitalPeriod { get; set; }

        /// <summary>
        /// Parametrized constructor
        /// </summary>
        /// <param name="semiMajorAxis">Semi-major axis</param>
        /// <param name="eccentricty">Eccentricity</param>
        /// <param name="solarDay">Solar day</param>
        /// <param name="period">Orbital period</param>
        public OrbitalParameters(long semiMajorAxis, double eccentricty, TimeSpan solarDay, TimeSpan period)
        {
            this.SemimajorAxis = semiMajorAxis;
            this.Eccentricty = eccentricty;
            this.SolarDay = solarDay;
            this.OrbitalPeriod = period;
            this.SemiminorAxis = (long)(SemimajorAxis * Math.Sqrt(1 - Math.Pow(Eccentricty, 2)));
        }
    }
}
