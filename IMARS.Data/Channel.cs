using System;
using System.Collections.Generic;
using System.Text;

namespace IMARS.Data
{
    /// <summary>
    /// Describes a communication channel.
    /// </summary>
    class Channel
    {
        public string Name { get; set; }

        // TODO: link to Messages.

        #region Metadata
        public DateTime CreationUTC { get; set; }
        public DateTime ModificationUTC { get; set; }
        public List<RecordHistoryUpdate> RecordHistory { get; set; }
        #endregion
    }
}
