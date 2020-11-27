using System;
using System.Collections.Generic;

namespace IMARS.Data
{
    /// <summary>
    /// Describes an astronaut.
    /// </summary>
    class Astronaut
    {
        public string Name { get; set; }
        
        /// <summary>
        /// Astronaut's designation such as A1 or B3.
        /// </summary>
        public string Designation { get; set; }

        /// <summary>
        /// Professional roles in a mission.
        /// </summary>
        public List<AstronautRole> Roles { get; set; }

        public User User { get; set; }

        // TODO: link to Mission.
        // TODO: link to User.

        #region Metadata
        public DateTime CreationUTC { get; set; }
        public DateTime ModificationUTC { get; set; }
        public List<RecordHistoryUpdate> RecordHistory { get; set; }
        #endregion
    }

    enum AstronautRole
    {
        // TODO: Add roles.
    }
}
