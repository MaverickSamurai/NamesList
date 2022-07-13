using System;
using System.Collections.Generic;

namespace CheckName
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namelist = new List<string>() { "Mirsamir", "Sadiq", "Cavid", "Orxan", "Ramil", "Esqin", "Cabbar", "Abbas", "Fuad"};

            GetNamesList(CheckName, namelist);
            
            

            
        }

        public static bool CheckName(string name)
        {
            return name != "Cavid";
        }


        public static void GetNamesList(Predicate<string> predicate, List<string> checkname)
        {
            
            foreach (var item in checkname)
            {
                if (predicate(item))
                {
                    Console.WriteLine(item);
                }
            }

            
        }



    }



   
}
