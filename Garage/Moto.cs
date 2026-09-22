using Garage;
using System;
using System.Collections.Generic;
using System.Text;

public class Moto : Veicolo
{
    public int Tempi { get; set; }

    public Moto(int id, string marca, int anno, int cyl, int tempi) : base(id, marca, anno, cyl)
    {
        Tempi = tempi;
    }

    public override string stampa()
    {
        return $"Tempi: {Tempi}";
    }
}
