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

        private IDictionary<string, string> SplitIntoKeyValuePairs(IEnumerable<string> settings)
        {
            var keyValuePairs = new Dictionary<string, string>();


            return keyValuePairs;
        }

    }
}
