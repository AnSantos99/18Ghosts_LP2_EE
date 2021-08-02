using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    interface IGhost
    {
        /// <summary>
        /// To know what type of ghost we are handling with
        /// </summary>
        public string ghostType { get; }

        /// <summary>
        /// Ghosts will need a position
        /// </summary>
        public Position ghostPosition { get; set; }


    }
}
