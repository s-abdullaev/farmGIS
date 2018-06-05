using System;

namespace smsapp
{
    public class Farm
    {

        public string ID { set; get; }
        /// <summary>
        /// Fame of the farm (if needed)
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// Adress of the farm
        /// </summary>
        public string Address { set; get; }

        /// <summary>
        /// The located city
        /// </summary>
        public string City { set; get; }

        /// <summary>
        /// Located region
        /// </summary>
        public string Region { set; get; }

        /// <summary>
        /// Certificate number
        /// </summary>
        public string RegistrationCertificateNumber { set; get; }

        /// <summary>
        /// Established year
        /// </summary>
        public int EstablishedYear { set; get; }

        /// <summary>
        /// Area
        /// </summary>
        public float Area { set; get; }

        /// <summary>
        /// Industry type
        /// </summary>
        public int IndustryType { set; get; }

        /// <summary>
        /// Addtional notes
        /// </summary>
        public string AdditionalNotes { set; get; }

        /// <summary>
        /// Url to logo
        /// </summary>
        public string LogoUrl { set; get; }

        /// <summary>
        /// Id of the owner
        /// </summary>
        public string FarmOwnerID { set; get; }

    }


}
