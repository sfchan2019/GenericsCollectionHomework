using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenericsCollectionHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application();
            app.Run();
        }
    }

    class Application
    {
        public void Run()
        {
            CollectionLab lab = new CollectionLab();
            Console.WriteLine("Lab1: ");
            lab.InitializeCubicArray();
            lab.PrintCubicArray(0, 0, 0);
            lab.PrintCubicArray(9, 9, 9);
            lab.PrintCubicArray(2, 3, 7);
            Console.WriteLine();

            Console.WriteLine("Lab2: ");
            lab.InitializeList();
            Console.WriteLine(lab.SumOfList());
            Console.WriteLine();

            Console.WriteLine("Lab3: ");
            lab.InitializeDictionary();
            lab.PrintCountryDictionary();
            Console.WriteLine();

            Console.WriteLine("Lab4: ");
            lab.InitializeQueue();
            Console.WriteLine(lab.SumOfQueue());
            Console.WriteLine();

            Console.WriteLine("Lab5: ");
            lab.InitializeStack();
            Console.WriteLine(lab.SumOfStack());
            Console.WriteLine();
        }
    }

    class CollectionLab
    {
        private int[,,] cubicArray;
        private List<int> list01;
        private Dictionary<string, string> countryDictionary;
        private Queue<int> queue01;
        private Stack<int> stack01;

        public void InitializeCubicArray()
        {
            cubicArray = new int[10, 10, 10];
            for (int i = 0; i < cubicArray.GetLength(0); i++)
            {
                for (int j = 0; j < cubicArray.GetLength(1); j++)
                {
                    for (int k = 0; k < cubicArray.GetLength(2); k++)
                    {
                        cubicArray[i, j, k] = (i + 1) * (j + 1) * (k + 1);
                    }
                }
            }
        }

        public void PrintCubicArray(int i, int j, int k)
        {
            Console.WriteLine(cubicArray[i, j, k]);
        }

        public void InitializeList()
        {
            list01 = new List<int>();
            foreach (int i in cubicArray)
            {
                list01.Add(i);
            }
        }

        public int SumOfList()
        {
            int sum = 0;
            foreach (int i in list01)
            {
                sum += i;
            }
            return sum;
        }

        public void InitializeDictionary()
        {
            //country and city list https://www.countries-ofthe-world.com/capitals-of-the-world.html
            countryDictionary = new Dictionary<string, string>();
            countryDictionary.Add("Australia", "Canberra");
            countryDictionary.Add("Belgium", "Brussels");
            countryDictionary.Add("China", "Beijing");
            countryDictionary.Add("Denmark", "Copenhagen");
            countryDictionary.Add("France", "Paris");
            countryDictionary.Add("Greece", "Athens");
            countryDictionary.Add("Italy", "Rome");
            countryDictionary.Add("Japan", "Tokyo");
            countryDictionary.Add("Spain", "Madrid");
            countryDictionary.Add("United Kingdom", "London");
        }

        public void PrintCountryDictionary()
        {
            foreach (KeyValuePair<string, string> pair in countryDictionary)
            {
                Console.WriteLine(String.Format("The capital city of {0} is {1}", pair.Key, pair.Value));
            }
        }

        public void InitializeQueue()
        {
            queue01 = new Queue<int>();
            int count = 0;
            foreach (int i in cubicArray)
            {
                if (count == 100)
                    break;
                queue01.Enqueue(i);
                count++;
            }
            for (int i = 0; i < 10; i++)
            {
                queue01.Dequeue();
            }
        }
        public int SumOfQueue()
        {
            int sum = 0;
            foreach (int i in queue01)
            {
                sum += i;
            }
            return sum;
        }

        public void InitializeStack()
        {
            stack01 = new Stack<int>();
            int count = 0;
            foreach (int i in cubicArray)
            {
                if (count == 100)
                    break;
                stack01.Push(i);
            }
        }

        public int SumOfStack()
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += stack01.Peek();
                stack01.Pop();
            }
            return sum;
        }
    }
}
