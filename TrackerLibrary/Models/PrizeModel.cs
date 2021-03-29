namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Represents tplace number
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents tplace name
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents Prize amount
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents prize percentage
        /// </summary>
        public double PrizePercentage { get; set; }
        // Zabawa !!!!!!!

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;
            
            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
