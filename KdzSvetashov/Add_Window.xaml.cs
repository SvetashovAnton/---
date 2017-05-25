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
    /// Логика взаимодействия для Add_Window.xaml
    /// </summary>
    public partial class Add_Window : Window
    {
        
        MainWindow wnd;
        public Add_Window(MainWindow wnd1)
        {
            InitializeComponent();
            wnd = wnd1;
        }

        private void Add_L_L_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (File.Exists("../../lorries.xml"))
                {
                    wnd.lr = Serializing.Deserialize_l(wnd.lr);
                }
                else
                {
                    wnd.lr.Lorries = new List<Lorry>();
                }
                Lorry lry = new Lorry(Name.Text, int.Parse(Prod_Year.Text), Type_eng.Text, int.Parse(Capacity.Text), int.Parse(Mass.Text), int.Parse(Power.Text));
                wnd.lr.Lorries.Add(lry);
                Serializing.Serialize_l(wnd.lr);
                wnd.Table1.Items.Add(lry);
                this.Close();
              
            }
            catch(Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }
    }
}
