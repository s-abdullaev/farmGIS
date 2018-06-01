namespace smsapp
{
    public class FarmDataModel
    {
        /// <summary>
        /// First name of the user (if needed)
        /// </summary>
        public string FirstName { set; get; }

        /// <summary>
        /// Last name of the user (if needed)
        /// </summary>
        public string LastName { set; get; }

        /// <summary>
        /// The passport id of the user
        /// </summary>
        public string PassportID { set; get; }

        /// <summary>
        /// Contact number of the Farm
        /// </summary>
        public string ContactNumber{ set; get; }

        /// <summary>
        /// Location of the user in the map
        /// </summary>
        public Location Location { set; get; }
    }

    public class Location
    {
        /// <summary>
        /// Lattitude of the location in the map
        /// </summary>
        public float Lattitude { set; get; }

        /// <summary>
        /// Longitude of the location in the map
        /// </summary>
        public float Longitude { set; get; }
    }
}
