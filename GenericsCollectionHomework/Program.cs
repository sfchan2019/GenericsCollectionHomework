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
            lab.InitializeCubicArray();
            lab.PrintCubicArray(1, 1, 1);
            lab.PrintCubicArray(10, 10, 10);
            lab.PrintCubicArray(2, 3, 7);

            lab.InitializeList();
            Console.WriteLine(lab.SumOfList());

            lab.InitializeDictionary();
            lab.PrintCountryDictionary();

            lab.InitializeQueue();
            Console.WriteLine(lab.SumOfQueue());

            lab.InitializeStack();

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
            cubicArray = new int[11, 11, 11];
            for (int i = 1; i < cubicArray.GetLength(0); i++)
            {
                for (int j = 1; j < cubicArray.GetLength(1); j++)
                {
                    for (int k = 1; k < cubicArray.GetLength(2); k++)
                    {
                        cubicArray[i, j, k] = i * j * k;
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
            foreach (int i in cubicArray)
            {
                queue01.Enqueue(i);
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
            for (int i = 0; i < 100; i++)
            {
                stack01.Push(i);
            }

            for (int i = 0; i < 10; i++)
            {
                stack01.Pop();
            }
        }
    }
}
