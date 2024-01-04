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

            // If your array's Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log error message and return null
                logger.LogWarning("Error accured, less than three lines. ");

                return null; 
            }

            // DONE: Grab the latitude from your array at index 0
            // You're going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`

            double lat = 0;

            if (double.TryParse(cells[0], out lat) == false)
            {
                logger.LogError($"{cells[0]} Bad data. Unable to parse latitude as a double.");
            }
            
            
            // DONE: Grab the longitude from your array at index 1
            // You're going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`

            double longitude = 1;

            if (double.TryParse(cells[1], out longitude) == false)
            {
                logger.LogError("Bad data. Unable to parse longitude as a double");
            }


            // DONE: Grab the name from your array at index 2

            var name = cells[2];

            if (cells[2] == null || cells[2].Length == 0)
            {
                logger.LogError("No location name found.");
            }


            // DONE: Create a TacoBell class
            // that conforms to ITrackable

            // DONE: Create an instance of the Point Struct
            // DONE: Set the values of the point correctly (Latitude and Longitude) 

            var point = new Point
            {
                Latitude = lat,
                Longitude = longitude
            };


            // DONE: Create an instance of the TacoBell class
            // DONE: Set the values of the class correctly (Name and Location)

            var tacoBell = new TacoBell();

            tacoBell.Location = point;
            tacoBell.Name = name;

            // DONE: Then, return the instance of your TacoBell class,
            // since it conforms to ITrackable



            return tacoBell;
        }
    }
}
