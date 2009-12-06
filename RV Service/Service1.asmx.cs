using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace RV_Service
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public void MovementControl() //tye
        {
            /*
             * need to keep track of the following for service to work:
             * if door open do not move
             * if moving door wont open
             * incrment floor if moving by .25 every second or so
             * which way are we going to go
             * The direction of the elevator will be determined by an array[6]
             * array[0] will represent the state 0 down 1 not moving 2 up
             * array[1-5] will represent request 0 none 1 up 2 down 3 both up and down
             * the easiest way to handle the requests is to handle all requests in current direction that are ahead first
             * then turn around when all completed.  
             * so all up then all down and repeat as neccisary
             * keep in mind the 5th flool is password protected
             * 
             * 
             */

        }

        [WebMethod]
        public bool DoorControl(int open, double floor, int peopletime) //tye
        {
            //open 0 means closing 1 menas open door
            //floor is current floor
            //people time is time on people entering timer

            if (open == 1)
            {
                if (floor == Convert.ToInt32(floor)) //ensures door doesn't open between floors
                    return true;
                else
                    return false;
            }
            else if (open == 0)
            {
                if (peopletime > 0)
                    return false;
                else
                    return true;
            }
            else
                return false;
        }

        [WebMethod]
        public void ExceptionHandling() //tye
        {

        }

        [WebMethod]
        public bool Alarm(int weight, int time)
        {
            if (weight > 1500)
                return true;
            else if (time > 1000)
                return true;
            else return false;
        }
        //test
    }
}
