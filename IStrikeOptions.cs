using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operatuin
{
    internal interface IStrikeOptions
    {
        List<string> VulnerableTargets { get; set; } // הצגת נגד מה הם יכולים לתקוף : מבנים או ...

        // אני צריך את השם של הכלי - ממה זה יורכב? את זה אני אחליט בתוך המחלקה עצמ
        void ShowUniqueName();
        //הצג את כמות החימוש(הפצצות) שנותר
        void ShowTheAmountOfAmmunitionRemaining();

        // הצגת כמות דלק לצורך חישוב - בלי להיכנס עכשיו לנושא של "דלק"   ץ
        // הצג האם אפשרי תקיפה בהתבסס על דלק ומרחק
        // Show whether an attack is possible based on fuel and distance
        void ShowWhetherAnAttack();
    }
}