using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tyre
    {
        private int tyreAge;
        private float tyrePressure;

        public float TyrePressure
        {
            get { return tyrePressure; }
            set { tyrePressure = value; }
        }

        public int TyreAge
        {
            get { return tyreAge; }
            set { tyreAge = value; }
        }

    }
}
