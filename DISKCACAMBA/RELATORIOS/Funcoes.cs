using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISKCACAMBA.RELATORIOS
{
    public class Funcoes
    {
        public static string diretorioPasta()
        {
            string pasta = @"c:\cacambas";
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            return pasta;
        }
    }
}
