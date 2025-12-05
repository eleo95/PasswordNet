using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordNet.Services
{
    internal class CharactersTypePicker : ICharactersTypePicker
    {

        private const string LowerCase = "abcdefghijklmnopqrstuvwxyz";
        private const string UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Numbers = "0123456789";
        private const string Symbols = "!@#$%^&*()-_=+[]{};:,.<>?";

        public string GetCharacters(bool useLower, bool useUpper, bool useNumbers, bool useSymbols)
        {
            var set = "";

            if (useLower) set += LowerCase;
            if (useUpper) set += UpperCase;
            if (useNumbers) set += Numbers;
            if (useSymbols) set += Symbols;

            return set;

        }
    }
}
