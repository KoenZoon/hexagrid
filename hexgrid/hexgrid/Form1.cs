using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hexgrid
{
    public partial class Form1 : Form
    {
        Boolean game = true;
        int plr1dir = 1;

        string plr1pos = "btnX4Y4";
        public Form1()
        {
            InitializeComponent();
            //player 1 directional control
            
            if (plr1dir > 6)
            {
                plr1dir = 1;
            }
            if(plr1dir < 1)
            {
                plr1dir = 6;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            while (game == true)
            {
                //knop vooruit
                if (plr1dir == 1)
                {
                    //als je vooruit gaat
                    plr1pos = "btn" + "X" + "Y";
                }
                if (plr1dir == 2)
                {

                }
                if (plr1dir == 3)
                {

                }
                if (plr1dir == 4)
                {

                }
                if (plr1dir == 5)
                {

                }
                if (plr1dir == 6)
                {

                }
            }
        }
    }
}
