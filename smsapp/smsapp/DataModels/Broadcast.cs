using System;

namespace smsapp
{
    public class Broadcast
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { set; get; }

        /// <summary>
        /// Contagion id
        /// </summary>
        public string ContagionID { set; get; }

        /// <summary>
        /// Message text
        /// </summary>
        public string MessageText { set; get; }

        /// <summary>
        /// Warning level
        /// </summary>
        public int WarningLevel { set; get; }

        /// <summary>
        /// Date
        /// </summary>
        public DateTime Date { set; get; }

    }
}
