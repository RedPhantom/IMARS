using System;
using System.Collections.Generic;

namespace IMARS.Data.Models
{
    /// <summary>
    /// Describes a file.
    /// </summary>
    class File
    {
        public int FileId { get; set; }

        public string Title { get; set; }

        public string FileName { get; set; }

        public FileType Type { get; set; }
        
        /// <summary>
        /// Parsing this information is depending on the <see cref="Type"/> value.
        /// </summary>
        public string Metadata { get; set; }
        
        public List<Message> Messages { get; set; }
        
        public List<Eva> Evas { get; set; }
        
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

    enum FileType
    {
        Photo,
        Video,
        Document,
    }
}
