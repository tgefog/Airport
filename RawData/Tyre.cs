using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Tyre
    {
        private double pressure;
        private int age;

        public Tyre(double pressure, int age)
        {
            Pressure = pressure;
            Age = age;
        }
        public double Pressure
        {
            get
            {
                return pressure;
            }
            set
            {
                this.pressure = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
            }
        }
    }
}
