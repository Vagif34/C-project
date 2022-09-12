using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Project.pRoject
{
    class Verification
    {
        public static bool NameToAllowed(string Name)
        {
            if (Name.Length > 3 && Name.Length <= 16)
            {
                return true;
            }
            Console.WriteLine("True");
            return false;
        }
        public static bool SurNameToAllowed(string SurName)
        {
            if (SurName.Length > 3 && SurName.Length <= 16)
            {
                return true;
            }
            Console.WriteLine("True");
            return false;
        }

        public static bool LoginToAllowed(string UserName)
        {
            if (UserName.Length > 3 && UserName.Length <= 16)
            {
                return true;
            }
            Console.WriteLine("True");
            return false;
        }

    }
}
