using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Threading.Tasks;
using KozzerWpf.Code;
using KozzerWpf.Pages;

namespace KozzerWpf
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {

        Home homePage = null;
        Products productPage = null;
        Support supportPage = null;
        About aboutPage = null;

        public MenuWindow()
        {
            InitializeComponent();
        }

        private async void btnHome_Click(object sender, RoutedEventArgs e)
        {
            if (homePage is null)
                homePage = new Home();
            await transitionContent(homePage);
        }

        private async void btnProducts_Click(object sender, RoutedEventArgs e)
        {
            if (productPage is null)
                productPage = new Products();
            await transitionContent(productPage);
        }

        private async void btnSupport_Click(object sender, RoutedEventArgs e)
        {
            if (supportPage is null)
                supportPage = new Support();
            await transitionContent(supportPage);
        }

        private async void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            if (aboutPage is null)
                aboutPage = new About();
            await transitionContent(aboutPage);
        }

        private async Task transitionContent(Page newContent)
        {
            if (mainWindowContent.Content is Home)
            {
                await (mainWindowContent.Content as Home).AnimateOut();
            }
            else if (mainWindowContent.Content is Products)
            {
                await (mainWindowContent.Content as Products).AnimateOut();
            }
            else if (mainWindowContent.Content is Support)
            {
                await (mainWindowContent.Content as Support).AnimateOut();
            }
            else if (mainWindowContent.Content is About)
            {
                await (mainWindowContent.Content as About).AnimateOut();
            }

            // Loading it animates it in
            mainWindowContent.Content = newContent;
        }
    }
}
