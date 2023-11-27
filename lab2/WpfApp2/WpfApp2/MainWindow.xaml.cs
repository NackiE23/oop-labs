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

namespace WpfApp2
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

        private void OnCalculateClick(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(TextBoxA.Text, out double a))
            {
                MessageBox.Show("Некоректне значення a.");
                return;
            }

            if (!double.TryParse(TextBoxB.Text, out double b))
            {
                MessageBox.Show("Некоректне значення b.");
                return;
            }

            if (!double.TryParse(TextBoxC.Text, out double c))
            {
                MessageBox.Show("Некоректне значення c.");
                return;
            }

            double discriminant = b * b - 4 * a * c;
            DiscriminantLabel.Text = $"Дискримінант: {discriminant}";

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                RootsLabel.Visibility = Visibility.Visible;
                RootsLabel.Text = $"Розв'язки: x1 = {x1}, x2 = {x2}";
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                RootsLabel.Visibility = Visibility.Visible;
                RootsLabel.Text = $"Розв'язок: x = {x}";
            }
            else
            {
                RootsLabel.Visibility = Visibility.Collapsed;
                DiscriminantLabel.Text = "Розв'язків немає.";
            }
        }
    }
}