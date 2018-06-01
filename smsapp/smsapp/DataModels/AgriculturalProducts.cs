using System;

namespace smsapp
{
    class AgriculturalProducts
    {
        /// <summary>
        /// Type of the product
        /// </summary>
        public AgruclutrualProductType Type { set; get; }

        /// <summary>
        /// Planted time
        /// </summary>
        public DateTime PlantedTime { set; get; }

        /// <summary>
        /// The estimated harvest
        /// </summary>
        public float ExpectedHarvest { set; get; }

    }
    public enum AgruclutrualProductType
    {
        /// <summary>
        /// Example
        /// </summary>
        Apple=1,
    }
}
