﻿using System;

namespace smsapp.DataModels
{
    class SoilReadings
    {

        /// <summary>
        /// Id
        /// </summary>
        public string ID { set; get; }

        /// <summary>
        /// Created time of the soil condition
        /// </summary>
        public DateTime Date { set; get; }

        /// <summary>
        /// Humus level
        /// </summary>
        public int HumusLevel { set; get; }

        /// <summary>
        /// Pottasium level
        /// </summary>
        public int PottasiumLevel { set; get; }

        /// <summary>
        /// Phosphorus level
        /// </summary>
        public int PhosphurusLevel { set; get; }

        /// <summary>
        /// Acidity level
        /// </summary>
        public int AcidityLevel { set; get; }

        /// <summary>
        /// Soil fertility level
        /// </summary>
        public int SoilFertilityRating { set; get; }

        /// <summary>
        /// Additional notes
        /// </summary>
        public string AdditionalNotes { set; get; }

        public string GeoPositionID { set; get; }

    }
}
