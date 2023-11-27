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

namespace WpfApp1
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
            if (!double.TryParse(xInput.Text, out double x))
            {
                MessageBox.Show("Невірний ввід для x. Будь ласка, введіть дійсне число.");
                return;
            }

            if (!double.TryParse(yInput.Text, out double y))
            {
                MessageBox.Show("Невірний ввід для y. Будь ласка, введіть дійсне число.");
                return;
            }

            if (!double.TryParse(zInput.Text, out double z))
            {
                MessageBox.Show("Невірний ввід для z. Будь ласка, введіть дійсне число.");
                return;
            }

            double innerMostRoot = Math.Pow(x - 1, 1.0 / 3.0);
            double intermediateValue = Math.Pow(y + innerMostRoot, 1.0 / 4.0);
            double denominator = 2 * Math.Abs(x + z);

            if (denominator == 0)
            {
                MessageBox.Show("Ділення на нуль. Значення x і z введено таким чином, що знаменник стає нулем.");
                return;
            }

            double s = Math.Log10(x) * (intermediateValue / denominator);
            double roundedS = Math.Round(s, 3);

            resultTextBlock.Text = $"Результат: s = {roundedS}";
        }
    }
}