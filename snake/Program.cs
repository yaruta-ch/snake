using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point(1,3,'*');
            p1.Draw();

            point p2 = new point(5,14,'#');
            p2.Draw();


            List<char> chList = new List<char>();
            chList.Add('$');
            chList.Add('^');
            chList.Add('&');

            char x = chList[0];
            char y = chList[1];

            foreach(char i in chList)
            {
                Console.WriteLine(i);
            }

            chList.RemoveAt(1);

            List<point> pList = new List<point>();
            pList.Add(p1);
            pList.Add(p2);

            Console.ReadLine();
        }
        
    }
}
