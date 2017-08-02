using System;

namespace aspnetpassword
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter a text value to hash.");
                return 1;
            }

            if(args.Length > 1)
            {
                Console.WriteLine("Too many arguments supplied.");
                return 1;
            }

            var input = args[0];
            var hasher = new PasswordHasher();

            var output = hasher.HashPassword(input);

            Console.WriteLine($"Hash - {output}");
            return 0;
        }
    }
}
