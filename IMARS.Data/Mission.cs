using System;
using System.Collections.Generic;

namespace IMARS.Data
{
    /// <summary>
    /// Describes a mission.
    /// </summary>
    class Mission
    {
        public DateTime StartUTC { get; set; }
        public DateTime EndUTC { get; set; }
        public List<Astronaut> Participants { get; set; }

        #region Metadata
        public DateTime CreationUTC { get; set; }
        public DateTime ModificationUTC { get; set; }
        public List<RecordHistoryUpdate> RecordHistory { get; set; }
        #endregion
    }

    enum MissionStatus
    {
        Canceled,
        Pending,
        Ongoing,
        Complete,
    }
}
