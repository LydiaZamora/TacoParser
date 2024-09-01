namespace LoggingKata
{
   
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing...");

            var cells = line.Split(',');

            if (cells.Length < 3)
            {
                logger.LogError("Log error: not enough information.");
                return null; 
            }

            var latitude = double.Parse(cells[0]);

            var longitude = double.Parse(cells[1]);

            var name = cells[2];

            var location = new Point();
            location.Latitude = latitude;
            location.Longitude = longitude;

            var tacoBell = new TacoBell();
            tacoBell.Location = location;
            tacoBell.Name = name;
  
            return tacoBell;
        }
    }
}
