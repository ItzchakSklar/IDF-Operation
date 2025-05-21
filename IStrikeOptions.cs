using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operatuin
{
    internal interface IStrikeOptions
    {
        string UniqueName { get; set; }
        Dictionary<string, int> AmmunitionCapacity { get; set; }
        //אספקת דלק אולי תהיה מימוש נוסף של class
        Fuel FuelSupply { get; set; }
        List<string> VulnerableTargets { get; set; }
    }
}