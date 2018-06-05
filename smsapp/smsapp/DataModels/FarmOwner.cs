using System;

namespace smsapp
{
    public class FarmOwner
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { set; get; }

        /// <summary>
        /// Last name of the farm owner
        /// </summary>
        public string LastName { set; get; }

        /// <summary>
        /// First name of the farm owner
        /// </summary>
        public string FirstName { set; get; }

        /// <summary>
        /// Passport number of the farm owner
        /// </summary>
        public string PassportNumber { set; get; }

        /// <summary>
        /// Date of birth of farm owner
        /// </summary>
        public DateTime DateOfBirth { set; get; }

        /// <summary>
        /// IsMale
        /// NOTE: 
        ///     if owner is male it is true (1)
        ///     else it is false(0)
        /// </summary>
        public bool Gender { set; get; }

        /// <summary>
        /// PhoneNumber
        /// </summary>
        public string MobilePhone1 { set; get; }
        /// <summary>
        /// PhoneNumber
        /// </summary>
        public string MobilePhone2 { set; get; }
        /// <summary>
        /// HomeNumber
        /// </summary>
        public string HomePhone1 { set; get; }
        /// <summary>
        /// HomeNumber
        /// </summary>
        public string HomePhone2 { set; get; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { set; get; }

        /// <summary>
        /// Adress
        /// </summary>
        public string Address { set; get; }

        /// <summary>
        /// City of the farm owner
        /// </summary>
        public string City { set; get; }

        /// <summary>
        /// Region of the farm owner
        /// </summary>
        public string Region { set; get; }

        /// <summary>
        /// AdditionalNotes
        /// </summary>
        public string AdditionalNotes { set; get; }

        /// <summary>
        /// Url to the photo of farm owner
        /// </summary>
        public string PhotoUrl { set; get; }
    }
}
