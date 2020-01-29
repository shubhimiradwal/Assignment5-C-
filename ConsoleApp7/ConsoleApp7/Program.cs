using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<int,string>();
            dictionary.Add(1998,"Atal Bihari Vajpayee");
            dictionary.Add( 2014,"Narendra Modi");
            dictionary.Add(2004,"Manmohan Singh");

                string value = dictionary[2004];
                Console.WriteLine(value);
                dictionary.Add(2020,"Narendra Modi");
                dictionary.OrderBy(x => x.Key);
                foreach (KeyValuePair<int, string> pair in dictionary)
                 {
                Console.WriteLine("Key:{0} and Value: {1}",
                                     pair.Key, pair.Value);
                }
        }
        }
        }
    

