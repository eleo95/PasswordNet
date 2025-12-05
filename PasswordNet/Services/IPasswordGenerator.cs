using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordNet.Services
{
    internal interface IPasswordGenerator
    {
        string Generate(int length, string includedCharacters);
    }
}
