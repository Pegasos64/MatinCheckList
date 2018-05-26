using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatinCheckList
{

    public enum taskState
    {
        TEHTY, KESKEN, LUOTU, PERUTTU, POISTETTU
    }

    class Tehtava
    {
        public taskState tila;
        public string nimi;

        public Tehtava(string nimi)
        {
            this.tila = taskState.LUOTU;
            this.nimi = nimi;

        }
    }
}
