using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operatuin
{
    internal class Fuel
    {
        //פעולות מימוש עתידיות של המחלקה: אמור להיות איזשהו ערך שבשעת טיסה לדוגמא יוריד את כמות הדלק במטוס 

        //איזשהו משתנה פנימי שמגדיר את כמות הדלק הכוללת
        private double Fuelquantity = 0.00;

        //שדה המגדיר כל ק"מ כמה יוריד דלק 
        private double CalculateKM = 1.00;

        private bool IsStarted;

        public Fuel()
        {
            IsStarted = false;
            AirplaneInTheAir();
        } 
        

        
        /*
         Method type "void" after validation that is approved
        check updates the fuel quantity
        @param: double
        @return : 
         */
        private void UpdateFuelquantity(double number)
        {
            Fuelquantity = Fuelquantity + number;
        }
        /*
            Security and validation method
            @param: string SecurityName , double Count
            @return :
             */
        private void ValidationTestFuel(string userName, double number)
        {
            if (userName == "1234")
            {
                UpdateFuelquantity(number);
            }
            else
            {
                Console.WriteLine("Error - class Fuel - method 'ValidationTestFuel' . ");
            }
        }
        /*
            A method that updates the amount of fuel 
            with validation
            @param: double
            @return :
             */
        public void SetFuel(double NewUpdateValue)
        {
            string inputUser = "";
            Console.WriteLine("enter password: ");
            inputUser = Console.ReadLine();
            ValidationTestFuel(inputUser, NewUpdateValue);
        }
        /*
            A method that returns the current fuel value.
            @param: 
            @return:doubl of current fuel value.
             */
        public double GetFuel()
        {
            return Fuelquantity;
        }

        /*
            A method that begins to calculate a tool in action
         */
        public void TakeOff()
        {
            IsStarted = true;
        }
        /*
            A method that stops calculating a tool in action
         */
        public void Loading()
        {
            IsStarted = false;
        }
        /*
            A method that calculates fuel consumption while the vehicle is in operation
         */
        private void AirplaneInTheAir()
        {
            while(true)
            {
                if (IsStarted)
                {
                    Fuelquantity = Fuelquantity - CalculateKM;
                    Task.Delay(1000);
                }
            } 
        }
        /*
            A method that calculates fuel consumption time while the tool is in operation
         */
        public void CalculateFuelTime(int timeMonth) // , DateTime timeInput)
        {
            if (timeMonth == 0)
            {
                int monthInt = 0;
                int hourInt = 0;

                //מציג את השעה הנוכחית ומוציא דקות
                DateTime timeNow = DateTime.Now;

                string Month = timeNow.Month.ToString();
                string hour = timeNow.Hour.ToString();
                monthInt = Convert.ToInt32(Month);//casting 
                hourInt = Convert.ToInt32(hour);
                //לעשות חישוב של פחות הזמן שהגיע 
            }
        }
            
    }
}
