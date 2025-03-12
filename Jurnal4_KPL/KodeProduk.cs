using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_103022300078
{
    class KodeProduk
    {
        private Dictionary<string, string> daftarKodeProduk = new Dictionary<string, string>()
     {
        {"Laptop", "E100"},
        {"Smartphone", "E101"},
        {"Tablet", "E102" },
        {"Headset", "E103"},
        {"Keyboard", "E104"},
        {"Mouse", "E105" },
        {"Printer", "E106"},
        {"Monitor", "E107"},
        {"Smartwatch", "E108" },
        {"Kamera", "E109"},
     };
        
        public string GetKodeProduk(string namaProduk)
        {
            string kodeProduk = "";
            if (daftarKodeProduk.ContainsKey(namaProduk))
            {
                kodeProduk = daftarKodeProduk[namaProduk];
            }
            return kodeProduk;
        }
    }
}
