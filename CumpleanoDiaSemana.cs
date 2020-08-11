using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApiApp
{
    class CumpleanoDiaSemana
    {
        //   Que año será el mismo dia de la semana del dia de nacimiento?
        public int _day { get; set; }  
        public int _month { get; set; }
        public int _year { get; set; } 

        public CumpleanoDiaSemana(int month, int day, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

        public void Calcular()
        {
            DateTime fecha  = new DateTime(_year, _month, _day);
            DateTime fecha2 = new DateTime(_year, _month, _day);
            int j = 0;
            for (int i = 0; i < 101; i++)
            {

                Console.WriteLine(fecha2.ToString("yyyy"));

                if (fecha2.ToString("dddd") == "Thursday")
                {
                    Console.WriteLine("          " + fecha2.Year);
                }
                fecha2 = fecha.AddYears(j++);
            }
        }
    }
}
