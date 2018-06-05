using System;

namespace smsapp
{
    public class FarmPlants
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { set; get; }

        /// <summary>
        /// Geoposition id
        /// </summary>
        public string GeopositionID { set; get; }

        /// <summary>
        /// Plant id
        /// </summary>
        public string PlantID { set; get; }

        /// <summary>
        /// date of sowing
        /// </summary>
        public DateTime DateOfSowing { set; get; }

        /// <summary>
        /// Grows status
        /// </summary>
        public string GrowthStatus { set; get; }

        /// <summary>
        /// Damage status
        /// </summary>
        public string DamageStatus { set; get; }

        /// <summary>
        /// Expected yield
        /// </summary>
        public float ExpectedYield { set; get; }

        /// <summary>
        /// Additional notes
        /// </summary>
        public string AdditionalNotes { set; get;}

        /// <summary>
        /// Initial investment
        /// </summary>
        public float InitialInvestment { set; get;}

    }
}
