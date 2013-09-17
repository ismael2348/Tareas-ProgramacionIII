using System;                                  //Ismael Benjamin Gonzalez Coronado       (PROGRAMACION II)
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloj_Cronometro__Practica_2_
 {
    class reloj{
        public void rinicia() {
            Console.WriteLine("Reloj");
    
            int h; 
            int m;
            int s;

   
            for (h = DateTime.Now.Hour; h >= 0; h++){
            
                for (m = DateTime.Now.Minute; m <= 60; m++){
               
                    for (s = DateTime.Now.Second ; s <= 60; s++){
                    
                        Console.WriteLine(h + "." + m + "." + s);
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();

                    }
               }
           }

    }
    }
    class cronometro{

        public void cinicia(){
    
            int opc;
            int segundos;
            int minutos;
            int horas;
            Console.WriteLine("Cronometro");
            for (horas = 0; horas >= 0; horas++){
        
                for (minutos = 0; minutos <= 60; minutos++){
            
                    for (segundos = 0; segundos <= 60; segundos++){
                
                        Console.WriteLine(horas.ToString("00") + "." + minutos.ToString("00") + "." + segundos.ToString("00"));
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();

                    }
                 }
             }
         }
    }
    class Program{
    
        static void Main(string[] args){
        
            int segundos;
            Console.WriteLine("1:Reloj \n2:Cronometro");
            int opc = Convert.ToInt32(Console.ReadLine());
                switch (opc) {
 	                case 1: reloj r = new reloj();
                        r.rinicia();      
                             break;
	                case 2: cronometro c = new cronometro();
	                    c.cinicia();
	                         break;
                           } 
         
                     } 
   
               }

}

      
     