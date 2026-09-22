using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    public class Auto : Veicolo
    {
        public int NumeroPorte { get; set; }
        public string Alimentazione { get; set; }

        public Auto(int id, string marca, int anno, int cyl, int numeroPorte, string alimentazione) : base(id, marca, anno, cyl)
        {
            NumeroPorte = numeroPorte;
            Alimentazione = alimentazione;
        }

        public override string stampa()
        {
            return $"Porte: {NumeroPorte} | Alimentazione: {Alimentazione}";
        }
    }
}
