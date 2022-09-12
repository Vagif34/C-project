using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Project.pRoject
{
    class CRUD_user_
    {
        static bool Checkname(string Name)
        {
            if (!string.IsNullOrWhiteSpace(Name))
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (!Char.IsDigit(Name[i]))
                    {
                        return false;
                    }

                }
                return true;
            }
            return false;
        }
        public static void Registration(List<USER> uSERs)
        {

            Console.WriteLine("Enter Name:");
            string Name = Console.ReadLine();
        falseName:
            Console.Clear();
            if (Checkname(Name))
            {
                goto falseName;
            }

            static bool CheckSurname(string SurName)
            {
                if (!string.IsNullOrWhiteSpace(SurName))
                {
                    for (int i = 0; i < SurName.Length; i++)
                    {
                        if (!Char.IsDigit(SurName[i]))
                        {
                            return false;
                        }

                    }
                    return true;
                }
                return false;

                Console.WriteLine("Enter SurName:");
                string surName = Console.ReadLine();
                falseSurName:
                Console.Clear();
                if (Checkname(SurName))
                {
                    goto falseSurName;
                }
            }
        }
    }
}
