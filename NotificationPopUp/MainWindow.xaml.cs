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
using Tulpep.NotificationWindow;

namespace NotificationPopUp
{
    /// <summary>
    /// Koristi se Tulpep.NotificationWindow package
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.informationImg;
            popup.TitleText = "Obaveštenje !!!";
            popup.ContentText = tBoxMessage.Text;
            popup.AnimationDuration = 2000;
            

            // da prikaže  PopUp Window u donjem desnom uglu ekrana sa porukom iz textBox-a 
            popup.Popup();
        }
    }
}
