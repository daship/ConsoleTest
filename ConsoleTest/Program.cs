using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string ace = "acelee";
            string aceRevise = ace + "1";

            Prodcut p = new Prodcut();
            

            AnimalEnum dog = AnimalEnum.dog;

            AnimalEnum cat = AnimalEnum.cat;

            AnimalEnum dogequal = dog;

            Console.WriteLine(dog.GetHashCode());
            Console.WriteLine(cat.GetHashCode());

            Console.WriteLine(ace.GetHashCode());
            Console.WriteLine(aceRevise.GetHashCode());


            Prodcut a = new Prodcut { name = "casino" };
            Prodcut b = a;
            Console.WriteLine(a.GetHashCode() == b.GetHashCode());
            b = new Prodcut { name = "casino" };
            Console.WriteLine(a.GetHashCode() == b.GetHashCode());

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Console.Read();
            return;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://www.p2p101.com/forum-356-1.html");
            req.Method = "GET";

            using (WebResponse wr = req.GetResponse())

            {

                using (StreamReader myStreamReader = new StreamReader(wr.GetResponseStream(), Encoding.UTF8  ))
                {

                    string data = myStreamReader.ReadToEnd();
                    string [] separators = new string[] { System.Environment.NewLine };
                    var lines = data.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    var test = lines
                        .Where(m => m.Contains("<a") && m.Contains("mod=viewthread"));

                    Console.WriteLine("data:" + lines.Count());

                }

            }
        }

        static void serializedToString()
        {
            test obj = new test { name = "daship", age = 33 };
            string xml = obj.SerializeToString();
            Console.WriteLine(xml);
        }

        
    }
}
