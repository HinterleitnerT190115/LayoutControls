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

namespace LayoutControls
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int column = 0; column < 2; column++)
            {
                for (int row = 0; row < 6; row++)
                {
                    var b = new Button()
                    {
                        Content = $"Button {row} {column}"
                    };

                    LeftButtonGrid.Children.Add(b);
                    Grid.SetRow(b, row);
                    Grid.SetColumn(b, column);
                }
            }
        }
    }
}
