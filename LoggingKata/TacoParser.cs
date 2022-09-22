using System;
using System.Linq; 

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                Console.WriteLine($"Error: Cells.Length is: {cells.Length}, which is less than 3"); 
                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }

            // grab the latitude from your array at index 0
            var latitude = double.Parse(cells[0]);
            // grab the longitude from your array at index 1
            var longitude = double.Parse(cells[1]);
            // grab the name from your array at index 2
            var name = cells[2];

            // Your going to need to parse your string as a `double`
            // Done, please check code above

            // which is similar to parsing a string as an `int`
            // Done, please check code above

            // You'll need to create a TacoBell class
            // that conforms to ITrackable
            // Done, refer to TacoBell class file. 

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly
            var location = new Point () { Latitude = latitude, Longitude = longitude };
            var tacoBellObj = new TacoBell() {
            Name = name,
            Location = location
            };

            // Then, return the instance of your TacoBell class
            return tacoBellObj;
            // Since it conforms to ITrackable
        }
    }
}