using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KdzSvetashov
{
    class Lorry
    {
        private string _name;
        private int _productionYear;
        private string _engineType;
        private int _engineСapacity;
        private string _freightMass;
        private int _horsepower;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int ProductionYear
        {
            get
            {
                return _productionYear;
            }
            set
            {
                _productionYear = value;
            }
        }
        public string EngineType
        {
            get
            {
                return _engineType;
            }
            set
            {
                _engineType = value;
            }
        }
        public int EngineСapacity
        {
            get
            {
                return _engineСapacity;
            }
            set
            {
                _engineСapacity = value;
            }
        }
        public string FreightMass
        {
            get
            {
                return _freightMass;
            }
            set
            {
                _freightMass = value;
            }
        }
        public int Horsepower
        {
            get
            {
                return _horsepower;
            }
            set
            {
                _horsepower = value;
            }
        }

        public Lorry(string lName, int year, string enType, int enCapacity, string frMass, int power)
        {
            Name = lName;
            ProductionYear = year;
            EngineType = enType;
            EngineСapacity = enCapacity;
            FreightMass = frMass;
            Horsepower = power;
        }


    }
}
