﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPratico
{
    public class Cellulare : Dispositivo
    {
        private float _ram;
        private float _capienza;

        public float Ram
        {
            set
            {
                if (value > -0.01 && value < 32.01)
                {
                    _ram = value;
                }
                else
                {
                    throw new Exception("Dimensione ram non valida!");
                }
            }
            get { return _ram; }
        }

        public float Capienza
        {
            set
            {
                if (value > -0.01 && value < 1000.01)
                {
                    _capienza = value;
                }
                else
                {
                    throw new Exception("Dimensione archiviazione non valida!");
                }
            }
            get { return _capienza; }
        }


        public Cellulare(int numser, string modello, float ram, float capienza) : base(numser, modello)
        {
            Ram = ram;
            Capienza = capienza;
        }

        public Cellulare()
        {
            Ram = 0;
            Capienza = 0;
        }

        public override float CalcolaPrezzo()//30 euro per giga ram, 32gb aggiungi 50 euro
        {
            float prezzo = 0;
            prezzo = Ram * 30;

            float tmp = 0;
            tmp = Capienza / 32;
            tmp = tmp * 50;

            return prezzo + tmp;
        }

        public override string ToString()
        {
            return base.ToString() + Ram + ";" + Capienza + ";";
        }

        public bool Equals(Cellulare c)
        {
            if (base.Equals(c) == true)
            {
                if (this.Ram == c.Ram && this.Capienza == c.Capienza)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
    }
}
