﻿using System;

namespace agua
{
    class Programas
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Today;
            Console.WriteLine("Cuantos min tardas en bañarte?");            
            var tiempo = Console.ReadLine();
            int inttiempo = int.Parse(tiempo);
            var botellas = inttiempo * 12;
            Console.WriteLine($"tu gastas alrededor de {botellas} botellas de agua cuando te bañas");
            Console.WriteLine($"Cuando cumples años?    Ejemplo: 23/09/2017"); 
            var dias = Console.ReadLine(); 
            DateTime tim = DateTime.Parse(dias);
            if(tim>fecha){
            TimeSpan ts = tim - fecha;
            int diasfalta = ts.Days;
            var rp = diasfalta * botellas;
            Console.WriteLine($"hasta tu cumpleaños gastaras {rp} botellas de agua al bañarte");
            }
            else{
                Console.WriteLine("Lo sentimos la fecha ingresada fue anterior ala de hoy.");
            }
        }
    //Carlos Alejandro Villegas Nuñez
    //Reyes Aceves Sergio
    }
}