using KozzerWpf.Code;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace KozzerWpf.Pages
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Page
    {
        public About()
        {
            InitializeComponent();

            this.Loaded += About_Loaded;
            this.Unloaded += About_Unloaded;
        }

        private async void About_Loaded(object sender, RoutedEventArgs e)
        {
            await AnimateIn();
        }

        private async void About_Unloaded(object sender, RoutedEventArgs e)
        {
            await AnimateOut();
        }


        /// <summary>
        /// The animation the play when the page is first loaded
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeIn;

        /// <summary>
        /// The animation the play when the page is unloaded
        /// </summary>
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOut;

        /// <summary>
        /// The time any slide animation takes to complete
        /// </summary>
        public float SlideSeconds { get; set; } = 0.1f;


        /// Animates the page in
        /// </summary>
        /// <returns></returns>
        public async Task AnimateIn()
        {
            // Make sure we have something to do
            if (this.PageLoadAnimation == PageAnimation.None)
                return;

            switch (this.PageLoadAnimation)
            {
                case PageAnimation.SlideAndFadeIn:

                    // Start the animation
                    await this.SlideAndFadeIn(this.SlideSeconds);

                    break;
            }
        }

        /// <summary>
        /// Animates the page out
        /// </summary>
        /// <returns></returns>
        public async Task AnimateOut()
        {
            // Make sure we have something to do
            if (this.PageUnloadAnimation == PageAnimation.None)
                return;

            switch (this.PageUnloadAnimation)
            {
                case PageAnimation.SlideAndFadeOut:

                    // Start the animation
                    await this.SlideAndFadeOut(this.SlideSeconds);

                    break;
            }
        }
    }
}
