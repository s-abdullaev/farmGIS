﻿using System;

namespace smsapp
{
    public class Pest
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { set; get; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// Code
        /// </summary>
        public string Code { set; get; }

        /// <summary>
        /// Scientific name
        /// </summary>
        public string ScientificName { set; get; }

        /// <summary>
        /// Agricultural name
        /// </summary>
        public string AgriculturalName { set; get; }

        /// <summary>
        /// Scientific classification
        /// </summary>
        public string ScientificClassification { set; get; }

        /// <summary>
        /// Agricultural classification
        /// </summary>
        public string AgriculturalClassification { set; get; }

        /// <summary>
        /// Risks
        /// </summary>
        public string Risks { set; get; }

        /// <summary>
        /// Danger rating
        /// </summary>
        public int DangerRating { set; get; }

        /// <summary>
        /// Speed of grows
        /// </summary>
        public float SpeedOfGrows { set; get; }

        /// <summary>
        /// Vaccinations
        /// </summary>
        public string Prevention { set; get; }

        /// <summary>
        /// Diagnostics
        /// </summary>
        public string Detection { set; get; }

        /// <summary>
        /// Treatment
        /// </summary>
        public string Treatment { set; get; }

        /// <summary>
        /// Prognosis
        /// </summary>
        public string Prognosis { set; get; }

        /// <summary>
        /// Lifespan
        /// </summary>
        public DateTime LifeSpan { set; get; }

        /// <summary>
        /// Addtional notess
        /// </summary>
        public string AdditionalNotes { set; get; }

    }
}
