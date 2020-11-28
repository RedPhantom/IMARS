using System;
using System.Collections.Generic;

namespace IMARS.Data.Models
{
    /// <summary>
    /// Describes a mission event.
    /// </summary>
    class Event
    {
        public int EventId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartUTC { get; set; }

        /// <summary>
        /// Tasks that are followups to this event.
        /// </summary>
        /// <example>
        /// The crew was requested to send a report.
        /// This is an event ("msc requested crew for a report"). This event has a followup - 
        /// "receive the report the crew needs to send".
        /// This creates a task - a follow-up task - "get the report from the crew".
        /// </example>
        public List<Task> FollowUpTasks;

        public Mission Mission { get; set; }
        
        public Message Message { get; set; }

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
