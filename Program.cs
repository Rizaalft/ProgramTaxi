using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat Objek Taxi
            Taxi03 taxi = new Taxi03();

            // Pengesetan nilai propertis
            taxi.Namadriver = " Rizaalft ";
            taxi.Berkerja = true;
            taxi.Penumpang = 10;

            // Pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUp();
            taxi.DropOff();

            Console.ReadKey();
        }
    }
}
