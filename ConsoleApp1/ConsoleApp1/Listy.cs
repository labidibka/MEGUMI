using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Listy
    {
        public List<int> StworzListe()
        {
            List<int> list = new List<int>();
            string decyzja = "";
           while(decyzja == "t")
            {
                Console.WriteLine("Czy chcesz dodać element do listy");
                decyzja = Console.ReadLine();
                if(decyzja == "t")
                {
                    Console.WriteLine("Podaj element: ");
                    int element = int.Parse(Console.ReadLine());    
                    list.Add(element);
                }
                else
                {
                    Console.WriteLine("Podano wszytskie elementy");
                }
            }
           return list;
        }
        

        
    }
}

