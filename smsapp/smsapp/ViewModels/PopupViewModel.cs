namespace smsapp
{
    public class PopupViewModel : BaseViewModel
    {
        private PopupType mPopupType;

        /// <summary>
        /// Type of the current popup
        /// </summary>
        public PopupType PopupType
        {
            set
            {
                switch (value)
                {
                    case PopupType.Success:
                        PopupIcon = "\uf00c";
                        IsWait = false;
                        PopupMessage = "Success !";
                        break;
                    case PopupType.Wait:
                        PopupIcon = "\uf110";
                        PopupMessage = "Please wait ...";
                        IsWait = true;
                        break;
                    case PopupType.Error:
                        PopupIcon = "\uf129";
                        IsWait = false;
                        break;
                }
                mPopupType = value;
            }
            get => mPopupType;
        }

        /// <summary>
        /// Icon of the popup
        /// </summary>
        public string PopupIcon { set; get; }

        /// <summary>
        /// Text of the popup
        /// </summary>
        public string PopupMessage { set; get; }

        /// <summary>
        /// Flag to spin the spinner :)
        /// </summary>
        public bool IsWait { set; get; }

        public PopupViewModel()
        {

        }
    }
}
