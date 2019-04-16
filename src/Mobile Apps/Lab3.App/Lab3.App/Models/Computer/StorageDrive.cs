using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.Service.Computer.Data
{
    public class StorageDrive
    {
        /// <summary>
        /// Storage Drive Identifier
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Model of the Storage Drive
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Capacity of the Storage Drive in GB
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// Tag of the Storage Drive
        /// </summary>
        public string ItemTag { get; set; }
        /// <summary>
        /// Brand of the Storage Drive
        /// </summary>
        public Brand Brand { get; set; }
    }
}