using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordNet.Services
{
    internal class PasswordGenerator : IPasswordGenerator
    {
        public string Generate(int length, string includedCharacters)
        {
            if (string.IsNullOrEmpty(includedCharacters))
                throw new ArgumentException("No character set selected.");

            var chars = includedCharacters.ToCharArray();
            var result = new char[length];

            using var random = RandomNumberGenerator.Create();

            for (int i = 0; i < length; i++)
            {
                byte[] randomNumber = new byte[4];
                random.GetBytes(randomNumber);

                int index = BitConverter.ToInt32(randomNumber, 0) & int.MaxValue;
                result[i] = chars[index % chars.Length];
            }

            return new string(result);
        }
    }
}
