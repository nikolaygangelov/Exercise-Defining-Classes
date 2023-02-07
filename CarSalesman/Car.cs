using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {        
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car()
        {

        }
        
        public Car(string carModel, Engine engine)
        {
            Engine = engine;
            Model = carModel;
            
        }

        public Car(int carWeight, string carModel, Engine engine) : 
            this(carModel, engine)
        {
            Weight = carWeight;
        }

        public Car(string carColor, int carWeight, string carModel, Engine engine) :
            this(carWeight, carModel, engine)
        {
            Color = carColor;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        public int Weight
        {
            get { return weight; }
            set { weight = value; }
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
