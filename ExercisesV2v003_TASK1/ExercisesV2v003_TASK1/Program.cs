using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesV2v003_TASK1
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            List<students> student_list = new List<students>() {
                new students() { ID = 1, name= "TOM" },
                new students() { ID = 2, name= "MARRY"}
            };
            foreach (students i in student_list)
            {
                Console.WriteLine("ID: {0} Name: {1}",i.ID, i.name);
            }
            Console.Read();
           
        }
    }
        class students {
            public int ID{
                get;set;
            }
            public string name {
                get;set;
            }
        }
    
}
/*------------USING ARRAY------------
 *------------Method 1------------- 
 string[,] array = new string[,] {
              {"TOM", "1" },
              {"MARRY", "2" }
          };
          for (int i=0; i < array.GetLength(0); i++)
          {
             for (int y = 1; y >= 0; y--)
              {

                  if (y==1)
                  {
                      Console.Write("id: " + array[i, y]);
                  }
                  if (y == 0)
                  {
                      Console.Write(" name: " + array[i, y]);
                  }
              }
              Console.WriteLine(" ");
          }
          Console.Read();
          --------------------------------------------*/

/*----------Method 2---------------
     static void Main(string[] args)
     {
         string[,] array= new string[,] {
             { "1","TOM" },
             {"2","MARRY" }
         };
         for (int i=0; i < array.GetLength(0);i++)
         {
             Console.Write("ID: {0} Name: {1} ", array[i, 0], array[i,1]);
             Console.WriteLine();
         }

         Console.Read();
     }
----------------------------------*/
