using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Constructor
{
    internal class bebek
    {
        // Properties
        // Özellikler
        public DateTime DogumTarihi { get; private set; }
        public string Ad { get; private set; }
        public string Soyad { get; private set; }

        // Default constructor
        // Varsayılan kurucu metot
        public bebek()
        {
            DogumTarihi = DateTime.Now; // Set birth date to current date and time
                                        // Doğum tarihini şu anki tarih ve saat olarak ayarla
            Ad = "bilinmiyor";         // Set default name to "bilinmiyor"
                                       // Varsayılan adı "bilinmiyor" olarak ayarla
            Soyad = "bilinmiyor";      // Set default surname to "bilinmiyor"
                                       // Varsayılan soyadı "bilinmiyor" olarak ayarla
            Console.WriteLine("ıngaaaaaa"); // Print "ıngaaaaaa" to the console
                                            // Konsola "ıngaaaaaa" yazdır
        }

        // Constructor with parameters for name and surname
        // İsim ve soyisim için parametre alan kurucu metot
        public bebek(string ad, string soyad)
        {
            DogumTarihi = DateTime.Now; // Set birth date to current date and time
                                        // Doğum tarihini şu anki tarih ve saat olarak ayarla
            Ad = ad;                    // Set name to the provided value
                                        // İsmi verilen değere ayarla
            Soyad = soyad;              // Set surname to the provided value
                                        // Soyismi verilen değere ayarla
            Console.WriteLine("ıngaaaaa"); // Print "ıngaaaaa" to the console
                                           // Konsola "ıngaaaaa" yazdır
        }

        // Method to print baby's information
        // Bebeğin bilgilerini yazdırmak için metot
        public void BilgileriYazdir()
        {
            Console.WriteLine("Ad: " + Ad); // Print name
                                            // İsmi yazdır
            Console.WriteLine("Soyad: " + Soyad); // Print surname
                                                  // Soyismi yazdır
            Console.WriteLine("Doğum Tarihi: " + DogumTarihi); // Print birth date
                                                               // Doğum tarihini yazdır
        }


    }
}
