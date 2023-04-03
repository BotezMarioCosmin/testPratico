using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPratico
{
    public class Tv : Dispositivo
    {
        //100 euro ogni 20 pollici
        private int _pollici;

        public int Pollici
        {
            set
            {
                if (value > -1)
                {
                    _pollici = value;
                }
                else
                {
                    throw new Exception("Dimensione in pollici non valida!");
                }
            }
            get { return _pollici; }
        }

        public Tv(int numser, string modello, int pollici) : base(numser, modello)
        {
            Pollici = pollici;
        }

        public Tv()
        {
            Pollici = 0;
        }

        public override float CalcolaPrezzo()
        {
            float prezzo = 0;
            prezzo = Pollici / 20 * 100;
            return prezzo;
        }
    }
}
