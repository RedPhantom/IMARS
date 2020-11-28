using System;
using System.Collections.Generic;

namespace IMARS.Data.Models
{
    /// <summary>
    /// Describes an application user.
    /// </summary>
    class User
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Astronaut's designation such as A1 or B3.
        /// </summary>
        public string Designation { get; set; }

        /// <summary>
        /// Professional roles in a mission.
        /// </summary>
        public List<Role> Roles { get; set; }

        // TODO: link to Mission.
        // TODO: construct an indentity user.

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
}
