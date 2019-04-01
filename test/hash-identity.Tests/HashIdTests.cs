using System;
using HashIdentity;
using Microsoft.AspNetCore.Identity;
using Xunit;

namespace hash_identity.Tests
{
    public class HashIdTests
    {
        [Fact]
        public void HasherCanRoundTripString()
        {
            var output = Hasher.Hash("password");

            var testHasher = new PasswordHasher<string>();
            var result = testHasher.VerifyHashedPassword("", output, "password");

            Assert.True(result == PasswordVerificationResult.SuccessRehashNeeded ||
                        result == PasswordVerificationResult.Success);
        }
    }
}
