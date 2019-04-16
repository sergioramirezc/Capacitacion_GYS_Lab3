using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.Service.Computer.Data
{
    public class SSD
    {
        /// <summary>
        /// SSD Identifier
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Interface connector of the SSD
        /// </summary>
        public string Interface { get; set; }
        public StorageDrive StorageDrive { get; set; }
    }
}