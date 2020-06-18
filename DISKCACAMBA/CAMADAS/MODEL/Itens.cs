using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISKCACAMBA.CAMADAS.MODEL
{
    public class Itens
    {
        public int id { get; set; }
        public int aluguel_id { get; set; }
        public int cacambas_id { get; set; }
        public DateTime entrega { get; set; }

    }
}
