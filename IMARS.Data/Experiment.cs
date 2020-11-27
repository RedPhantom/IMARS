using System;
using System.Collections.Generic;

namespace IMARS.Data
{
    /// <summary>
    /// Describes a science experiment.
    /// </summary>
    class Experiment
    {
        public DateTime StartUTC { get; set; }
        public DateTime EndUTC { get; set; }

        // TODO: link to Mission.

        #region Metadata
        public DateTime CreationUTC { get; set; }
        public DateTime ModificationUTC { get; set; }
        public List<RecordHistoryUpdate> RecordHistory { get; set; }
        #endregion
    }

    enum ExperimentStatus
    {
        Canceled,
        Pending, 
        Ongoing,
        Complete,
    }
}
