using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.Service.Computer.Data
{
    public class Processor
    {
        /// <summary>
        /// Processor Identifier
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Brand of the Processor
        /// </summary>
        public Brand Brand { get; set; }
        /// <summary>
        /// Clock Speed of the Procesor in GHz
        /// </summary>
        public double ClockSpeed { get; set; }
        /// <summary>
        /// Model of the Processor
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Cores of the Processor
        /// </summary>
        public int Cores { get; set; }
    }
}