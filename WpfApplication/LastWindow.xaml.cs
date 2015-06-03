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

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for LastWindow.xaml
    /// </summary>
    public partial class LastWindow : Window
    {
        public int change1 { get; set; }
        public int change2 { get; set; }
        public LastWindow()
        {
            InitializeComponent();
        }

        public int change3 { get; set; }
    }
}
