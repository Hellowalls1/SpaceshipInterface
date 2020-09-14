using System;

namespace SpaceInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            //array of type rover that holds all data above
            // Rover[] rovers = {lunokhod, apollo, sojourner};

            // DirectAll(rovers);


            //all of rovers and sputnik are Probes

            // Object[] probes = {lunokhod, apollo, sojourner, sputnik}; 

            //we can define methods/etc in IDirectable.cs and utilize them across the board for all of these different classes

            IDirectable[] probes = { lunokhod, apollo, sojourner, sputnik };

            DirectAll(probes);
        }

        // //getting the type of each object in the array
        //   foreach(Object p in probes )
        //     {
        //       Console.WriteLine($"Tracking a {p.GetType()}");
        //     }
        //   }

        //for each over in the array call these methods and print them to the console. They are all defined in Rover.Cs
        public static void DirectAll(IDirectable[] probes)
        {
            foreach (IDirectable p in probes)
            {
                Console.WriteLine(p.GetInfo());
                Console.WriteLine(p.Explore());
                Console.WriteLine(p.Collect());
            }
        }
    }
}
