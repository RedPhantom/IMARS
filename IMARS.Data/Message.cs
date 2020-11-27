using System;
using System.Collections.Generic;
using System.Text;

namespace IMARS.Data
{
    /// <summary>
    /// Describes a text communication message.
    /// </summary>
    class Message
    {
        // TODO: link to Channel.
        // TODO: link to Media.

        #region Metadata
        public DateTime CreationUTC { get; set; }
        public DateTime ModificationUTC { get; set; }
        public List<RecordHistoryUpdate> RecordHistory { get; set; }
        #endregion
    }
}
