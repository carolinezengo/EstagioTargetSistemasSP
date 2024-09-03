using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estagio2.FaturamentoDistribuidora
{
    public class FaturamentoDistribuidora
    {
        public  FaturamentoDistribuidora(){

        }

        public double sp, rj, mg, es, outros,somaTotal,porcentagem;
        public void PorcentagemPorEstado(){

          sp = 6783643;
           rj = 3667866;
         mg = 2922988;
          es = 2716548;
          outros = 1984953;

          somaTotal = sp+ rj + mg + es + outros;   

                          
          Console.WriteLine("Porcentagem do Estado SP: " +PorcentagemPorEstado(somaTotal, sp).ToString("F2") + "%");
          Console.WriteLine("Porcentagem do Estado RJ: " +PorcentagemPorEstado(somaTotal, rj).ToString("F2") + "%");
          Console.WriteLine("Porcentagem do Estado MG: " +PorcentagemPorEstado(somaTotal, mg).ToString("F2") + "%");
           Console.WriteLine("Porcentagem do Estado ES: " +PorcentagemPorEstado(somaTotal, es).ToString("F2") + "%");
            Console.WriteLine("Porcentagem do Estado Outros: " +PorcentagemPorEstado(somaTotal, outros).ToString("F2") + "%");
        }

         public double PorcentagemPorEstado(double somaTotal, double estado){
         porcentagem = (estado/somaTotal)* 100;
         return porcentagem;
         }


}}