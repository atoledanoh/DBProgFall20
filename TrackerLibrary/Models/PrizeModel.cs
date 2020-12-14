namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// unique identifier for the prize
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// numeric interface for the place
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// string name for the place
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// fixed amount this place earns (zero if not used)
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// percentage amount of the overall take (zero if not used). 0.5 for 50%...
        /// </summary>
        public double PrizePercentage { get; set; }
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
