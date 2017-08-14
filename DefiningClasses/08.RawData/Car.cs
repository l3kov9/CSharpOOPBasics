using System;

namespace _08.RawData
{
    public class Car
    {
        public string model;
        public Engine engine;
        public Cargo cargo;
        public Tire[] tyres;

        public Car(string model, Engine engine, Cargo cargo, Tire[] tyres)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tyres = tyres;
        }
    }
}
