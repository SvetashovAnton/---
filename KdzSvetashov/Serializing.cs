using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace KdzSvetashov
{

    class Serializing
    {
        public static string file_lorries = "../../lorries.xml";
        public static string file_cars = "../../cars.xml";
        public static XmlSerializer xs_lorry = new XmlSerializer(typeof(ListOfLorries));
        public static XmlSerializer xs_car = new XmlSerializer(typeof(ListOfCars));
        public static void Serialize_l(ListOfLorries lr)
        {
            using (FileStream fs = new FileStream(file_lorries, FileMode.Create))
            {
                xs_lorry.Serialize(fs, lr);
            }
        }

        public static ListOfLorries Deserialize_l(ListOfLorries lr)
        {
            ListOfLorries data = new ListOfLorries();
            using (FileStream fs = new FileStream(file_lorries, FileMode.Open)) {
                data = (ListOfLorries) xs_lorry.Deserialize(fs);
            }
            return data;
        }
        public static void Serialize_c(ListOfCars lc)
        {
            using (FileStream fs = new FileStream(file_cars, FileMode.Create))
            {
                xs_car.Serialize(fs, lc);
            }
        }

        public static ListOfCars Deserialize_c(ListOfCars lc)
        {
            ListOfCars data = new ListOfCars();
            using (FileStream fs = new FileStream(file_cars, FileMode.Open))
            {
                data = (ListOfCars)xs_car.Deserialize(fs);
            }
            return data;
        }
    }
}
