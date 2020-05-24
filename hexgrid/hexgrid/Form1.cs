using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        int plr1pos = 44;

        int plr2dir = 1;
        int plr2pos = 44;

        string turn = "blue";

        public Form1()
        {
            InitializeComponent();
            //player 1 directional control
            
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            while (game == true)
            {
                
            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            plr1dir = plr1dir - 1;
            if (plr1dir < 1)
            {
                plr1dir = 6;
            }
        }


        private void btnR_Click(object sender, EventArgs e)
        {
            plr1dir = plr1dir + 1;
            if (plr1dir > 6)
            {
                plr1dir = 1;
            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            //knop vooruit elke richting

            //moet nog controle maken voorkomen illegale tegels en tegels die niet bestaan.
            if( turn == "blue")
            {
                if (plr1dir == 1)
                {
                    plr1pos = plr1pos - 1;
                }
                if (plr1dir == 2)
                {
                    plr1pos = plr1pos + 10;
                }
                if (plr1dir == 3)
                {
                    plr1pos = plr1pos + 11;
                }
                if (plr1dir == 4)
                {
                    plr1pos = plr1pos + 1;
                }
                if (plr1dir == 5)
                {
                    plr1pos = plr1pos - 10;
                }
                if (plr1dir == 6)
                {
                    plr1pos = plr1pos - 11;
                }

                //einde beurt blauw
                turn = "red";
            }

            //speler rood vooruit bewegen in elke richting
            if(turn == "red")
            {
                if (plr2dir == 1)
                {
                    plr2pos = plr2pos - 1;
                }
                if (plr2dir == 2)
                {
                    plr2pos = plr2pos + 10;
                }
                if (plr2dir == 3)
                {
                    plr2pos = plr2pos + 11;
                }
                if (plr2dir == 4)
                {
                    plr2pos = plr2pos + 1;
                }
                if (plr2dir == 5)
                {
                    plr2pos = plr2pos - 10;
                }
                if (plr2dir == 6)
                {
                    plr2pos = plr2pos - 11;
                }

                //einde beurt rood
                turn = "blue";
            }
            //positie markeren blauw
            if( plr1pos == 00) { btnX0Y0.BackColor = Color.Blue; }
            if (plr1pos == 01) { btnX0Y1.BackColor = Color.Blue; }
            if (plr1pos == 03) { btnX0Y3.BackColor = Color.Blue; }
            if (plr1pos == 04) { btnX0Y4.BackColor = Color.Blue; }
            if (plr1pos == 10) { btnX1Y0.BackColor = Color.Blue; }
            if (plr1pos == 11) { btnX1Y1.BackColor = Color.Blue; }
            if (plr1pos == 12) { btnX1Y2.BackColor = Color.Blue; }
            if (plr1pos == 13) { btnX1Y3.BackColor = Color.Blue; }
            if (plr1pos == 14) { btnX1Y4.BackColor = Color.Blue; }
            if (plr1pos == 15) { btnX1Y5.BackColor = Color.Blue; }
            if (plr1pos == 20) { btnX2Y0.BackColor = Color.Blue; }
            if (plr1pos == 21) { btnX2Y1.BackColor = Color.Blue; }
            if (plr1pos == 22) { btnX2Y2.BackColor = Color.Blue; }
            if (plr1pos == 23) { btnX2Y3.BackColor = Color.Blue; }
            if (plr1pos == 24) { btnX2Y4.BackColor = Color.Blue; }
            if (plr1pos == 25) { btnX2Y5.BackColor = Color.Blue; }
            if (plr1pos == 26) { btnX2Y6.BackColor = Color.Blue; }
            if (plr1pos == 30) { btnX3Y0.BackColor = Color.Blue; }
            if (plr1pos == 31) { btnX3Y1.BackColor = Color.Blue; }
            if (plr1pos == 32) { btnX3Y2.BackColor = Color.Blue; }
            if (plr1pos == 33) { btnX3Y3.BackColor = Color.Blue; }
            if (plr1pos == 34) { btnX3Y4.BackColor = Color.Blue; }
            if (plr1pos == 35) { btnX3Y5.BackColor = Color.Blue; }
            if (plr1pos == 36) { btnX3Y6.BackColor = Color.Blue; }
            if (plr1pos == 37) { btnX3Y7.BackColor = Color.Blue; }
            if (plr1pos == 40) { btnX4Y0.BackColor = Color.Blue; }
            if (plr1pos == 41) { btnX4Y1.BackColor = Color.Blue; }
            if (plr1pos == 42) { btnX4Y2.BackColor = Color.Blue; }
            if (plr1pos == 43) { btnX4Y3.BackColor = Color.Blue; }
            if (plr1pos == 44) { btnX4Y4.BackColor = Color.Blue; }
            if (plr1pos == 45) { btnX4Y5.BackColor = Color.Blue; }
            if (plr1pos == 46) { btnX4Y6.BackColor = Color.Blue; }
            if (plr1pos == 47) { btnX4Y7.BackColor = Color.Blue; }
            if (plr1pos == 48) { btnX4Y8.BackColor = Color.Blue; }
            if (plr1pos == 51) { btnX5Y1.BackColor = Color.Blue; }
            if (plr1pos == 52) { btnX5Y2.BackColor = Color.Blue; }
            if (plr1pos == 53) { btnX5Y3.BackColor = Color.Blue; }
            if (plr1pos == 54) { btnX5Y4.BackColor = Color.Blue; }
            if (plr1pos == 55) { btnX5Y5.BackColor = Color.Blue; }
            if (plr1pos == 56) { btnX5Y6.BackColor = Color.Blue; }
            if (plr1pos == 57) { btnX5Y7.BackColor = Color.Blue; }
            if (plr1pos == 58) { btnX5Y8.BackColor = Color.Blue; }
            if (plr1pos == 62) { btnX6Y2.BackColor = Color.Blue; }
            if (plr1pos == 63) { btnX6Y3.BackColor = Color.Blue; }
            if (plr1pos == 64) { btnX6Y4.BackColor = Color.Blue; }
            if (plr1pos == 65) { btnX6Y5.BackColor = Color.Blue; }
            if (plr1pos == 66) { btnX6Y6.BackColor = Color.Blue; }
            if (plr1pos == 67) { btnX6Y7.BackColor = Color.Blue; }
            if (plr1pos == 68) { btnX6Y8.BackColor = Color.Blue; }
            if (plr1pos == 73) { btnX7Y3.BackColor = Color.Blue; }
            if (plr1pos == 74) { btnX7Y4.BackColor = Color.Blue; }
            if (plr1pos == 75) { btnX7Y5.BackColor = Color.Blue; }
            if (plr1pos == 76) { btnX7Y6.BackColor = Color.Blue; }
            if (plr1pos == 77) { btnX7Y7.BackColor = Color.Blue; }
            if (plr1pos == 78) { btnX7Y8.BackColor = Color.Blue; }
            if (plr1pos == 84) { btnX8Y4.BackColor = Color.Blue; }
            if (plr1pos == 85) { btnX8Y5.BackColor = Color.Blue; }
            if (plr1pos == 86) { btnX8Y6.BackColor = Color.Blue; }
            if (plr1pos == 87) { btnX8Y7.BackColor = Color.Blue; }
            if (plr1pos == 88) { btnX8Y8.BackColor = Color.Blue; }


            //positie markeren rood
            if (plr2pos == 00) { btnX0Y0.BackColor = Color.Red; }
            if (plr2pos == 01) { btnX0Y1.BackColor = Color.Red; }
            if (plr2pos == 03) { btnX0Y3.BackColor = Color.Red; }
            if (plr2pos == 04) { btnX0Y4.BackColor = Color.Red; }
            if (plr2pos == 10) { btnX1Y0.BackColor = Color.Red; }
            if (plr2pos == 11) { btnX1Y1.BackColor = Color.Red; }
            if (plr2pos == 12) { btnX1Y2.BackColor = Color.Red; }
            if (plr2pos == 13) { btnX1Y3.BackColor = Color.Red; }
            if (plr2pos == 14) { btnX1Y4.BackColor = Color.Red; }
            if (plr2pos == 15) { btnX1Y5.BackColor = Color.Red; }
            if (plr2pos == 20) { btnX2Y0.BackColor = Color.Red; }
            if (plr2pos == 21) { btnX2Y1.BackColor = Color.Red; }
            if (plr2pos == 22) { btnX2Y2.BackColor = Color.Red; }
            if (plr2pos == 23) { btnX2Y3.BackColor = Color.Red; }
            if (plr2pos == 24) { btnX2Y4.BackColor = Color.Red; }
            if (plr2pos == 25) { btnX2Y5.BackColor = Color.Red; }
            if (plr2pos == 26) { btnX2Y6.BackColor = Color.Red; }
            if (plr2pos == 30) { btnX3Y0.BackColor = Color.Red; }
            if (plr2pos == 31) { btnX3Y1.BackColor = Color.Red; }
            if (plr2pos == 32) { btnX3Y2.BackColor = Color.Red; }
            if (plr2pos == 33) { btnX3Y3.BackColor = Color.Red; }
            if (plr2pos == 34) { btnX3Y4.BackColor = Color.Red; }
            if (plr2pos == 35) { btnX3Y5.BackColor = Color.Red; }
            if (plr2pos == 36) { btnX3Y6.BackColor = Color.Red; }
            if (plr2pos == 37) { btnX3Y7.BackColor = Color.Red; }
            if (plr2pos == 40) { btnX4Y0.BackColor = Color.Red; }
            if (plr2pos == 41) { btnX4Y1.BackColor = Color.Red; }
            if (plr2pos == 42) { btnX4Y2.BackColor = Color.Red; }
            if (plr2pos == 43) { btnX4Y3.BackColor = Color.Red; }
            if (plr2pos == 44) { btnX4Y4.BackColor = Color.Red; }
            if (plr2pos == 45) { btnX4Y5.BackColor = Color.Red; }
            if (plr2pos == 46) { btnX4Y6.BackColor = Color.Red; }
            if (plr2pos == 47) { btnX4Y7.BackColor = Color.Red; }
            if (plr2pos == 48) { btnX4Y8.BackColor = Color.Red; }
            if (plr2pos == 51) { btnX5Y1.BackColor = Color.Red; }
            if (plr2pos == 52) { btnX5Y2.BackColor = Color.Red; }
            if (plr2pos == 53) { btnX5Y3.BackColor = Color.Red; }
            if (plr2pos == 54) { btnX5Y4.BackColor = Color.Red; }
            if (plr2pos == 55) { btnX5Y5.BackColor = Color.Red; }
            if (plr2pos == 56) { btnX5Y6.BackColor = Color.Red; }
            if (plr2pos == 57) { btnX5Y7.BackColor = Color.Red; }
            if (plr2pos == 58) { btnX5Y8.BackColor = Color.Red; }
            if (plr2pos == 62) { btnX6Y2.BackColor = Color.Red; }
            if (plr2pos == 63) { btnX6Y3.BackColor = Color.Red; }
            if (plr2pos == 64) { btnX6Y4.BackColor = Color.Red; }
            if (plr2pos == 65) { btnX6Y5.BackColor = Color.Red; }
            if (plr2pos == 66) { btnX6Y6.BackColor = Color.Red; }
            if (plr2pos == 67) { btnX6Y7.BackColor = Color.Red; }
            if (plr2pos == 68) { btnX6Y8.BackColor = Color.Red; }
            if (plr2pos == 73) { btnX7Y3.BackColor = Color.Red; }
            if (plr2pos == 74) { btnX7Y4.BackColor = Color.Red; }
            if (plr2pos == 75) { btnX7Y5.BackColor = Color.Red; }
            if (plr2pos == 76) { btnX7Y6.BackColor = Color.Red; }
            if (plr2pos == 77) { btnX7Y7.BackColor = Color.Red; }
            if (plr2pos == 78) { btnX7Y8.BackColor = Color.Red; }
            if (plr2pos == 84) { btnX8Y4.BackColor = Color.Red; }
            if (plr2pos == 85) { btnX8Y5.BackColor = Color.Red; }
            if (plr2pos == 86) { btnX8Y6.BackColor = Color.Red; }
            if (plr2pos == 87) { btnX8Y7.BackColor = Color.Red; }
            if (plr2pos == 88) { btnX8Y8.BackColor = Color.Red; }
        }

    }
}
