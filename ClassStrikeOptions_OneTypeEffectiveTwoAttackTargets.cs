using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operatuin
{
    internal class ClassStrikeOptions_OneTypeEffectiveTwoAttackTargets
    {
        public string NameOfThetool;//שם הכלי

        public List<string> TypesOfBombs;//סוגי פצצות
        public Dictionary<string, int> SumOfBombs = new Dictionary<string, int>();//סך הפצצות

        public List<string> EffectiveAgainst;//יעיל נגד

        public string PoweredBy;//מופעל על ידי 
    }
}
