using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class Dier
    {
        public int formaat { get; private set; }
        public DierType dierType { get; private set; }

        public Dier(int formaat, DierType dierType)
        {
            this.formaat = formaat;
            this.dierType = dierType;
        }

        public override string ToString()
        {
            return $"{dierType}-etend dier van formaat: {formaat}";
        }
    }
}
