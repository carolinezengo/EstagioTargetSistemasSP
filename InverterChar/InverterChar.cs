using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace estagio2.InverterChar
{
    public class InverterChar
    {
         public  InverterChar()
    {

    }
    public void InveterAsLetras(){
     string s = "O dia esta bonito com o ceu ensolarado";
      char[] caracteres = s.ToCharArray();
       
         int i = 0, j = caracteres.Length - 1;
       while (i < j) {
        char temp = caracteres[i];
        caracteres[i] = caracteres[j];
        caracteres[j] = temp;
        i++;
        j--;
         
    }
      Console.WriteLine(caracteres);


      }

    }



        
    }
