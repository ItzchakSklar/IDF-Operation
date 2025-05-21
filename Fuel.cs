using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operatuin
{
    internal class Fuel
    {
        private double Fuelquantity;

        /*
         Method type "void" after validation that is approved
        check updates the fuel quantity
        @param: double

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
    }
}
