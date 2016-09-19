/*
 * Created by SharpDevelop.
 * User: XoseLluis
 * Date: 18/07/2015
 * Time: 20:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Configuration;

namespace Mecof.Infrastructure.Configuration
{
	/// <summary>
	/// Description of StandardDotNetConfigurationService.
	/// </summary>
	public class StandardDotNetConfigurationService: IConfigurationService
	{
		 public string GetValue(string key)
		 {
		 	return ConfigurationManager.AppSettings[key];
		 }
		 
		 public string GetValueOrThrow(string key)
		 {
		 	if (ConfigurationManager.AppSettings[key] != null)
		 	{
		 		return ConfigurationManager.AppSettings[key];
		 	}
		 	else
		 	{
		 		throw new Exception ("Mising Value");
		 	}
		 }
		 
		 public bool TryGetValue(string key, out string value)
		 {
		 	value = ConfigurationManager.AppSettings[key];
		 	return value != null;
		 }
//
//        /// <summary>
//        /// if the key exists returns true and sets result to the corresponding value
//        /// otherwise it returns false
//        /// </summary>
//        /// <typeparam name="T"></typeparam>
//        /// <param name="key"></param>
//        /// <param name="result"></param>
//        /// <returns></returns>
//        bool TryGetValue<T>(string key, out T result)
//        {
//
//        }


	}
}
