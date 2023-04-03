using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPratico
{
    public abstract class Dispositivo
    {
        private int _numser;
        private string _modello;

        public int Numser
        {
            get { return _numser; }
            set { _numser = value; }
        }

        public string Modello
        {
            get { return _modello; }
            set { _modello = value; }
        }

        public Dispositivo(int numser, string modello)
        {
            Numser = numser;
            Modello = modello;
        }

        public Dispositivo()
        {
            Numser = -1;
            Modello = "NullModello";
        }

        public Dispositivo(int numser)
        {
            Numser = numser;
            Modello = "NullModello";
        }

        public Dispositivo(string modello)
        {
            Modello = modello;
            Numser = -1;
        }

        public abstract float CalcolaPrezzo();

    }
}
