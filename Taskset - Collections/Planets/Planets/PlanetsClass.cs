using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    public class PlanetsClass
    {
        public string Name { get; set; }
        public int Diameter { get; set; }
        public double RotationP { get; set; }
        public int Moons { get; set; }
        public double DistanceSun { get; set; }
        public double SurfaceTemp { get; set; }

        public PlanetsClass(string name, int diameter, double rotationp, int moons, double distancesun, double surfacetemp)
        {
            Name = name;
            Diameter = diameter;
            RotationP = rotationp;
            Moons = moons;
            DistanceSun = distancesun;
            SurfaceTemp = surfacetemp;
        }

        public override string ToString()
        {
            return $"The Planet: {Name} has a diameter of {Diameter}" +
                   $"a rotation period of {RotationP}," +
                   $"is {DistanceSun}au from the sun," +
                   $"has {Moons} and a surface temp at {SurfaceTemp}";
        }

    }

}
    
