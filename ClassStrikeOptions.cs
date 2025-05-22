using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IDF_Operatuin;


namespace IDF_Operatuin
{
    
    internal class StrikeOptions : ClassAbstractStrikeOption
    {
        public string NameOfThetool;//שם הכלי
        
        public List<string> TypesOfBombs;//סוגי פצצות
        public Dictionary<string, int> SumOfBombs = new Dictionary<string,int>();
        public List<string> VulnerableTargets; //הצגת נגד מה הם יעילים בתקיפה

        public List<string> EffectiveAgainst;//יעיל נגד

        public StrikeOptions(string name, List<string> effectivs, List<string> Bomb, List<string> vulnerableTargets)
        {
            //לעת עתה - אח"כ לשנות
            NameOfThetool = name;
            EffectiveAgainst = effectivs;
            CrateOfSumOfBombs();
            VulnerableTargets = vulnerableTargets;
        }

        private void CrateOfSumOfBombs()
        {
            foreach(string value in EffectiveAgainst)
            {
                Console.WriteLine();
                int sumOfBomb = Console.ReadLine(); // זה סתם - ליצור ערך שיעדכן 
                SumOfBombs.Add(value, sumOfBomb);
            }
        }

        public void CalculationOfFuelForBombing()
        {

        }//חישוב דלק להפצצה
        public  void ShowUniqueName() { }
        public  void ShowTheAmountOfAmmunitionRemaining() { }
        public void ShowWhetherAnAttack() { }
    }
}
