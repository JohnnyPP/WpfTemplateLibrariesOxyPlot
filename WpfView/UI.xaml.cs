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

namespace WpfView
{
    /// <summary>
    /// Interaction logic for Ui.xaml
    /// </summary>
    public partial class Ui : Window
    {
        WpfViewModel.ViewModel vm;

        public Ui()
        {
            InitializeComponent();

            vm = new WpfViewModel.ViewModel();
            DataContext = vm;
        }
    }
}
