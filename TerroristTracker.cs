using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Project
{
    internal class TerroristTracker
    {
        public Terrorist LinkedTerrorist { get; private set; }
        private string Plias { get; set; }
        public DateTime TimeStamp { get; private set; } = DateTime.Now;
        public void UpdateTimeStamp()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
