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
            buttonInit(AwardsButton);
        }

        private void NationsButton_Click(object sender, RoutedEventArgs e)
        {
            buttonInit(NationsButton);
        }

        private void CitiesButton_Click(object sender, RoutedEventArgs e)
        {
            buttonInit(CitiesButton);
        }

        private void ClubsButton_Click(object sender, RoutedEventArgs e)
        {

            buttonInit(ClubsButton);
        }

        private void CompetitionsButton_Click(object sender, RoutedEventArgs e)
        {
            buttonInit(CompetitionsButton);
        }

        private void PlayersButton_Click(object sender, RoutedEventArgs e)
        {
            buttonInit(PlayersButton);
        }

        private void StaffButton_Click(object sender, RoutedEventArgs e)
        {
            buttonInit(StaffButton);
        }


        private void buttonInit(Button clickedButton)
        {
            foreach (Button button in myButtons)
            {
                button.BorderThickness = new Thickness(0,0, 0, 0);
            }

            clickedButton.BorderThickness = new Thickness(1, 1, 1, 0);
        }

    }
}
