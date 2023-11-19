using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CLR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var perm = new PermissionSet(PermissionState.None);
            perm.AddPermission(
                new SecurityPermission(SecurityPermissionFlag.Execution)
                );
            perm.AddPermission(
                new FileIOPermission(FileIOPermissionAccess.NoAccess, @"c:\")
                );

            var setup = new AppDomainSetup();
            setup.ApplicationBase = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;


            // Create a Secured App domain
            AppDomain securedAppDomain =
                AppDomain.CreateDomain("SecuredAppDomain", 
                null, 
                setup, 
                perm);

            // Retrieve the type of the thirdparty
            Type thirdParty = typeof(ThirdParty);

            // Create an instance of ThirdParty 
            securedAppDomain.CreateInstanceAndUnwrap(
                thirdParty.Assembly.FullName, thirdParty.FullName);

            AppDomain.Unload(securedAppDomain);

            Class1 obj1 = new Class1();
            Class2 obj2 = new Class2();

            Console.Read();
        }
    }

    [Serializable]
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
