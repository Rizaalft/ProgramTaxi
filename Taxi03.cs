using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramTaxi
{
    class Taxi03
    {
        public string Namadriver { get; set; }
        public bool Berkerja { get; set; }
        public int Penumpang { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine(" Nama Pengemudi      : {0} ", Namadriver);
            if (Berkerja == true)
            {
                Console.WriteLine(" Mengantar Penumpang : Ya ", Berkerja);
            }
            else
            {
                Console.WriteLine(" Tidak Mengantar Penumpang : Tidak ", Berkerja);
            }

            Console.WriteLine(" Jumlah Penumpang    : {0}\n ", Penumpang);
        }

        public void PickUp()
        {
            Console.WriteLine(" {0} Sedang Menjemput Penumpang ", Namadriver);
        }

        public void DropOff()
        {
            Console.WriteLine(" {0} Selesai Mengantar Penumpang\n ", Namadriver);
        }
    }
}
