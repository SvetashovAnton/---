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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;


namespace KdzSvetashov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

  
    public partial class MainWindow : Window
    {
        public int lb = 0;
        public ListOfCars lc = new ListOfCars();
        public ListOfLorries lr = new ListOfLorries();
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists("../../lorries.xml"))
            {
                lr = Serializing.Deserialize_l(lr);

                foreach (var item in lr.Lorries)
                {
                    Table1.Items.Add(item);
                }
            }
            if (File.Exists("../../cars.xml"))
            {
                lc = Serializing.Deserialize_c(lc);

                foreach (var item in lc.Cars)
                {
                    Table.Items.Add(item);
                }
            }
        }

        private void Admin_Button_Click(object sender, RoutedEventArgs e)
        {
            admin.Visibility = Visibility.Visible;
            front.Visibility = Visibility.Collapsed;
        }


        private void Truck_Click(object sender, RoutedEventArgs e)
        {
            Admin_lorry.Visibility = Visibility.Visible;
            admin.Visibility = Visibility.Collapsed;
        }

        private void Auto_Click(object sender, RoutedEventArgs e)
        {
            admin.Visibility = Visibility.Visible;
            Admin_lorry.Visibility = Visibility.Hidden;
        }

        private void Add_Lorry_Button_Click(object sender, RoutedEventArgs e)
        {
            Add_Window wnd = new Add_Window(this);
            wnd.Show();

        }

        private void AddCar_Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 wnd = new Window1(this);
            wnd.Show();
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            if (lb == 3)
            {
                lc.Cars.Remove((Car)Table.SelectedItem);
                Search_result1.Items.Remove(Table.SelectedItem);
                Serializing.Serialize_c(lc);
                Table.Items.Remove(Table.SelectedItem);
            }
            if (lb == 4)
            {
                lc.Cars.Remove((Car)Search_result1.SelectedItem);
                Table.Items.Remove(Search_result1.SelectedItem);
                Serializing.Serialize_c(lc);
                Search_result1.Items.Remove(Search_result1.SelectedItem);
            }
        }

        private void Delete_Button1_Click(object sender, RoutedEventArgs e)
        {
            if (lb == 1)
            {
                Serializing.Deserialize_l(lr);
                lr.Lorries.Remove((Lorry)Table1.SelectedItem);
                Search_result.Items.Remove(Table1.SelectedItem);
                Serializing.Serialize_l(lr);
                Table1.Items.Remove(Table1.SelectedItem);
            }
            if (lb == 2)
            {
                Serializing.Deserialize_l(lr);
                lr.Lorries.Remove((Lorry)Search_result.SelectedItem);
                Table1.Items.Remove(Search_result.SelectedItem);
                Serializing.Serialize_l(lr);
                Search_result.Items.Remove(Search_result.SelectedItem);
            }

        }

        private void Search_Button1_Click(object sender, RoutedEventArgs e)
        {
            Search_result.Items.Clear();
            if (Lorry.Text != "")
            {
                foreach (var item in lr.Lorries)
                {

                    if (item.Name.Contains(Lorry.Text))
                    {
                        Search_result.Items.Add(item);
                    }

                }
            }
            else
            {
                MessageBox.Show("Введите поисковый запрос");
            }

        }

        private void More_Click(object sender, RoutedEventArgs e)
        {
            Window2 wnd3 = new Window2(this);
            wnd3.Show();
            if (lb == 1)
            {
                try {
                    foreach (var item in lr.Lorries)
                    {
                        if (item.Name == ((Lorry)Table1.SelectedItem).Name)
                        {
                            wnd3.Name_L.Content = item.Name;
                            wnd3.Mass_L.Content = item.FreightMass;
                            wnd3.Prod_Year_L.Content = item.ProductionYear;
                            wnd3.Power_L.Content = item.Horsepower;
                            wnd3.Type_Eng_L.Content = item.EngineType;
                            wnd3.Capacity_L.Content = item.EngineСapacity;
                        }
                    }
                }catch (Exception a)
                { MessageBox.Show(a.ToString()); }

            }
            else
            {

            }
            if (lb == 2)
            {
                try {
                    foreach (var item in lr.Lorries)
                    {
                        if (item.Name == ((Lorry)Search_result.SelectedItem).Name)
                        {
                            wnd3.Name_L.Content = item.Name;
                            wnd3.Mass_L.Content = item.FreightMass;
                            wnd3.Prod_Year_L.Content = item.ProductionYear;
                            wnd3.Power_L.Content = item.Horsepower;
                            wnd3.Type_Eng_L.Content = item.EngineType;
                            wnd3.Capacity_L.Content = item.EngineСapacity;
                        }
                    }
                }
                catch (Exception a)
                { MessageBox.Show(a.ToString()); }

            }
            else
            {

            }
        }

        private void Table1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lb = 1;
        }

        private void Search_result_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lb = 2;
        }


        private void More1_Click(object sender, RoutedEventArgs e)
        {
            Window3 wnd4 = new Window3(this);
            wnd4.Show();
            if (lb == 3)
            {
                try
                {
                    foreach (var item in lc.Cars)
                    {
                        if (item.Name == ((Car)Table.SelectedItem).Name)
                        {
                            wnd4.Name_C.Content = item.Name;
                            wnd4.Drivegear_C.Content = item.Drivegear;
                            wnd4.Prod_Year_C.Content = item.ProductionYear;
                            wnd4.Power_C.Content = item.Horsepower;
                            wnd4.Type_Eng_C.Content = item.EngineType;
                            wnd4.Capacity_C.Content = item.EngineСapacity;
                        }
                    }
                }
                catch (Exception a)
                { MessageBox.Show(a.ToString()); }

            }
            else
            {

            }
            if (lb == 4)
            {
                try {
                    foreach (var item in lc.Cars)
                    {
                        if (item.Name == ((Car)Search_result.SelectedItem).Name)
                        {
                            wnd4.Name_C.Content = item.Name;
                            wnd4.Drivegear_C.Content = item.Drivegear;
                            wnd4.Prod_Year_C.Content = item.ProductionYear;
                            wnd4.Power_C.Content = item.Horsepower;
                            wnd4.Type_Eng_C.Content = item.EngineType;
                            wnd4.Capacity_C.Content = item.EngineСapacity;
                        }
                    }
                }
                catch (Exception a)
                { MessageBox.Show(a.ToString()); }

            }
            else
            {

            }
        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            Search_result1.Items.Clear();
            
            if (Car.Text != "")
            {
                foreach (var item in lc.Cars)
                {

                    if (item.Name.Contains(Car.Text))
                    {
                        Search_result1.Items.Add(item);
                    }

                }
            }
            else
            {
                MessageBox.Show("Введите поисковый запрос");
            }
        }

        private void Table_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            lb = 3;
        }

        private void Search_result1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lb = 4;
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            if (lb == 3)
            {
                Window1 wnd = new Window1(this);
                wnd.Show();
                try {
                    foreach (var item in lc.Cars)
                    {
                        if (item.Name == ((Car)Table.SelectedItem).Name)
                        {
                            wnd.Name.Text = item.Name;
                            wnd.drGear.Text = item.Drivegear;
                            wnd.Prod_Year.Text = item.ProductionYear.ToString();
                            wnd.Power.Text = item.Horsepower.ToString();
                            wnd.Type_eng.Text = item.EngineType;
                            wnd.Capacity.Text = item.EngineСapacity.ToString();
                        }
                    }
                    lc.Cars.Remove((Car)Table.SelectedItem);
                    Search_result1.Items.Remove(Table.SelectedItem);
                    Serializing.Serialize_c(lc);
                    Table.Items.Remove(Table.SelectedItem);
                }
                catch (Exception a)
                { MessageBox.Show(a.ToString()); }

            }
            else
            {

            }
            if (lb == 4)
            {

                Window1 wnd = new Window1(this);
                wnd.Show();
                try
                {
                    foreach (var item in lc.Cars)
                    {
                        if (item.Name == ((Car)Search_result1.SelectedItem).Name)
                        {
                            wnd.Name.Text = item.Name;
                            wnd.drGear.Text = item.Drivegear;
                            wnd.Prod_Year.Text = item.ProductionYear.ToString();
                            wnd.Power.Text = item.Horsepower.ToString();
                            wnd.Type_eng.Text = item.EngineType;
                            wnd.Capacity.Text = item.EngineСapacity.ToString();
                        }
                    }
                    lc.Cars.Remove((Car)Search_result1.SelectedItem);
                    Table.Items.Remove(Search_result1.SelectedItem);
                    Serializing.Serialize_c(lc);
                    Search_result1.Items.Remove(Search_result1.SelectedItem);
                }
                catch (Exception a)
                { MessageBox.Show(a.ToString()); }

            }
            else
            {

            }

        }

        private void Change1_Click(object sender, RoutedEventArgs e)
        {

            if (lb == 1)
            {
                Add_Window wnd = new Add_Window(this);
                wnd.Show();
                try {
                    foreach (var item in lr.Lorries)
                    {
                        if (item.Name == ((Lorry)Table1.SelectedItem).Name)
                        {
                            wnd.Name.Text = item.Name;
                            wnd.Mass.Text = item.FreightMass.ToString();
                            wnd.Prod_Year.Text = item.ProductionYear.ToString();
                            wnd.Power.Text = item.Horsepower.ToString();
                            wnd.Type_eng.Text = item.EngineType;
                            wnd.Capacity.Text = item.EngineСapacity.ToString();
                        }
                    }
                    lr.Lorries.Remove((Lorry)Table1.SelectedItem);
                    Search_result.Items.Remove(Table1.SelectedItem);
                    Serializing.Serialize_l(lr);
                    Table1.Items.Remove(Table1.SelectedItem);
                }catch (Exception a)
                { MessageBox.Show(a.ToString()); }

            }
            else
            {

            }
            if (lb == 2)
            {
                Add_Window wnd = new Add_Window(this);
                wnd.Show();
                try
                {
                    foreach (var item in lr.Lorries)
                    {
                        if (item.Name == ((Lorry)Search_result.SelectedItem).Name)
                        {
                            wnd.Name.Text = item.Name;
                            wnd.Mass.Text = item.FreightMass.ToString();
                            wnd.Prod_Year.Text = item.ProductionYear.ToString();
                            wnd.Power.Text = item.Horsepower.ToString();
                            wnd.Type_eng.Text = item.EngineType;
                            wnd.Capacity.Text = item.EngineСapacity.ToString();
                        }
                    }
                    lr.Lorries.Remove((Lorry)Search_result.SelectedItem);
                    Table1.Items.Remove(Search_result.SelectedItem);
                    Serializing.Serialize_l(lr);
                    Search_result.Items.Remove(Search_result.SelectedItem);
                }
                catch (Exception a)
                { MessageBox.Show(a.ToString()); }
               
            }
            else
            {

            }
        }
    }
}
