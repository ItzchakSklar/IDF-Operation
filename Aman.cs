using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Project
{
    internal class Aman
    {
<<<<<<< HEAD
        public Terrorist LinkedTerrorist { get; private set; }
        private string plias { get; set; }
        public DateTime TimeStamp { get; private set; } = DateTime.Now;
        public void UpdateTimeStamp()
        {
            TimeStamp = DateTime.Now;
        }
=======
        private List<TerroristTracker> Teroristes = new List<TerroristTracker>();
        public void AddTerorrist(TerroristTracker Terorist)
            Teroristes.Add(Terorist)



>>>>>>> master
    }
}
