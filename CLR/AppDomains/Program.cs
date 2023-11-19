using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomains
{
    class program
    {
        static void Main(string[] args)
        {
            // Secured App domain
            AppDomain securedAppDomain =
                AppDomain.CreateDomain("SecuredAppDomain");




            Class1 obj1 = new Class1();
            Class2 obj2 = new Class2();

            Console.Read();
        }
    }


    class ThirdParty
    {
        public ThirdParty()
        {
            Console.WriteLine("Third party loaded!");
            System.IO.File.Create(@"c:\x.txt");
        }
        ~ThirdParty()
        {
            Console.WriteLine("Third party unloaded!");
        }
    }

    class Class1
    {

    }

    class Class2
    {

    }
}
