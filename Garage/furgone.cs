using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    public class Furgone : Veicolo
    {
        public int Capacita { get; set; } // Capacità di carico in kg/litri

        public Furgone(int id, string marca, int anno, int cyl, int capacita)
            : base(id, marca, anno, cyl)
        {
            Capacita = capacita;
        }

        public override string stampa()
        {
            return $"Furgone | Capacità: {Capacita} kg";
        }
    }
}
