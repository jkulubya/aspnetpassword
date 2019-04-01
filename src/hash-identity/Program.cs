using System;
using System.Reflection;
using Microsoft.AspNetCore.Identity;

namespace HashIdentity
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                var versionString = Assembly.GetEntryAssembly()
                    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                    .InformationalVersion;
                Console.WriteLine();
                Console.WriteLine($"hash-identity v{versionString}");
                Console.WriteLine("--------------");
                Console.WriteLine("Usage:");
                Console.WriteLine();
                Console.WriteLine("$ hash-identity <text to hash as ASP.NET Identity Password>");
                return 1;
            }

            if(args.Length > 1)
            {
                var versionString = Assembly.GetEntryAssembly()
                    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                    .InformationalVersion;
                Console.WriteLine();
                Console.WriteLine("Error: Too many arguments supplied.");
                Console.WriteLine();
                Console.WriteLine($"hash-identity v{versionString}");
                Console.WriteLine("--------------");
                Console.WriteLine("Usage:");
                Console.WriteLine("");
                Console.WriteLine("$ hash-identity <text to hash as ASP.NET Identity Password>");
                return 1;
            }

            var input = args[0];
            var output = Hasher.Hash(input);

            Console.WriteLine(output);
            return 0;
        }
    }
}
