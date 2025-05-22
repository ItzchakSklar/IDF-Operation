using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IDF_Project
{
    internal class Terrorist
    {
        private string Name { get; set; }
        private int Rank { get; set; }
        private string Status;
        private List<string> Weapons = new List<string>();
        public Terrorist(string name,int levelRank,string status)
        {
            Name = name;
            ValidateStatus(status);


        }
        private bool ValidateStatus(string status)
        {
            if (new[] { "a", "b", "c" }.Contains(status))
            {
                Status = status;
                return true;
            }
            else
            {
                Console.WriteLine("not a velable value");
                return false;
            }
        }
        private bool AddWeapons(string Weapon)
        {
            if (new[] { "knife", "gun", "M16", "AK47"}.Contains(Weapon))
            {
                Weapons.Add(Weapon);
                return true;
            }
            else
            {
                Console.WriteLine("not a velable Weapon");
                return false;
            }
        }

    }
}
