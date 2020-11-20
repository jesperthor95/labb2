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

namespace harrypotterdel1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public abstract class House
    {
        public string houseGhost;
        public string mascot;
        public string password;
    }

    public class Ravenclaw : House
    {
        public Ravenclaw()
        {
            houseGhost = "Grå damen";
            mascot = "Örn";
            password = "A circle has no beginning";
        }
    }

    public class Gryffindor : House
    {
        public Gryffindor()
        {
            houseGhost = "Nästan Huvudlöse Nick";
            mascot = "Lejon";
            password = "Fortuna Major";
        }
    }
        
    

    public class Slytherin : House
    {
        public Slytherin()
        {
            houseGhost = "Blodige Baronen";
            mascot = "Orm";
            password = "Pure-Blood";
        }
    }

    public class Hufflepuff : House
    {

        public Hufflepuff()
        {
             houseGhost = "Den Tjocke Munkbrodern";
             mascot = "Grävling";
             password = "";
        }
    }

    public class wizard
    {
        public string bloodStatus = "";
        public bool deathEater;
        public bool dumbledoresArmy;
        public string name = "";
       
    }

   

    public partial class MainWindow : Window
    {
        public Ravenclaw raven = new Ravenclaw();
        public Gryffindor gryff = new Gryffindor();
        public Slytherin slyt = new Slytherin();
        public Hufflepuff huff = new Hufflepuff();
        

        public MainWindow()
        {
            InitializeComponent();
             MessageBox.Show(raven.mascot + raven.houseGhost + raven.password);
             MessageBox.Show(gryff.mascot + gryff.houseGhost + gryff.password);
             MessageBox.Show(slyt.mascot + slyt.houseGhost + slyt.password);
             MessageBox.Show(huff.mascot + huff.houseGhost + huff.password);
        }
        
        
    }
}
