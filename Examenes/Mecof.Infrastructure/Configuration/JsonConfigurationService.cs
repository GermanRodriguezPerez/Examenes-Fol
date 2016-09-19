using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Newtonsoft.Json.Linq;

namespace Mecof.Infrastructure.Configuration
{
    public class JsonConfigurationService: IConfigurationService
    {
        public string FilePath { get; set; }
        public JObject Json { get; set; }

        public JsonConfigurationService(){}

        public JsonConfigurationService(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new ConfigurationException(
                    "Error Creating the JsonConfigurationManager. Can´t find file " + filePath);
            }

            string jsonString;
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    jsonString = sr.ReadToEnd();
                }
                this.Json = JObject.Parse(jsonString);
                this.FilePath = filePath; 
            }
            catch (Exception ex)
            {
                throw new ConfigurationException("Error Creating the JsonConfigurationManager. " 
                    + filePath + " could not be parsed correctly " + ex.Message, ex);
            }
        }

        public static JsonConfigurationService FromJsonString(string jsonString)
        {
            var jsonConfig = new JsonConfigurationService();
            try
            {
                jsonConfig.Json = JObject.Parse(jsonString);
            }
            catch (Exception ex)
            {
                throw new ConfigurationException("json string could not be parsed", ex);
            }
            return jsonConfig;
        }
		
        public string GetValue(string key)
        {
        	try
        	{
        		return this.GetTypedValueOrThrow<string>(key);
        	}
        	catch (Exceptin ex)
        	{
        		return null;
        	}
        }
        
        public string GetValueOrThrow(string key)
        {
        	return this.GetTypedValueOrThrow<string>(key);
        }
        
        public bool TryGetValue(string key, out string value)
        {
        	return this.TryGetValue<string>(key, value);
        }

        public T GetTypedValueOrThrow<T>(string key)
        {
            if (key == null || key.Trim() == String.Empty)
                throw new Exception("key can't be null - empty");

            //return this.Json.Value<T>(key);

            string[] properties = key.Split(new char[] { '.' });
            int i = 0;
            JToken curToken = this.Json;
            try
            {
                while (i < properties.Length)
                {
                    //while moving along the property chain the cast to JObject must be correct, unless it's already a Value, in that case throwing an exception is fine
                    curToken = ((JObject)curToken).GetValue(properties[i]);
                    i++;
                }
            }
            catch (Exception)
            {
                throw new ConfigurationException("Error accessing" + ": " + properties[i]);
            }
            //return curToken.Value<T>();
            if (curToken == null)
            {
                throw new ConfigurationException("Error accessing");
            }
            return curToken.ToObject<T>();
        }

        /// <summary>
        /// for those cases were a missing configuration value is not a problem cause we'll set it then to some
        /// default, we should invoke this method rather than the above
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool TryGetTypedValue<T>(string key, out T value)
        {
            try
            {
                value = this.GetValue<T>(key);
            }
            catch (Exception ex)
            {
                value = default(T);
                return false;
            }
            return true;
        }

        public T Deserialize<T>()
        {
            return this.Json.ToObject<T>();
        }

        public override string ToString()
        {
            return this.Json.ToString();
        }       
    }
}
