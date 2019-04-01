using Microsoft.AspNetCore.Identity;

namespace HashIdentity
{
    public static class Hasher
    {
        public static string Hash(string input)
        {
            var hasher = new PasswordHasher<string>();

            return hasher.HashPassword("", input);
        }
    }
}