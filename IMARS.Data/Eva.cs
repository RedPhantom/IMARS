using System;
using System.Collections.Generic;

namespace IMARS.Data
{
    /// <summary>
    /// Describes an extra-vehicular activity.
    /// </summary>
    class Eva
    {
        public DateTime StartUTC { get; set; }
        public DateTime EndUTC { get; set; }

        /// <summary>
        /// Only the astronauts that left the airlock. 
        /// </summary>
        public List<Astronaut> Participants { get; set; }

        // TODO: link to Mission.
        // TODO: link to Tasks.
        // TODO: link to Medias.

        #region Metadata
        public DateTime CreationUTC { get; set; }
        public DateTime ModificationUTC { get; set; }
        public List<RecordHistoryUpdate> RecordHistory { get; set; }
        #endregion
    }

    enum EvaStatus
    {
        Canceled,
        Pending,
        Ongoing,
        Complete,
    }
}
