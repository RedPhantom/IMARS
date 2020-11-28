using System;

namespace IMARS.Data.Models
{
    /// <summary>
    /// Describes an update in a record. Serialized.
    /// </summary>
    class RecordHistoryUpdate
    {
        /// <summary>
        /// The UserId of the change maker.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// The UTC date and time of the change.
        /// </summary>
        public DateTime DateTimeUTC { get; set; }

        /// <summary>
        /// A description of the change (fields, values etc.).
        /// </summary>
        public string Description { get; set; }
    }
}
