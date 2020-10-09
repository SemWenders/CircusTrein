using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class Container
    {
        public List<Dier> dieren;
        public int weight { get; set; }
        public int maxFormaat { get; private set; }

        public Container(int maxFormaat = 0)
        {
            dieren = new List<Dier>();
            weight = 0;
            this.maxFormaat = maxFormaat;
        }
    }
}
