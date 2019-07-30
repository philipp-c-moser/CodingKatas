using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigToDictionary
{
    public class ConfigToDictionary
    {



        private IEnumerable<string> SplitSettings(string configuration)
        {
            var settings = configuration.Split(";", StringSplitOptions.RemoveEmptyEntries);

            
            return settings;
        }

    }
}
