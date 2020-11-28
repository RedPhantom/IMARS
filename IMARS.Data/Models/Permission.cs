using System.Collections.Generic;

namespace IMARS.Data.Models
{
    /// <summary>
    /// Describes a permission. Serializable.
    /// </summary>
    class Permission
    {
        public PermissionType Type { get; set; }

        public List<Role> Roles { get; set; }
    }

    enum PermissionType
    {
        Read,
        Write
    }
}
