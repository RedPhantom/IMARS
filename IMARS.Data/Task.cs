using System;
using System.Collections.Generic;

namespace IMARS.Data
{
    /// <summary>
    /// Describes a task.
    /// </summary>
    class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskStatus Status { get; set; }

        public DateTime StartUTC { get; set; }
        public DateTime CompletionUTC { get; set; }

        // TODO: Link to Eva.
        // TODO: Link to Mission.
        // TODO: Link to Message.

        #region Metadata
        public DateTime CreationUTC { get; set; }
        public DateTime ModificationUTC { get; set; }
        public List<RecordHistoryUpdate> RecordHistory { get; set; }
        #endregion
    }

    enum TaskStatus
    {
        Canceled,
        Pending,
        Ongoing,
        Complete,
    }
}
