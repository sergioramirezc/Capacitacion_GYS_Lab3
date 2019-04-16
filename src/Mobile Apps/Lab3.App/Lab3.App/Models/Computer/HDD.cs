using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.Service.Computer.Data
{
    public class HDD
    {
        /// <summary>
        /// HDD Identifier
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Revolutions per minutes of the HDD
        /// </summary>
        public string Rpm { get; set; }
        public StorageDrive StorageDrive { get; set; }
    }
}