using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        private string model;
        public Engine engine;
        public Cargo cargo;
        public Tyre[] tyres;

        public Car(string carModel, 
                   int engineSpeed, 
                   int enginePower,
                   int cargoWeight,
                   string cargoType,
                   float tyre1Pressure,
                   int tyre1Age,
                   float tyre2Pressure,
                   int tyre2Age,
                   float tyre3Pressure,
                   int tyre3Age,
                   float tyre4Pressure,
                   int tyre4Age)
        {
            Model = carModel;
            
            Engine = new Engine();
            
            Engine.Speed = engineSpeed;
            Engine.Power = enginePower;

            Cargo = new Cargo();

            Cargo.Weight = cargoWeight;
            Cargo.Type = cargoType;

            Tyres = new Tyre[4];

            Tyres[0] = new Tyre();
            Tyres[1] = new Tyre();
            Tyres[2] = new Tyre();
            Tyres[3] = new Tyre();

            Tyres[0].TyrePressure = tyre1Pressure;
            Tyres[0].TyreAge = tyre1Age;
            Tyres[1].TyrePressure = tyre2Pressure;
            Tyres[1].TyreAge = tyre2Age;
            Tyres[2].TyrePressure = tyre3Pressure;
            Tyres[2].TyreAge = tyre3Age;
            Tyres[3].TyrePressure = tyre4Pressure;
            Tyres[3].TyreAge = tyre4Age;
        }

        public Tyre[] Tyres
        {
            get { return tyres; }
            set { tyres = value; }
        }

        public Cargo Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

    }
}
