using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.Service.Computer.Data
{
    public class RAM
    {
        public int Id { get; set; }
        /// <summary>
        /// Brand of the RAM
        /// </summary>
        public Brand Brand { get; set; }
        /// <summary>
        /// Capacity of the RAM in GB
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// Tag of the RAM
        /// </summary>
        public string ItemTag { get; set; }
        /// <summary>
        /// Serial Number of the RAM
        /// </summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// Serial Number of the RAM
        /// </summary>
        public string Standart { get; set; }
        /// <summary>
        /// Computer Assigned
        /// </summary>
        public Computer Computer { get; set; }
    }
}