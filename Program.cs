using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        public static bool HasChildren(Citizen citizen)
        {
            if (citizen.children.Length == 0)
            {
                return false;
            }
            return true;

        }
        public static bool CheckValidity(Citizen citizen)
        {
            if (citizen.children.Length != 0)
            {
                for (int i = 0; i < citizen.children.Length; i++)
                {
                    if (citizen.children[i].fatherID != citizen.id)
                    {
                        return false;
                    }
                }

            }
            return true;
        }
        
        static void Main(string[] args)
        {
            Citizen c = new Citizen("rafi", 0);
            Citizen d = new Citizen("john", 1);
            Citizen h = new Citizen("raz", 1);
            Citizen p = new Citizen("lilach", 1);
            Citizen[] children = { d, h, p };
            c.SetChildren(children);
            Console.WriteLine(HasChildren(c));

        }
    }
}
