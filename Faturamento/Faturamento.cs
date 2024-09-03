using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estagio2.Faturamento
{
    public class Faturamento
    {
        public  Faturamento() {
        }

        public double faturamento;
        public double media;
        public double soma;
        public int i,dias = 0;
        
      int[] faturamentoDiario = new int[] {100, 200, 0, 150, 300, 250, 0, 180, 220, 280, 200, 150,
      0, 175, 225, 275, 250, 300, 0, 200, 150, 250, 275, 225, 0, 190, 210, 220, 300,
     175, 0, 200, 180, 220, 280, 250, 0, 150, 175, 225, 275, 200, 0, 190, 225, 250,
     275, 225, 0, 200, 175, 225, 275, 250, 0, 200, 225, 275, 250, 275, 0, 200, 220,
      280, 250, 275, 0, 175, 200, 250, 275, 200, 0, 200, 220, 280, 250, 300, 0, 175,
     200, 250, 275, 200, 0, 190, 210, 220, 300, 175, 0, 200, 225, 275, 250, 275, 0,
     190, 225, 250, 275, 225, 0, 200, 180, 220, 280, 250, 0, 150, 175, 225, 275, 200,
      0, 190, 225, 250, 275, 225, 0, 200, 220, 280, 250, 275, 0, 175, 200, 250, 275,
     200, 0, 200, 220, 280, 250, 300, 0, 175, 200, 250, 275, 200, 0, 190, 210, 220,
      300, 175, 0, 200, 225, 275, 250, 275, 0, 190, 225, 250, 275, 225, 0, 200,
     180, 220, 280, 250, 0, 150, 175, 225, 275, 200, 0};
      public void MaiorFaturamento(){  
         foreach (double z in faturamentoDiario)  
            {
                if (z > faturamento)
                {
                    faturamento = z;
                }

                       
            }
         Console.WriteLine("Maior faturamento é: "+ faturamento);
       
      }

       public void MenorFaturamento(){  
         foreach (double z in faturamentoDiario)  
            {
                if (z > 0 && z < faturamento)
                {
                    faturamento = z;
                }

                       
            }
         Console.WriteLine("Menor faturamento é: "+ faturamento);
       
      }

        public void MediaFaturamento(){  
         foreach (double z in faturamentoDiario)  
            {
                  i = i+1;
                soma=soma + z;
                                     
            }
            
            media = soma /i;
           foreach (double z in faturamentoDiario)  
            {
                 if(z > media)
                 {
                 dias = dias+1;
                 }
                  
                                                  
            }
         Console.WriteLine("Media faturamento é: "+ media.ToString("F2"));
         Console.WriteLine("Quantidade de dias superior a media mensal: "+ dias);
       
      }
    }
}