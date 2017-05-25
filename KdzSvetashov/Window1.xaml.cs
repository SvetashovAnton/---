using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Serialization;
using System.IO;
namespace KdzSvetashov
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        MainWindow wnd;
        public Window1(MainWindow wnd2)
        {
            InitializeComponent();
            
            wnd = wnd2;
        }

        private void Add_C_C_Click(object sender, RoutedEventArgs e)
        {

            if (File.Exists("../../lorries.xml"))
            {
                wnd.lc = Serializing.Deserialize_c(wnd.lc);
            }
            else
            {
                wnd.lc.Cars = new List<Car>();
            }
            Car cr = new Car(Name.Text, int.Parse(Prod_Year.Text), Type_eng.Text, int.Parse(Capacity.Text), drGear.Text, int.Parse(Power.Text));
            wnd.lc.Cars.Add(cr);
            Serializing.Serialize_c(wnd.lc);
            wnd.Table.Items.Add(cr);
            this.Close();
        }
    }
}
