using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfigToDictionary
{
    public class ConfigToDictionary
    {

        public string ToString(string configuration)
        {
            var sb = new StringBuilder();

            foreach (var setting in ToDictionary(configuration))
            {
                sb.Append($"Key: {setting.Key} | Value: {setting.Value}\n");
            }

            return sb.ToString();
        }

        public IDictionary<string, string> ToDictionary(string configuration)
        {
            return SplitIntoKeyValuePairs(SplitSettings(configuration));
        }


        private IEnumerable<string> SplitSettings(string configuration)
        {
            var settings = configuration.Split(";", StringSplitOptions.RemoveEmptyEntries);
            
            return settings;
        }

        private IDictionary<string, string> SplitIntoKeyValuePairs(IEnumerable<string> settings)
        {
            
            var keyValuePairs = new Dictionary<string, string>();

            foreach (var setting in settings)
            {
                var splittedSetting = setting.Split("=");
                keyValuePairs.Add(splittedSetting[0].ToString(), splittedSetting[1].ToString());
            }

            return keyValuePairs;
        }

    }
}
