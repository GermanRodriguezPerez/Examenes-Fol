/*
 * Created by SharpDevelop.
 * User: XoseLluis
 * Date: 18/07/2015
 * Time: 20:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace Mecof.Infrastructure.Internationalization
{
	/// <summary>
	/// Description of LanguageHelper.
	/// </summary>
	public static class LanguageHelper
	{
		public static DicBasedLanguageService CreateDicBasedLanguageServiceFromJsonFile(string path)
		{
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                //Important: we need the encoding parameter (iso-8859-1 seems to be de default for windows text files)
                //so that then the JavaScriptSerializer deserializes it correctly (it seems to expect UTF-8)
                using (StreamReader reader = new StreamReader(fs, Encoding.GetEncoding("iso-8859-1")))
                {
                    string content = reader.ReadToEnd();
                    
                    Dictionary<string, string> dic = serializer.Deserialize<Dictionary<string, string>>(content);
                    return new DicBasedLanguageService(dic);
                }
            }
		}
	}
}
