using System;
using System.Collections.Generic;

namespace IMARS.Data.Models
{
    /// <summary>
    /// Describes a tag.
    /// </summary>
    class Tag
    {
        public int TagId { get; set; }

        public string Title { get; set; }

        /// <summary>
        /// Valid values are ones that comply with CSS syntax.
        /// </summary>
        /// <example>
        /// #ff0000
        /// rgb(255, 0, 0)
        /// "red"
        /// </example>
        public string Color { get; set; }

        #region Metadata
        public DateTime CreationUTC { get; set; }
        public DateTime ModificationUTC { get; set; }
        public string RecordHistoryUpdates { get; set; }
        #endregion
    }
}
