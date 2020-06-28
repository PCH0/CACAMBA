using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISKCACAMBA.CAMADAS.MODEL
{
    //altamiro
    public class Aluguel
    {
        public int id { get; set; }
        public int cliente_id { get; set; }
        public string nomeCli { get; set;}
        public DateTime date { get; set; }

    }
}
