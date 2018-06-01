namespace smsapp
{
    /// <summary>
    /// Model for the User
    /// </summary>
    public class UserDataModel
    {
        /// <summary>
        /// Id of the user
        /// </summary>
        public string ID { set; get; }

        /// <summary>
        /// Username
        /// </summary>
        public string Username { set; get; }

        /// <summary>
        /// Password 
        /// </summary>
        public string Password { set; get; }

        /// <summary>
        /// The right of the user to edit data
        /// </summary>
        public int Permissions { set; get; }

        /// <summary>
        /// First name of the user (if needed)
        /// </summary>
        public string FirstName { set; get; }

        /// <summary>
        /// Last name of the user (if needed)
        /// </summary>
        public string LastName { set; get; }

        /// <summary>
        /// Email of the user
        /// </summary>
        public string Email { set; get; }
    }
}
