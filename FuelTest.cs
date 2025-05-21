using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operatuin
{
    //פעולות מימוש עתידיות של המחלקה: אמור להיות איזשהו ערך שבשעת טיסה לדוגמא יוריד את כמות הדלק במטוס 

    internal class FuelTest // זה המיכל שיש למטוסים או לכלי תקיפות - אולי מיכלי דלק בבסיסים יהיו מימוש שונה  אולי זה 
    {
        private double Fuelquantity;
        private FuelTest()
        {
            Fuelquantity = 0.00;
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
        //מתודה נסיונית לריקון אובייקט אחד ומילוי השני
        private void UpdateFuelquantityNN(double number, Fuel other)
        {
            Fuelquantity = Fuelquantity + number;
            FuelTest.
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
        //יכול להיות שנממש את המתודה בצורה של ריקון מיכל אחד ומילוי מיכל שני - אולי מימוש אחר - לבדוק ולהתייעץ
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
    }
}
