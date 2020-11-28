using System;
using System.Collections.Generic;

namespace IMARS.Data.Models
{
    /// <summary>
    /// Describes a role for an astronaut, an operator or other personnel.
    /// </summary>
    class Role
    {
        public int RoleId { get; set; }

        public string Title { get; set; }

        public RoleType Type { get; set; }

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

    enum RoleType 
    { 
        Astronaut,
        Operator,
        Other
    }
}
