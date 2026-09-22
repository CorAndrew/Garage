using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    public class Veicolo
    {
        public int Id { get; set; }

        public string marca { get; set; }

        public int anno { get; set; }

        public int cyl { get; set; }

        public Veicolo()
        {
            Id = 0;
            marca = "";
            anno = 0;
            cyl = 0;
        }
        public Veicolo(int conta, string m, int a, int c)
        {
            Id = conta;
            marca = m;
            anno = a;
            cyl = c;
        }

        public virtual string stampa()
        {
            string cili = cyl.ToString();
            string Anno = anno.ToString();
            string posto = Id.ToString();

            return $"Posto {posto} | anno {Anno} | marca {marca} | cilindrata {cili}";
       }
    }
}
