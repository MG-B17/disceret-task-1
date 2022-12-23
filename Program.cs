using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disceret_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MOSTAFA GALAL EL BAKREY AHMED    
            // GROUP 3 
            // SECTION 23


            Console.WriteLine(" Please Inter The First Number :");
            int firstnumber, secondnumber;
            firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Inter The Second Number :");
            secondnumber = int.Parse(Console.ReadLine());

            int loopvariabel1,loopvariable2;
            for (loopvariabel1 = firstnumber; loopvariabel1 <= secondnumber; loopvariabel1++)
            {
                int variableif=0;

                for (loopvariable2 = 1; loopvariable2 <= loopvariabel1; loopvariable2++)
                {
                    if (loopvariabel1 % loopvariable2 == 0)
                        variableif++;
                }
                    if(variableif==2)
                    Console.WriteLine( "PRIME NUMBER "+loopvariabel1);


            }

        }
    }
}
