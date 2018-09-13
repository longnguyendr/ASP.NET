using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesV2v003_TASK2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 90, 71, 82, 93, 75, 82 };
            int[] Correctnum = num.Where(n => n > 80).ToArray();
            Console.Write("{0} scores are greater than 80 \n ", Correctnum.Count());
            Console.WriteLine();
            foreach(int i in Correctnum)
            {
                Console.Write("{0} ", i);
            }
            
            Console.Read();
        }
            
    }
}
/*----------------LIST<T> style---------------
 *          List<int> num = new List<int>{ 90, 71, 82, 93, 75, 82 };
            List<int> Correctnum = num.Where(n => n > 80).ToList();
            Console.Write("{0} scores are greater than 80 \n ", Correctnum.Count);
            Console.WriteLine();
            foreach(int i in Correctnum)
            {
                Console.Write("{0} ", i);
            }
            
            Console.Read();
*/

/*--------------------------Normal style-------------
 * static void Main(string[] args)
{
    List<listnum> Show_num = new List<listnum>()
            {
                new listnum() { Numcount = 90 },
                new listnum() { Numcount = 71 },
                new listnum() { Numcount = 82 },
                new listnum() { Numcount = 93 },
                new listnum() { Numcount = 75 },
                new listnum() { Numcount = 82 }
            };
    int z = 0;
    foreach (listnum i in Show_num)
    {
        z++;
        if (i.Numcount < 80)
        {
            z--;
            continue;
        }
    }
    Console.Write("{0} scores are greater than 80 \n They are:", z);

    foreach (listnum i in Show_num)
    {
        if (i.Numcount > 80)
        {
            Console.Write(" {0} ", i.Numcount);
        }

    }
    Console.Read();
}
    }

    public class listnum
{
    private int num;

    public int Numcount
    {
        get { return num; }
        set { num = value; }
    }*/
