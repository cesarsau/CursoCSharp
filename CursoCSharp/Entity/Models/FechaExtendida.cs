using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public class FechaExtendida : Fecha
    {
        private int Horas { get; set; }
        private int Minutos { get; set; }
        private int Segundos { get; set; }

        public FechaExtendida()
        {

        }

        public FechaExtendida(int H, int M, int S)
        {
            this.Horas = H;
            this.Minutos = M;
            this.Segundos = S;

            if (H < 0)
                Console.WriteLine("La hora no puede ser negativa");
            if (M < 0)
                Console.WriteLine("Los minutos no pueden ser negativos");
            if (S < 0)
                Console.WriteLine("La segundos no pueden ser negativos");
        }

        
        public override void Imprimir(string Formato,int dia,int mes,int año)
        {
            
            switch (Formato)
            {
                
                case "dd/mm/yyyy hh:mm:ss":
                    if(Horas>12)
                        Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}", dia, "/", mes, "/", año, "  ", Horas, ":", this.Minutos, ":", this.Segundos, " Formato 24H");
                    else
                        Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}",dia, "/",mes, "/",año,"  ",Horas, ":", this.Minutos, ":", this.Segundos, " AM Hora estandar");
                    //Console.WriteLine(this.Dia + "/" + this.Mes + "/" + this.Año);

                    break;


            }

        }
        
        public void nuevo2()
        {
            String nuevo=Horas +":"+ Minutos+":"+Segundos;

        }
    }
}