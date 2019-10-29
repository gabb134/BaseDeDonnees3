using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo10
{
    class NoEtNomClient
    {
        public decimal noClient { get; private set; }
        public String nomCompletClient { get; private set; }

        public NoEtNomClient(decimal noClient, string nomCompletClient)
        {
            this.noClient = noClient;
            this.nomCompletClient = nomCompletClient;
        }
    }
}
