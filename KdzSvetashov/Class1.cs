using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KdzSvetashov
{
    class Car
    {
        private string _name;
        private int _productionYear;
        private string _engineType;
        private int _engineСapacity;
        private string _drivegear;
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
        public string Drivegear
        {
            get
            {
                return _drivegear;
            }
            set
            {
                _drivegear = value;
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

        public Car(string cName, int year, string enType, int enCapacity, string drGear, int power)
        {
            Name = cName;
            ProductionYear = year;
            EngineType = enType;
            EngineСapacity = enCapacity;
            Drivegear = drGear;
            Horsepower = power;
        }
        public void showCar(KdzSvetashov.MainWindow wnd)
        {
            wnd.info.Text += "Машина: " + Name + "\n";
            wnd.info.Text += "Год выпуска: " + ProductionYear + "\n";
            wnd.info.Text += "Тип двигателя: " + EngineType + "\n";
            wnd.info.Text += "Объем двигателя: " + EngineСapacity + "\n";
            wnd.info.Text += "Привод: " + Drivegear + "\n";
            wnd.info.Text += "Мощность: " + Horsepower + "\n";
        }


    }
}
