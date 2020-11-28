using System;
using System.Collections.Generic;

namespace IMARS.Data.Models
{
    /// <summary>
    /// Describes an extra-vehicular activity.
    /// </summary>
    class Eva
    {
        public int EvaId { get; set; }

        public DateTime StartUTC { get; set; }

        public DateTime EndUTC { get; set; }

        /// <summary>
        /// Only the astronauts that left the airlock. 
        /// </summary>
        public List<User> Participants { get; set; }

        public Mission Mission { get; set; }

        public List<Task> Tasks { get; set; }

        public List<File> Media { get; set; }

        #region Metadata
        public DateTime CreationUTC { get; set; }
        public DateTime ModificationUTC { get; set; }
        public string RecordHistoryUpdates { get; set; }
        #endregion

        public List<RecordHistoryUpdate> GetRecordHistoryUpdates()
        {
            return (List<RecordHistoryUpdate>)Utilities.SerializerDeserializer.Deserialize<List<RecordHistoryUpdate>>(RecordHistoryUpdates);
        }

        public void SetRecordHistoryUpdates(List<RecordHistoryUpdate> recordHistoryUpdates)
        {
            RecordHistoryUpdates = Utilities.SerializerDeserializer.Serialize(recordHistoryUpdates);
        }
    }

    enum EvaStatus
    {
        Canceled,
        Pending,
        Ongoing,
        Complete,
    }
}
