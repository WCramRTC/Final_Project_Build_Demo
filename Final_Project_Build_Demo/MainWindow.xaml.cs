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
using MyMathLibrary;

namespace Final_Project_Build_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Boat boat = new Boat("SSLetzSea");
            try
            {
                rtbDisplay.Text = "";

           
                DisplayTextLine(boat.ToString());

                boat.Accelerate(-15);

                DisplayTextLine(boat.ToString());
            }
            catch (BoatException bx)
            {
                MessageBox.Show(bx.ToString());
            }
            catch (Exception ex)
            {

            }




            //double sum = Operations.Add(10, 20);

            //MessageBox.Show(sum.ToString());

            // Exceptions

        }

        // Helper Methods
        // Basic methods that assist with my workflow
        public void DisplayText(string message)
        {
            rtbDisplay.Text += message;
        }

        public void DisplayTextLine(string message)
        {
            rtbDisplay.Text += message + "\n";
        }

    }
}
