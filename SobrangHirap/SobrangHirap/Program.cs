using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Employee
{
    internal class Program
    {


        static void Main(string[] args)


        {

            LoadData[] PersonInfo = new LoadData[1];
            int choose;

           
            do {

            //switch Menu
            Console.WriteLine("1 - ADD INFORMATION");
            Console.WriteLine("2 - DELETE INFORMATION");
            Console.WriteLine("3 - UPDATE INFORMATION");
            Console.WriteLine("4 - EXIT ");
            Console.Write("Choose : ");

            choose = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
                switch (choose)
                {
                    case 1:
                        {
                            LoadInformation(ref loadData);
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("B - DELETE INFORMATION");

                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("C - UPDATE INFORMATION");
                            break;
                        }

                    case 4:
                        {

                            Console.WriteLine("D - EXIT ");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine(choose + " Are not in the Choices");
                            Console.ReadLine();
                            break;
                        }
                        
                }
                Console.Clear();

            } while(choose != 4);
       
           
            



        }


        //loading Data Function
        public static void LoadInformation(ref LoadData[] loadData)
            {

                StreamReader readinformaton = new StreamReader("Information.txt");
                int size = Convert.ToInt32(readinformaton.ReadLine());
                loadData = new LoadData[size];

                for (int index = 0; index < loadData.Length; index++ )

                    {
                        loadData[index] = new LoadData();
                        loadData[index].FirstName = readinformaton.ReadLine();
                        loadData[index].MiddleName = readinformaton.ReadLine();
                        loadData[index].FirstName = readinformaton.ReadLine();
                    }

            }

    }
}

