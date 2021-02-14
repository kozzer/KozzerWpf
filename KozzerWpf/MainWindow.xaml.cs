using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KozzerWpf.Code;

namespace KozzerWpf
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

        private void btnNutton_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = btnNutton;
            popup_uc.Placement = PlacementMode.MousePoint;
            popup_uc.IsOpen = true;
            tipPop.PopupText.Text = "Or, go with the Mystery Button?????";
        }

        private void btnLogin_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = btnNutton;
            popup_uc.Placement = PlacementMode.MousePoint;
            popup_uc.IsOpen = true;
            tipPop.PopupText.Text = "You, like, Log In or something";
        }


    }
}
