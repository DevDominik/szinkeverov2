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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Szinkever(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rctTeglalap.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(sliPiros.Value), Convert.ToByte(sliZold.Value), Convert.ToByte(sliKek.Value)));
            labPiros.Content = Convert.ToByte(sliPiros.Value);
            labZold.Content = Convert.ToByte(sliZold.Value);
            labKek.Content = Convert.ToByte(sliKek.Value);
        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            List<Button> lista = new List<Button>();
            foreach (Button item in lbSzinek.Items)
            {
                lista.Add(item);
            }
            bool talalt = false;
            foreach (Button item in lista)
            {
                if (item.Content.ToString() == $"{Convert.ToByte(sliPiros.Value)};{Convert.ToByte(sliZold.Value)};{Convert.ToByte(sliKek.Value)}")
                {
                    talalt = true;
                }
            }
            if (talalt)
            {
                MessageBox.Show("Már van egy ilyen szín");
            } 
            else
            {
                Button a = new Button();
                a.Content = $"{Convert.ToByte(sliPiros.Value)};{Convert.ToByte(sliZold.Value)};{Convert.ToByte(sliKek.Value)}";
                lbSzinek.Items.Add(a);
            }
        }
        private void btnTorol_Click(object sender, RoutedEventArgs e)
        {
            if (lbSzinek.SelectedItem != null)
            {
                lbSzinek.Items.Remove(lbSzinek.SelectedItem);
            } else
            {
                MessageBox.Show("Nincs kijelölt elem törléshez");
            }
        }
        private void btnUrit_Click(object sender, RoutedEventArgs e)
        {
            lbSzinek.Items.Clear();
        }
    }
}
