using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Citizen
    {
        public string name;
        public Citizen[] children;
        public readonly int fatherID;
        public readonly int id = 0;
        public static int numberOfCurrentCitizens = 0;
        public const int MAX_NUM_OF_CITIZENS = 1500000;
        public Citizen(string name, int fatherID)
        {
            this.name = name;
            numberOfCurrentCitizens++;
            this.fatherID = fatherID;
            id = id+1;
        }

        public static void PrintNumberOfCitizens()
        {
            Console.WriteLine($"Number of citizens : {numberOfCurrentCitizens}");
        }
        public static bool ReachedHalfOfMaximumSize()
        {
            if (numberOfCurrentCitizens >= (MAX_NUM_OF_CITIZENS / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }
        public void PrintID()
        {
            Console.WriteLine($"ID : {this.id}");
        }
        public int PrintGapBetweenMyIDAndFather()
        {
            return fatherID - id;
        }
        public void SetChildren(Citizen[] arr)
        {
            this.children = arr;
            
        }
        public override string ToString()
        {
            return $"{base.ToString()} name : {name}, number of current citizens : {numberOfCurrentCitizens}, father id : {fatherID}, id : {id} ";
        }

    }
}
