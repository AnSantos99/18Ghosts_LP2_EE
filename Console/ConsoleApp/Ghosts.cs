using System;
using System.Collections.Generic;
using ConsoleApp.Model;

namespace ConsoleApp
{
    class Ghosts
    {
        ICollection<GhostsStructure> ghostsList;

        public Ghosts() 
        {
            ghostsList = new List<GhostsStructure>();
        }

        private void GhostsSetUp() 
        {

        }
    }
}
