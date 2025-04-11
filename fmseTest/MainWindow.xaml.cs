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

        private void AwardsButton_Click(object sender, RoutedEventArgs e)
        {
            buttonClickInit(AwardsButton);
        }

        private void NationsButton_Click(object sender, RoutedEventArgs e)
        {
            buttonClickInit(NationsButton);
        }

        private void CitiesButton_Click(object sender, RoutedEventArgs e)
        {
            buttonClickInit(CitiesButton);
        }

        private void ClubsButton_Click(object sender, RoutedEventArgs e)
        {

            buttonClickInit(ClubsButton);
        }

        private void CompetitionsButton_Click(object sender, RoutedEventArgs e)
        {
            buttonClickInit(CompetitionsButton);
        }

        private void PlayersButton_Click(object sender, RoutedEventArgs e)
        {
            buttonClickInit(PlayersButton);
        }

        private void StaffButton_Click(object sender, RoutedEventArgs e)
        {
            buttonClickInit(StaffButton);
        }

        private void AwardsButton_MouseEnter(object sender, MouseEventArgs e)
        {
            buttonHoverInit(AwardsButton);
        }

        private void NationsButton_MouseEnter(object sender, MouseEventArgs e)
        {
            buttonHoverInit(NationsButton);
        }

        private void CitiesButton_MouseEnter(object sender, MouseEventArgs e)
        {
            buttonHoverInit(CitiesButton);
        }

        private void ClubsButton_MouseEnter(object sender, MouseEventArgs e)
        {
            buttonHoverInit(ClubsButton);
        }

        private void CompetitionsButton_MouseEnter(object sender, MouseEventArgs e)
        {
            buttonHoverInit(CompetitionsButton);
        }

        private void PlayersButton_MouseEnter(object sender, MouseEventArgs e)
        {
            buttonHoverInit(PlayersButton);
        }

        private void StaffButton_MouseEnter(object sender, MouseEventArgs e)
        {
            buttonHoverInit(StaffButton);
        }

        private void AwardsButton_MouseLeave(object sender, MouseEventArgs e)
        {
            buttonLeavesInit(AwardsButton);
        }

        private void NationsButton_MouseLeave(object sender, MouseEventArgs e)
        {
            buttonLeavesInit(NationsButton);
        }

        private void CitiesButton_MouseLeave(object sender, MouseEventArgs e)
        {
            buttonLeavesInit(CitiesButton);
        }

        private void ClubsButton_MouseLeave(object sender, MouseEventArgs e)
        {
            buttonLeavesInit(ClubsButton);
        }

        private void CompetitionsButton_MouseLeave(object sender, MouseEventArgs e)
        {
            buttonLeavesInit(CompetitionsButton);
        }

        private void PlayersButton_MouseLeave(object sender, MouseEventArgs e)
        {
            buttonLeavesInit(PlayersButton);
        }

        private void StaffButton_MouseLeave(object sender, MouseEventArgs e)
        {
            buttonLeavesInit(StaffButton);
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
