using System;
using System.Collections.Generic;

namespace IMARS.Data.Models
{
    /// <summary>
    /// Describes a communication channel.
    /// </summary>
    class Channel
    {
        public int ChannelId { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Serialized list of <see cref="Permission"/>.
        /// </summary>
        public string Permissions { get; set; }
        // TODO: add method to serialize and deserialize permissions.

        public List<Message> Messages { get; set; }

        #region Metadata
        public DateTime CreationUTC { get; set; }
        public DateTime ModificationUTC { get; set; }
        public string RecordHistoryUpdates { get; set; }
        #endregion

        public List<Permission> GetPermissions()
        {
            return (List<Permission>)Utilities.SerializerDeserializer.Deserialize<List<Permission>>(Permissions);
        }

        public void SerPermissions(List<Permission> permissions)
        {
            Permissions = Utilities.SerializerDeserializer.Serialize(permissions);
        }

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
