using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operatuin
{
    internal class F16Fighter
    {
        private string NameOfThetool;//שם הכלי
        private List<string> TypesOfBombs;//סוגי פצצות
        private Dictionary<string, int> SumOfBombs = new Dictionary<string, int>();//סך הפצצות
        private List<string> EffectiveAgainst;//יעיל נגד
        private string PoweredBy;//מופעל על ידי

        //constractlor
        public F16Fighter()
        {
            //start
            NameOfThetool = "F-16 fighter jet";
            TypesOfBombs = new List<string>{ "0.5 Tons", "1.0 Tons" };
            //update value List "TypesOfBombs"
            SumOfBombs["0.5 Tons"] = 4;
            SumOfBombs["1.0 Tons"] = 4;
            //update value EffectiveAgainst
            EffectiveAgainst = new List<string>{ "bulding" }; //יעיל  נגד בניינים
            PoweredBy = "Pilot";
            //create Fuel
            Fuel FuelF16Fighter = new Fuel();
            FuelF16Fighter.SetFuel(500.00); //הטענת דלק

        }

        // method
        
        //method of Abstract
        public void ShowUniqueName()
        {
            GetNameOfThetool();
        }


        // אזור של "שם הכלי"

        //The method returns the name of the attack tool
        //and if desired - you can add more.
        public string GetNameOfThetool()
        {
            return $"{NameOfThetool} .";
        }




        //אזור של סוגי פצצות

        // The method checks if there is a selected bomb in the bomb pool.
        // If there is, it drops it and records success.
        public void CarryingOutTheBomb(string bombType)
        {
            // variable "bombType" משמש אותנו לאיזה סוג פצצה להטיל

            if (SumOfBombs[bombType] > 0)
            {
                SumOfBombs[bombType]--;
                Console.WriteLine("The bomb exists in the bomber's database.");
                Console.WriteLine("The bomb was successfully dropped.");
            }
            else
            {
                Console.WriteLine("No explosive device was found on the vessel. Ensure refilling before mission.");
            }
        }
        /*
        //The method replenishes the stock of bombs.
        //(It is better to make this method private.)
        @param: my be validation - check
        @return: Update field "SumOfBombs"
         */
        public void ReloadingTheBombs()
        {
            SumOfBombs["0.5 Tons"] = 4;
            SumOfBombs["1.0 Tons"] = 4;
        }
        /*
        This method - and the one that comes after it (the private one) 
        - returns the amount of bombs left.
        @param:
        @return: string of List Sum OF the Bomb
         */
        public string AmountOfBombsInTheBomber()
        {
            string returnAllString = " Amount of bombs remaining : \n";
            foreach (string i in SumOfBombs.Keys)
            {
                string returnSNumber = "";
                returnSNumber = GetBombTotal(i);

                returnAllString +=  $" {i} -> {returnSNumber} . \n";
            }
            
            return returnAllString;
        }
        //A private method related to the one above it  
        private string GetBombTotal(string bombType)
        {
            int numberOfList = 0 ;
            string returnNumberString = "" ;
            
            numberOfList = SumOfBombs[bombType]; //type int

            returnNumberString = Convert.ToString(numberOfList); //casting
            return returnNumberString;
        }

        //אזור של "יעיל נגד" 

        // A method that brings "effective against"
        public string GetEffectiveAgainst()  
        {
            string returnString = "";
            foreach(string i in EffectiveAgainst)
            {
                returnString += $"{i}, ";
            }
            return returnString;
        }

        // אזור של "מופעל ע"י"
        
        // A method that brings up "Powered by"
        public string GetPoweredBy()
        {
            return $"{PoweredBy} .";
        }

    }
}
