using KozzerWpf.Pages;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace KozzerWpf
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        // Application pages
        private readonly Home     homePage    = null;
        private readonly Products productPage = null;
        private readonly Support  supportPage = null;
        private readonly About    aboutPage   = null;

        /// <summary>
        /// Constructor
        /// </summary>
        public MenuWindow()
        {
            InitializeComponent();

            homePage    = new Home();
            productPage = new Products();
            supportPage = new Support();
            aboutPage   = new About();
        }

        private async void btnHome_Click(object sender, RoutedEventArgs e)     => await transitionContent(homePage);
        private async void btnProducts_Click(object sender, RoutedEventArgs e) => await transitionContent(productPage);
        private async void btnSupport_Click(object sender, RoutedEventArgs e)  => await transitionContent(supportPage);
        private async void btnAbout_Click(object sender, RoutedEventArgs e)    => await transitionContent(aboutPage);

        /// <summary>
        /// Transistion from one Page to another
        /// </summary>
        /// <param name="newContent">New page to display once transistion is complete</param>
        /// <returns></returns>
        private async Task transitionContent(Page newContent)
        {
            // Use type pattern matching to call AnimateOut() method
            switch(mainWindowContent.Content)
            {
                case Home homePage:
                    await homePage.AnimateOut();
                    break;
                case Products productPage:
                    await productPage.AnimateOut();
                    break;
                case Support supportPage:
                    await supportPage.AnimateOut();
                    break;
                case About aboutPage:
                    await aboutPage.AnimateOut();
                    break;
            }

            // Loading it animates it in
            mainWindowContent.Content = newContent;
        }
    }
}
