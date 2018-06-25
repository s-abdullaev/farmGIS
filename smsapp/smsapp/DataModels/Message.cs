using System;

namespace smsapp
{
    public class Message
    {
        /// <summary>
        /// id
        /// </summary>
        public string ID { set; get; }

        /// <summary>
        /// Broadcast id
        /// </summary>
        public string BroadCastID { set; get; }

        /// <summary>
        /// Has reacted?
        /// </summary>
        public bool HasReacted { set; get; }

        /// <summary>
        /// Feedback
        /// </summary>
        public string Feedback { set; get; }

        /// <summary>
        /// Farm owner id
        /// </summary>
        public string FarmOwnerID { set; get; }

        /// <summary>
        /// Status
        /// </summary>
        public int Status { set; get; }

        /// <summary>
        /// Date
        /// </summary>
        public DateTime Date { set; get; }

    }
}
