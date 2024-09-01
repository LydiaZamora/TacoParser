using System;
using System.Linq;
using System.IO;
using GeoCoordinatePortable;

namespace LoggingKata
{
    class Program
    {
        static readonly ILog logger = new TacoLogger();
        const string csvPath = "TacoBell-US-AL.csv";

        static void Main(string[] args)
        {
            logger.LogInfo("Log initialized");

            var lines = File.ReadAllLines(csvPath);

            if(lines.Length == 0)
            {
                logger.LogError("Log Error: no input received.");
            }
            else if(lines.Length == 1)
            {
                logger.LogWarning("Log Warning: Only 1 input received.");
            }

            logger.LogInfo($"Lines: {lines[0]}");

            var parser = new TacoParser();

            var locations = lines.Select(parser.Parse).ToArray();

            ITrackable tacoBell1 = null;
            ITrackable tacoBell2 = null;

            double distance = 0;

            // FIRST FOR LOOP -
            // TODO: Create a loop to go through each item in your collection of locations.
            for(int i = 0; i < locations.Length; i++)
            {
                var locA = locations[i];
                var corA = new GeoCoordinate();
                // need fixing. // TODO: Once you have locA, create a new Coordinate object called `corA` with your locA's latitude and longitude.
                


            }




            // SECOND FOR LOOP -
            // TODO: Now, Inside the scope of your first loop, create another loop to iterate through locations again.
            // This allows you to pick a "destination" location for each "origin" location from the first loop. 
            // Naming suggestion for variable: `locB`

            // TODO: Once you have locB, create a new Coordinate object called `corB` with your locB's latitude and longitude.

            // TODO: Now, still being inside the scope of the second for loop, compare the two locations using `.GetDistanceTo()` method, which returns a double.
            // If the distance is greater than the currently saved distance, update the distance variable and the two `ITrackable` variables you set above.

            // NESTED LOOPS SECTION COMPLETE ---------------------

            // Once you've looped through everything, you've found the two Taco Bells farthest away from each other.
            // Display these two Taco Bell locations to the console.



        }
    }
}
