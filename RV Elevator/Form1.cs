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
        public int PeopleTimer1 = 0;
        public int ElevatorTimer1 = 0;
        public int ElevatorDirection1 = 0;
        //this handles requests from outside the elevator
        //requests[0] is the direction elevator is traveling
        //-1 down 0 none 1 up 2 both
        public int[] requests = new int[] {0,0,0,0,0,0};
        //represents requests to stop at floor form inside elevator
        public int[] stops = new int[] { 0, 0, 0, 0, 0 };
        public int floor = 1;
        string password = "not password";

        RV_Elevator.ServiceReferenceElevator.Service1SoapClient ElevatorService = new RV_Elevator.ServiceReferenceElevator.Service1SoapClient("Service1Soap");


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
            if (ElevatorService.DoorControl(1, Convert.ToDouble(Floor_Text.Text.ToString()), PeopleTimer1) == true)
            {
                DoorTimer1 = 10;
                timerDoor1.Start();
            }
           
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            if (ElevatorService.DoorControl(0, Convert.ToDouble(Floor_Text.Text.ToString()), PeopleTimer1) == true)
            {
                DoorTimer1 = 10;
                timerDoor1.Start();
            }
            else
            {
                while (PeopleTimer1 > 0) ;
                DoorTimer1 = 10;
                timerDoor1.Start();
            }

        }

        

        private void Person_On_Button_Click(object sender, EventArgs e)
        {
            PeopleTimer1 += 10;
            int weight = Convert.ToInt32(Weight_Text.Text.ToString());
            weight += 100;
            Weight_Text.Text = weight.ToString();
            timerPeople1.Start(); //each person takes 10seconds to get on
            if (ElevatorService.Alarm(weight,0))
            {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\tye\Documents\Visual Studio 2008\Projects\elevatorrepo\fat.wav");
            simpleSound.PlayLooping();
            }
        }

        private void Person_Off_Button_Click(object sender, EventArgs e)
        {
            PeopleTimer1 += 10;
            int weight = Convert.ToInt32(Weight_Text.Text.ToString());

            if (weight > 100) weight -= 100;  //100 is weight of elevatore when empty
            timerPeople1.Start(); //each person takes 10 seconds to leave
            Weight_Text.Text = weight.ToString();
            if (!ElevatorService.Alarm(weight, 0))
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\tye\Documents\Visual Studio 2008\Projects\elevatorrepo\fat.wav");
                simpleSound.Stop();
            }
        }

        private void timerPeople1_Tick(object sender, EventArgs e)
        {
            PeopleTimer1--;
            testpeopletext.Text = PeopleTimer1.ToString();
            Invalidate();
            if (PeopleTimer1 == 0)
            {
                timerPeople1.Stop();
                Invalidate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DoorTimer1--;
            if (PeopleTimer1 > 0)
                DoorTimer1 = 10;
            testdoortext.Text = DoorTimer1.ToString();

            Invalidate();

            if (DoorTimer1 == 0)
            {

                timerDoor1.Stop();

                Invalidate();

                // Beep
                if (Door_Status_Text.Text.Equals("Closed"))
                {
                    Door_Status_Text.Text = "Open";
                }
                else Door_Status_Text.Text = "Closed";
            }
        }

        private void timerElevator1_Tick(object sender, EventArgs e)
        {
            ElevatorTimer1++;
            //-1 down 0 stationary 1 up
            if (ElevatorDirection1 == -1)
            { 
            
            }
            if (ElevatorDirection1 == 0)
            {

            }
            if (ElevatorDirection1 == 1)
            {

            }
            Invalidate();
            //need to do some sort of stop logic
            if (Door_Status_Text.Text.Equals("Closed"))// == 0)
            {

                timerElevator1.Stop();
            }
        }

        private void Weight_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Down5_Button_Click(object sender, EventArgs e)
        {
            requests[5] = -1;
        }

        private void Down4_Button_Click(object sender, EventArgs e)
        {
            if (requests[4] == 0)
                requests[4] = -1;
            else
                requests[4] = 2;
        }

        private void Down3_Button_Click(object sender, EventArgs e)
        {
            if (requests[3] == 0)
                requests[3] = -1;
            else
                requests[3] = 2;
        }

        private void Down2_Button_Click(object sender, EventArgs e)
        {
            if (requests[2] == 0)
                requests[2] = -1;
            else
                requests[2] = 2;
        }

        private void Up1_Button_Click(object sender, EventArgs e)
        {
            requests[1] = 1;
        }

        private void Up2_Button_Click(object sender, EventArgs e)
        {
            if (requests[2] == 0)
                requests[2] = 1;
            else
                requests[2] = 2;
        }

        private void Up3_Button_Click(object sender, EventArgs e)
        {
            if (requests[3] == 0)
                requests[3] = 1;
            else
                requests[3] = 2;
        }

        private void UP4_Button_Click(object sender, EventArgs e)
        {
            if (requests[3] == 0)
                requests[3] = 1;
            else
                requests[3] = 2;
        }

        private void Floor5_Button_Click(object sender, EventArgs e)
        {
            if (Password_Text.Text.Equals(password))
                stops[4] = 1;
        }

        private void Floor4_Button_Click(object sender, EventArgs e)
        {
            stops[3] = 1;
        }

        private void Floor1_Button_Click(object sender, EventArgs e)
        {
            stops[0] = 1;
        }

        private void Floor2_Button_Click(object sender, EventArgs e)
        {
            stops[1] = 1;
        }

        private void Floor3_Button_Click(object sender, EventArgs e)
        {
            stops[2] = 1;
        }

        
    }


}
