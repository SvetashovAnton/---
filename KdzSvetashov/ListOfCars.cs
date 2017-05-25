using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace KdzSvetashov
{
    [Serializable]
    public class ListOfCars
    {
        public List<Car> Cars { get; set; }
        public ListOfCars(List<Car> cars)
        {
            Cars = cars;
        }
        public ListOfCars()
        {
            
        }

        
    }
}
