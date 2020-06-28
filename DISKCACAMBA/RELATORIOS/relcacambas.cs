using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DISKCACAMBA.CAMADAS;

namespace DISKCACAMBA.RELATORIOS
{
    public class Relgerais
    {
        public static void relcacambas()
        {
            CAMADAS.BLL.Cacambas bllCacambas = new CAMADAS.BLL.Cacambas();
            List<CAMADAS.MODEL.Cacambas> lstcacamba = new List<CAMADAS.MODEL.Cacambas>();
            lstcacamba = bllCacambas.Select();

            string pasta = Funcoes.diretorioPasta();
            string arquivo = pasta + @"\Relcacambas_" + DateTime.Now.ToShortDateString().Replace("/", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_") + ".html";
            StreamWriter sw = new StreamWriter(arquivo);
            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' " +
                            "content='text/html; charset=utf-8'/>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");

                sw.WriteLine("</head>");

                sw.WriteLine("<body>");
                sw.WriteLine("<h1>Relatório de Caçambas</h1>");
                sw.WriteLine("<hr align='left' border:'5px' />");

                sw.WriteLine("<table class='table table-striped'>");


                sw.WriteLine("<tr align='right'>");
                sw.WriteLine("<th align='right' width='30px'>");
                sw.WriteLine("ID");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='250px'>");
                sw.WriteLine("TIPO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='150px'>");
                sw.WriteLine("TAMANHO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th  align='right' width='150px'>");
                sw.WriteLine("VALOR");
                sw.WriteLine("</th>");
                sw.WriteLine("<th  align='right' width='150px'>");
                sw.WriteLine("SITUACAO");
                sw.WriteLine("</th>");

                sw.WriteLine("</tr>");

                int cont = 0;
                foreach (CAMADAS.MODEL.Cacambas Cacambas in lstcacamba.OrderBy(o => o.id).ThenBy(t => t.tamanho).ThenBy(w => w.situacao))
                {

                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td align='right' width='30px'>");
                    sw.WriteLine(Cacambas.id);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='250px'>");
                    sw.WriteLine(Cacambas.tipo);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='right' width='150px'>");
                    sw.WriteLine(Cacambas.tamanho);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td  align='right' width='150px'>");
                    sw.WriteLine(string.Format("{0:C2}", Cacambas.valor));
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td  align='right' width='150px'>");
                    sw.WriteLine(Cacambas.situacao);
                    sw.WriteLine("</td>");

                    sw.WriteLine("</tr>");
                    cont++;
                }


            }
            System.Diagnostics.Process.Start(arquivo);
        }

    }
}