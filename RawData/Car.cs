using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Car
    {
        public string model;
        public Engine engine;
        public Cargo cargo;
        public Tyre[] tyres;

        public Car(string model, int speed, int power, int weight, string type,
        double tyre1pressure, int tyre1age, double tyre2pressure, int tyre2age, double tyre3pressure, int tyre3age, double tyre4pressure, int tyre4age)
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(weight, type);
            Tyres = new Tyre[4];
            Tyres[0] = new Tyre(tyre1pressure, tyre1age);
            Tyres[1] = new Tyre(tyre2pressure, tyre2age);
            Tyres[2] = new Tyre(tyre3pressure, tyre3age);
            Tyres[3] = new Tyre(tyre4pressure, tyre4age);
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                this.model = value;
            }
        }
        public Engine Engine
        {
            get
            {
                return engine;
            }
            set
            {
                this.engine = value;
            }
        }
        public Cargo Cargo
        {
            get
            {
                return cargo;
            }
            set
            {
                this.cargo = value;
            }
        }
        public Tyre[] Tyres
        {
            get
            {
                return tyres;
            }
            set
            {
                this.tyres = value;
            }
        }
    }
}
