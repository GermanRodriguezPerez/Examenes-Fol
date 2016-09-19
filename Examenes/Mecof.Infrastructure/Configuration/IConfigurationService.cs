using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecof.Infrastructure.Configuration
{
    public interface IConfigurationService
    {

        /// <summary>
        /// if the key is missing it'll return null
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
    	string GetValue(string key);
        
        /// <summary>
        /// if the key is missing will throw an exception
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
    	string GetValueOrThrow(string key);
        
        bool TryGetValue(string key, out string result);
        
//        /// <summary>
//        /// should throw an exception if the key does not exist
//        /// </summary>
//        /// <typeparam name="T"></typeparam>
//        /// <param name="key"></param>
//        /// <returns></returns>
        //T GetTypedValue<T>(string key);

//        / <summary>
//        / if the key exists returns true and sets result to the corresponding value
//        / otherwise it returns false
//        / </summary>
//        / <typeparam name="T"></typeparam>
//        / <param name="key"></param>
//        / <param name="result"></param>
//        / <returns></returns>
        //bool TryTypedGetValue<T>(string key, out T result);

        /// <summary>
        /// dumps the whole configuration into an Object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        //T Deserialize<T>();
    }
}
