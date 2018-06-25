using System;

namespace smsapp
{
    public class Contagion
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { set; get; }

        /// <summary>
        /// Farm plant id
        /// </summary>
        public string FarmPlantsID { set; get; }

        /// <summary>
        /// Damage in money
        /// </summary>
        public float DamageInMoney { set; get; }

        /// <summary>
        /// Damaege in crop volume
        /// </summary>
        public float DamageInCropVolume { set; get; }

        /// <summary>
        /// Damage in percentage
        /// </summary>
        public float DamageInPercentage { set; get; }

        /// <summary>
        /// Additional notes
        /// </summary>
        public string AdditionalNotes { set; get; }

        /// <summary>
        /// Pest id
        /// </summary>
        public string PestID { set; get; }

        /// <summary>
        /// Disease id
        /// </summary>
        public string DiseaseID { set; get; }

        /// <summary>
        /// Create time
        /// </summary>
        public DateTime CreateTime { set; get; }

        /// <summary>
        /// Update time
        /// </summary>
        public DateTime UpdateTime { set; get; }
    }
}
