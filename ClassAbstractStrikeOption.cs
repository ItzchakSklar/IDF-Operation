using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operatuin
{
    internal abstract class ClassAbstractStrikeOption 
    {
        //את ההכללה של האינטר פייס צריך לעשולת רק במיין נראה לי
        public string NameOfThetool;//שם הכלי
        public List<string> EffectiveAgainst;//יעיל נגד
        public List<string> TypesOfBombs;//סוגי פצצות
        public List<string> VulnerableTargets; //הצגת נגד מה הם יעילים בתקיפה

        public abstract void CalculationOfFuelForBombing();//חישוב דלק להפצצה
        public abstract void ShowUniqueName();
        public abstract void  ShowTheAmountOfAmmunitionRemaining();
        public abstract void ShowWhetherAnAttack();
    }
}
