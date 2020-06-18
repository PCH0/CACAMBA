using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISKCACAMBA.CAMADAS.BLL
{
    public class Cacambas
    {
        public List<MODEL.Cacambas> Select()
        {
            DAL.Cacambas dalCacambas = new DAL.Cacambas();
            //verifica regras de negócio
            return dalCacambas.Select();
        }

        public void Insert(MODEL.Cacambas cacambas)
        {
            DAL.Cacambas dalCacambas = new DAL.Cacambas();
            //escreve regras de negócio
            dalCacambas.Insert(cacambas);

        }

        public void Update(MODEL.Cacambas cacambas)
        {
            DAL.Cacambas dalCacambas = new DAL.Cacambas();
            //regras de negócio
            dalCacambas.Update(cacambas);
        }

        public void Delete(int idCacambas)
        {
            DAL.Cacambas dalCacambas = new DAL.Cacambas();
            //regras de negócio
            dalCacambas.Delete(idCacambas);
        }
   
    }
     

}
