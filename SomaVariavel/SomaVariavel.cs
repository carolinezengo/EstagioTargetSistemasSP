using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estagio2.SomaVariavel
{
    public class SomaVariavel
    {
         public  SomaVariavel (){
        
      }

   public void SomaVariaveis(){
        int indice = 13, soma = 0, k = 0;
       
        while ( k < indice)
        {
                       
             k = k + 1;
            soma = soma + k;
        }
        
                
                Console.WriteLine("Resultado da soma: " + soma);
           
        
        
    }
}}