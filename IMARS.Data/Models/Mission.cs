using System;
using System.Collections.Generic;

namespace IMARS.Data.Models
{
    /// <summary>
    /// Describes a mission.
    /// </summary>
    class Mission
    {
        public int MissionId { get; set; }
        
        public string Title { get; set; }

        public DateTime StartUTC { get; set; }

        public DateTime EndUTC { get; set; }

        public List<User> Participants { get; set; }

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

    enum MissionStatus
    {
        Canceled,
        Pending,
        Ongoing,
        Complete,
    }
}
