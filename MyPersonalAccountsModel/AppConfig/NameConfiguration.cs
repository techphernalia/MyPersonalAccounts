using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.techphernalia.MyPersonalAccounts.Model.AppConfig
{
    /// <summary>
    /// Configuration of Names (for System Id)
    /// </summary>
    public class NameConfiguration
    {
        /// <summary>
        /// Unique Identifier of Configuration
        /// </summary>
        public int ConfigurationId { get; set; }

        /// <summary>
        /// Name of Configuration
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// Prefix for System ID
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Suffix for System ID
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// Length of Item ID to be used
        /// </summary>
        public int IDLength { get; set; }
    }
}
