using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordNet.Services
{
    interface ICharactersTypePicker
    {
        string GetCharacters(bool useLower, bool useUpper, bool useNumbers, bool useSymbols);
    }
}
