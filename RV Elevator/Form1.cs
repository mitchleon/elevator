using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Timers;

namespace RV_Elevator
{
    public partial class Form1 : Form
    {
        public int DoorTimer1 = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void Add_Elevator_Click(object sender, EventArgs e)
        {
            Floor_Text_2.Visible = true;
            Floor1_Button_2.Visible = true;
            Floor2_Button_2.Visible = true;
            Floor3_Button_2.Visible = true;
            Floor4_Button_2.Visible = true;
            Floor5_Button_2.Visible = true;
            Open_Button_2.Visible = true;
            Close_Button_2.Visible = true;
            Person_Off_Button_2.Visible = true;
            Person_On_Button_2.Visible = true;
            Help_Button_2.Visible = true;
            Help_Text2.Visible = true;
            Helped_Button_2.Visible = true;
            Weight_Text_2.Visible = true;
            Door_Status_Text_2.Visible = true;
            Direction_Text_2.Visible = true;
            Password_Text_2.Visible = true;
            Wait_Time_Text_2.Visible = true;
            Up1_Button_2.Visible = true;
            Up2_Button_2.Visible = true;
            Up3_Button_2.Visible = true;
            Up4_Button_2.Visible = true;
            Down2_Button_2.Visible = true;
            Down3_Button_2.Visible = true;
            Down4_Button_2.Visible = true;
            Down5_Button_2.Visible = true;
            label40.Visible = true;
            label39.Visible = true;
            label38.Visible = true;
            label37.Visible = true;
            label36.Visible = true;
            label35.Visible = true;
            label34.Visible = true;
            label32.Visible = true;
            label31.Visible = true;
            label30.Visible = true;
            label29.Visible = true;
            label28.Visible = true;
            label27.Visible = true;
            label26.Visible = true;
            label25.Visible = true;
            label24.Visible = true;
            label23.Visible = true;
            label22.Visible = true;
            label21.Visible = true;
            label20.Visible = true;
        }

        private void Helped_Button_Click(object sender, EventArgs e)
        {

            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\tye\Documents\Visual Studio 2008\Projects\elevatorrepo\11_Kanske_Ar_Jag_Kar_I_Dig.wav");
            simpleSound.Stop();


        }

        private void Help_Button_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\tye\Documents\Visual Studio 2008\Projects\elevatorrepo\11_Kanske_Ar_Jag_Kar_I_Dig.wav");
            simpleSound.PlayLooping();
          
         
     
 
         

        }

        

        private void Open_Button_Click(object sender, EventArgs e)
        {
            DoorTimer1=10;
            timer1.Start();
       
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DoorTimer1--;

            Invalidate();

            if (DoorTimer1 == 0)
            {

                timer1.Stop();

                Invalidate();

                // Beep

                Door_Status_Text.Text = "Open";

            }
        }
    }


}
