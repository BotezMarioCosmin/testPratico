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
        public override string ToString()
        { 
            return Numser + ";" + Modello + ";";
        }
        public string getHashCode()
        {
            return Convert.ToString(Numser);
        }


        //equals tutti gli attributi
        public bool Equals(Dispositivo d)
        {
            if (this.Numser == d.Numser && this.Modello == d.Modello)
            {
                return true;
            }
            else
                return false;
        }
        //compareTo solo il prezzo
        public int CompareTo(Dispositivo d)
        {
            if (this.CalcolaPrezzo() > d.CalcolaPrezzo())
            {
                return 1;
            }
            else if (this.CalcolaPrezzo() == d.CalcolaPrezzo())
            {
                return 0;
            }
            else
                return -1;
        }
    }
}
