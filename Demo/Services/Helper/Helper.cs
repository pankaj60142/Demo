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
            if(!string.IsNullOrEmpty(input))
            {
                return input.Trim();
            }
            return string.Empty;
        }
    }
}
