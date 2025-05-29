using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IDF_Operatuin;

namespace IDF_Operatuin.UserMenu
{
    internal class UserMenuMain
    {
        private static UserMenuMain instance = null;
        private static readonly object lockObj = new object();
    
        //constractor
        private UserMenuMain() { }

        public static UserMenuMain GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj) //נעילת האובייקט
                {
                    if (instance == null)
                    {
                        instance = new UserMenuMain();
                    }
                }
            }
            return instance;
        }


    }
}
