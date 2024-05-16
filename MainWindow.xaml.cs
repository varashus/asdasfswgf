using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Weather
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var vrok = new List<Ido>();
            using StreamReader sr = new StreamReader(
                path: @"..\..\..\src\cities.txt",
                encoding: System.Text.Encoding.UTF8
                );
            _ = sr.ReadLine();

            while (!sr.EndOfStream)
            {
                vrok.Add(new Ido(sr.ReadLine()));
            }



            foreach (var item in vrok)
            {
                asd.Items.Add(item);
            }

         






        }
       

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            asd.Items.Remove(asd.SelectedItem);

            if (asd.Items.Count <= 0)
            {
                MessageBox.Show("nincs elem amit lehetne törölni");
            }
        }



    }
}