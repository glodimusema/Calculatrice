using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class connexion
    {
        public string chemin;

        public void connect()
        {
            chemin = File.ReadAllText("").Trim();
        }
    }
}
