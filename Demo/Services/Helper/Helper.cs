using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Services.Helper
{
    public class Helper : IHelper
    {
        public string ValidateInput(string input)
        {
            return input.Trim();
        }
    }
}
