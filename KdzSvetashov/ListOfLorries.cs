using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace KdzSvetashov
{
    [Serializable]
    public class ListOfLorries
    {
        public List<Lorry> Lorries;
        public ListOfLorries(List<Lorry> lorries)
        {
            Lorries = lorries;
        }
        public ListOfLorries()
        {
           
        }

        
    }
}
