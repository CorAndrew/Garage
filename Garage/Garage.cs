using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    public class Garage
    {
        private Veicolo[] posti = new Veicolo[15];

        public int ImmettiVeicolo(int numeroPosto, Veicolo v)
        {
            if (numeroPosto < 0 || numeroPosto >= posti.Length)
                return -1 ;

            if (posti[numeroPosto] != null)
                return -1;

            v.Id = numeroPosto;
            posti[numeroPosto] = v;
            return 0;
        }

        public Veicolo EstraiVeicolo(int numeroPosto)
        {
            if (numeroPosto < 0 || numeroPosto >= posti.Length)
                return null;

            if (posti[numeroPosto] == null)
                return null;

            Veicolo veicoloEstratto = posti[numeroPosto];
            posti[numeroPosto] = null;
            return veicoloEstratto;
        }

        public string[] OttieniSituazioneGarage()
        {
            string[] situazione = new string[posti.Length];
            for (int i = 0; i < posti.Length; i++)
            {
                if (posti[i] == null)
                {
                    situazione[i] = $"[Posto {i}] | libero";
                }
                else
                {
                    situazione[i] = posti[i].stampa();
                }
            }
            return situazione;
        }
    }
}
