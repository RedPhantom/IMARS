using System;
using System.Collections.Generic;
using System.Text;

namespace IMARS.Data
{
    /// <summary>
    /// Describes a media file.
    /// </summary>
    class Media
    {
        public string Title { get; set; }
        public MediaType Type { get; set; }
        
        /// <summary>
        /// Parsing this information is depending on the <see cref="Type"/> value.
        /// </summary>
        public string Metadata { get; set; }

        /// <summary>
        /// Creator or photographer of this media.
        /// </summary>
        public User Owner { get; set; }

        // TODO: add file-path property.
        // TODO: link to Message.
        // TODO: link to Eva.
        // TODO: link to Person/User.

        #region Metadata
        public DateTime CreationUTC { get; set; }
        public DateTime ModificationUTC { get; set; }
        public List<RecordHistoryUpdate> RecordHistory { get; set; }
        #endregion
    }

    enum MediaType
    {
        Photo,
        Video,
        Document,
    }
}
