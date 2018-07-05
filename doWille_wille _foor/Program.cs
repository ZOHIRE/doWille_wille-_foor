using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWille_wille__foor
{
    class Program
    {

        static void Main(string[] args)
        {
            int mySalary1 = 1000, percentag1 = 20;
            int i1 = 0;
            do
            {
                mySalary1 += percentag1;
                i1++;
            } while (mySalary1 < 2000);
            Console.WriteLine("\t\t i1 = {0} \t\t mySalary1 = {1}\n", i1, mySalary1);



            //meme exemple la reponse de nazar

            int salary = 1000, increment = 20, salarydesired = 2000;
            int i = 0;
            do
            {
                salary += increment;
                i++;
            } while (salary < salarydesired);
            Console.WriteLine("\t\t i = {0} \t\t salary = {1}", i, salary);
            float years = i / 12;
            Console.WriteLine("\t\t years = {0}\n", years);






            int mySalary2 = 1000, percentag2 = 20;


            int i2 = 0;
            while (mySalary2 < 2000)
            {
                mySalary2 += percentag2;
                i2++;

            }

            Console.WriteLine("\t\t i2 = {0}, \t\t mySalary2 = {1}\n\n", i2, mySalary2);

            int mySalary3 = 1000, percentag3 = 20;
            for (int i3 = 0; (mySalary3 < 2000); i3++)
            {
                mySalary3 += percentag3;
                Console.WriteLine("\t\t\t i3 = {0} mySalary3 = {1}", i3, mySalary3);
            }




            int mySalary4 = 1500, total4 = 0;

            for (int i4 = 1; i4 <= 10; i4++)
            {
                total4 += mySalary4;Console.WriteLine("\n\n i4 = {0} total = {1}", i4, total4 );
            }
            
                
            

            
















            Console.ReadKey();









        }
    }
}
