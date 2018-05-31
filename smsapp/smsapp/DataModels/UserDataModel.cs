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
        public UserRights UserRights { set; get; }

        /// <summary>
        /// Права  пользователя  на  отправку  смс-уведомлении
        /// Can send message to the server
        /// </summary>
        public bool CanSendMessage { set; get; }

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

    public enum UserRights
    {
        /// <summary>
        /// Данные  о  ФХ  и  их  владельца
        /// </summary>
        CanEditFarmData,
        /// <summary>
        /// Данные  о  видах  с/х  культур
        /// </summary>
        CanEditCultureType,
        /// <summary>
        /// Данные  о  вредителях  и  болезнях  с/х  культур
        /// </summary>
        CanEditDesease
    }
}
