using System;

namespace Indexer
{
    class StringDataStore
    {
        private string[] strArr = new string[10]; // internal data storage

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= strArr.Length)
                    throw new IndexOutOfRangeException("Index out of range bhudhi");

                return strArr[index];
            }

            set
            {
                if (index < 0 || index >= strArr.Length)
                    throw new IndexOutOfRangeException("Index out of range bhudhi!");

                strArr[index] = value;
            }
        }

        //overriding indexer
        public string this[string name]
        {
            get
            {
                foreach (string str in strArr)
                {
                    if (str.ToLower() ==  name.ToLower())
                        return str;
                  }

                return null;
            }
        }

        static void Main(string[] args)
        {
            StringDataStore strStore = new StringDataStore();

            strStore[0] = "One";
            strStore[1] = "Two";
            strStore[2] = "Three";
            strStore[3] = "Four";

            for (int i = 0; i < 10; i++)
                Console.WriteLine(strStore[i]);

            Console.WriteLine(strStore["one"]);
            Console.WriteLine(strStore["tWo"]);
            Console.WriteLine(strStore["Three"]);
            Console.WriteLine(strStore["FOUR"]);

            Console.WriteLine(strStore[0]);
            String name = "eddie";
            Console.WriteLine(name.Equals(String.Empty));
            Console.WriteLine(name.EndsWith("ie"));
            Console.WriteLine(name.Contains('d')); 
        }
    }
}
