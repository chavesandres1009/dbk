using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaseK
{
    [Serializable]
    public class Prueba
    {
        public int iv { get; set; }
        public int ims { get; set; }
        public int trans { get; set; }

        public Prueba()
        {

        }

        public Prueba(int iv, int ims, int trans)
        {
            this.iv = iv;
            this.ims = ims;
            this.trans = trans;
        }

        override
        public string ToString()
        {
            return "Iv: " + iv + " IS: " + ims + " Transporte: " + trans;
        }

    }
}
