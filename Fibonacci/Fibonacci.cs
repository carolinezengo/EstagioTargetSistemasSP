using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estagio2.Fibonacci
{
    public class Fibonacci {
         
       public  Fibonacci (){
        
      }
       public int ne ;
       public bool pertence = false;
        public  int[] numero = new int[50];
      public void Teste (int n){

      
           int elementoInicio=1, elementoAnterior=0, elementoAtual=0 ;
             
            
               Console.WriteLine(elementoAtual);
                Console.WriteLine(elementoInicio);
              for (int i = 0; i < n; i++)
             {
               elementoAtual = elementoInicio + elementoAnterior;
               Console.WriteLine(elementoAtual);
                elementoAnterior = elementoInicio;
                 elementoInicio = elementoAtual;
                numero[i] = elementoAtual;
              
             }
             
             foreach (char z in numero)  
            {
                if (z == n)
                {
                   pertence= true;
                }
                       
            }

            if(pertence == true)
            {
                Console.WriteLine("Elemento pertence ao Fabonacci", n);
            }
            else {
             Console.WriteLine("Elemento não pertence ao Fabonacci", n);
            }

            
             
             Console.ReadLine();
        }
    }
}       
            
 