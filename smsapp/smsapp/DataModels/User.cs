using System;

namespace smsapp
{
    /// <summary>
    /// Model for the User
    /// </summary>
    public class User
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
        /// Email of the user
        /// </summary>
        public string Email { set; get; }

        /// <summary>
        /// Created date
        /// </summary>
        public DateTime CreateDate { set; get; }
    }
}
