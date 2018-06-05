using System;

namespace smsapp
{
    public class Plant
    {
        /// <summary>
        /// Id
        /// </summary>
        public string ID { set; get; }

        /// <summary>
        /// Scientific name
        /// </summary>
        public string ScientificName { set; get; }

        /// <summary>
        /// Agricultural name 
        /// </summary>
        public string AgriculturalName { set; get; }

        /// <summary>
        /// VendorCode
        /// </summary>
        public string VendorCode { set; get; }

        /// <summary>
        /// Code
        /// </summary>
        public string IAPTCode { set; get; }

        /// <summary>
        /// Classification
        /// </summary>
        public int AgriculturalClassification { set; get; }

        /// <summary>
        /// ScientificClassification
        /// </summary>
        public int ScientificClassification { set; get; }

        /// <summary>
        /// Vendor
        /// </summary>
        public string Vendor { set; get; }

        /// <summary>
        /// Country of origin
        /// </summary>
        public string CountryOfOrigin { set; get; }

        /// <summary>
        /// Life span
        /// </summary>
        public DateTime LifeSpan { set; get; }

        /// <summary>
        /// Additional notes
        /// </summary>
        public string AdditionalNotes { set; get; }

    }

}
