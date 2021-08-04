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
        /// Ghosts needs a position. This autoimplemented property
        /// </summary>
        public Position ghostPosition { get; set; }

        /// <summary>
        /// Every ghost has a specific color. By creating a property we will
        /// be able to acess and find out what color that specific ghost is.
        /// </summary>
        public ColorOfComponent ghostColor { get; }
    }
}
