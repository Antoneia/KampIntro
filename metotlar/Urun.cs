using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    class Urun   //class demek aslında nesneyi tanımlayan bilgi demek
    {
        // Property - özellik
        public int Id { get; set; }

        public string adi { get; set; }

        public double fiyati { get; set; }

        public string Aciklama { get; set; }

        public int StokAdedi { get; set; }
    }
}
