using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.Service.Computer.Data
{
    public class Computer
    {
        /// <summary>
        /// Computer Identifier
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Serial Number of the Computer
        /// </summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// Tag of the Computer
        /// </summary>
        public string ItemTag { get; set; }
        /// <summary>
        /// Model of the Computer
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// RAM of the Computer
        /// </summary>
        public RAM Ram { get; set; }
        /// <summary>
        /// HDD of the Computer
        /// </summary>
        public HDD Hdd { get; set; }
        /// <summary>
        /// SSD of the computer
        /// </summary>
        public SSD Ssd { get; set; }
        /// <summary>
        /// Processor of the Computer
        /// </summary>
        public Processor Processor { get; set; }
        /// <summary>
        /// Brand of the Computer
        /// </summary>
        public Brand Brand { get; set; }
        /// <summary>
        /// Computer Asigned to
        /// </summary>
        public string AsignedTo { get; set; }
        public bool HasSsd { get { return Ssd != null; } }
        public bool HasHdd { get { return Hdd != null; } }
    }
}