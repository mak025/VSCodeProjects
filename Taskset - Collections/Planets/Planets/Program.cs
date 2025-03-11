using System.Numerics;

namespace Planets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates the list to hold all the planets and their data
            List<PlanetsClass> planets = new List<PlanetsClass>();
            //Adds Mercury to the list
            PlanetsClass mercury = new PlanetsClass("Merkur", 4879, 1407.6, 0, 0.39, 430);
            planets.Add(mercury);
            //Adds Earth to the list
            PlanetsClass earth = new PlanetsClass("Jorden", 12742, 23.9, 1, 1.00, 15);
            planets.Add(earth);
            //Adds Mars to the List
            PlanetsClass mars = new PlanetsClass("Mars", 6779, 24.6, 2, 1.52, -60);
            planets.Add(mars);
            //Adds Jupiter to the list
            PlanetsClass jupiter = new PlanetsClass("Jupiter", 139820, 9.9, 79, 5.20, -108);
            planets.Add(jupiter);
            //Adds Saturn to the list
            PlanetsClass saturn = new PlanetsClass("Saturn", 116460, 10.7, 82, 9.58, -139);
            planets.Add(saturn);
            //Adds Uranus to the list
            PlanetsClass uranus = new PlanetsClass("Uranus", 50724, 17.2, 27, 19.18, -197);
            planets.Add(uranus);
            //Adds Neptune to the list
            PlanetsClass neptune = new PlanetsClass("Neptun", 49244, 16.1, 14, 30.07, -201);
            planets.Add(neptune);
            //Adds Pluto to the list
            PlanetsClass pluto = new PlanetsClass("Pluto", 2376, 153.3, 5, 39.48, -229);
            planets.Add(pluto);

            // Udskriver alle planeter
            foreach (PlanetsClass planet in planets)
            {
                Console.WriteLine(planet.ToString());
            }

            PlanetsClass venus = new PlanetsClass("Venus", 12104, 5832.5, 0, 0.72, 462);
            planets.Insert(1, venus);

            planets.Remove(pluto);

            planets.Add(pluto);
            Console.WriteLine("");
            Console.WriteLine($"Total number of plantes {planets.Count}");

            List<PlanetsClass> ColdPlanets = new List<PlanetsClass>();
            foreach (PlanetsClass planet in planets)
            {
                if (planet.SurfaceTemp < 0)
                {
                    ColdPlanets.Add(planet);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Following are cold planets");
            foreach(PlanetsClass planet in ColdPlanets)
            {
                Console.WriteLine(planet.ToString());
            }

            List<PlanetsClass> PlanetPlusSize = new List<PlanetsClass>();
            foreach (PlanetsClass planet in planets)
            {
                if (planet.Diameter > 10000 && planet.Diameter < 50000)
                {
                    PlanetPlusSize.Add(planet);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Following are over 10000km but under 50000km planets");
            foreach (PlanetsClass planet in PlanetPlusSize)
            {
                Console.WriteLine(planet.ToString());
            }

        }

    }  
}

