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
    StringBuilder sb = new StringBuilder();          

    for(var i = s.Length-1; i>=0; i--)
 {
    sb.Append(s[i]);                           
 }      
       Console.WriteLine(sb.ToString());


    }




        
    }
}