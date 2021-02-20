using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace KozzerWpf.Components
{
    public partial class StatusLevel : UserControl, INotifyPropertyChanged
    {
        public bool IsActiveStep { get; private set; } = false;
        public bool IsCompleted  { get; private set; } = false;

        public string StepNumber
        {
            get { return (string)GetValue(StepNumberProperty); }
            set { SetValue(StepNumberProperty, value); }
        }
        // Using a DependencyProperty as the backing store for StepNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StepNumberProperty =
            DependencyProperty.Register("StepNumber", typeof(string), typeof(StatusLevel), new PropertyMetadata("0"));

        public string StepLabel
        {
            get { return (string)GetValue(StepLabelProperty); }
            set { SetValue(StepLabelProperty, value); }
        }
        // Using a DependencyProperty as the backing store for StepLabel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StepLabelProperty =
            DependencyProperty.Register("StepLabel", typeof(string), typeof(StatusLevel), new PropertyMetadata("1234567"));



        public bool IsFirstStep
        {
            get { return (bool)GetValue(IsFirstStepProperty); }
            set { SetValue(IsFirstStepProperty, value); }
        }
        // Using a DependencyProperty as the backing store for IsFirstStep.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsFirstStepProperty =
            DependencyProperty.Register("IsFirstStep", typeof(bool), typeof(StatusLevel), new PropertyMetadata(false));



        public bool IsLastStep
        {
            get { return (bool)GetValue(IsLastStepProperty); }
            set { SetValue(IsLastStepProperty, value); }
        }
        // Using a DependencyProperty as the backing store for IsLastStep.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsLastStepProperty =
            DependencyProperty.Register("IsLastStep", typeof(bool), typeof(StatusLevel), new PropertyMetadata(false));

        public event PropertyChangedEventHandler PropertyChanged;

        public SolidColorBrush BackgroundColor
        {
            get
            {
                if (!IsCompleted && !IsActiveStep)
                    return new SolidColorBrush(Colors.Gray);
                if (IsActiveStep)
                    return new SolidColorBrush(Colors.Blue);
                else
                    return new SolidColorBrush(Colors.LightBlue);
            }
        }

        public StatusLevel()
        {
            InitializeComponent();

            // So we can bind the properties
            this.DataContext = this;


            this.Loaded += StatusLevel_Loaded;
        }

        private void StatusLevel_Loaded(object sender, RoutedEventArgs e)
        {
            if (IsFirstStep || IsLastStep)
            {
                if (IsFirstStep)
                    statusLine.Y1 = 50;
                else
                    statusLine.Y2 = 25;

                statusCircle.Width = 75;
                statusCircle.Height = 75;
                statusCircle.ClipToBounds = false;
                lblStepLabel.Visibility = Visibility.Collapsed;
            }
        }

        public void SetActiveStep(bool isActiveStep)
        {
            IsActiveStep = isActiveStep;
            statusCircle.Fill = BackgroundColor;
        }

        public void SetCompleted(bool isCompleted)
        {
            IsCompleted = isCompleted;
            statusCircle.Fill = BackgroundColor;
        }
    }
}
