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

namespace fmseTest
{

    public partial class MainWindow : Window
    {
        private List<Button> myButtons;

        Color mouseOverlay = (Color)ColorConverter.ConvertFromString("#6dc3ff");

        public MainWindow()
        {
            InitializeComponent();

            myButtons = new List<Button>
            {
                AwardsButton,
                NationsButton,
                CitiesButton,
                ClubsButton,
                CompetitionsButton,
                PlayersButton,
                StaffButton

            };


        }

        private void FileButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Button pressed successfully");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                buttonClickInit(button);
            }
        }

        private void MouseEnter(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                buttonHoverInit(button);
            }
        }

        private void MouseLeave(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                buttonLeavesInit(button);
            }
        }

        private void buttonHoverInit(Button clickedButton)
        {
            clickedButton.Foreground = new SolidColorBrush(mouseOverlay);
        }

        private void buttonLeavesInit(Button clickedButton)
        {
            clickedButton.Foreground = new SolidColorBrush(Colors.Black);

        }


        private void buttonClickInit(Button clickedButton)
        {
            foreach (Button button in myButtons)
            {
                button.BorderThickness = new Thickness(0, 0, 0, 0);
            }

            clickedButton.BorderThickness = new Thickness(2, 2, 2, 0);
        }

    }
}
