using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;

namespace Mecof.Infrastructure.Internationalization
{
    /// <summary>
    /// class with a Dictionary of Language Dictionaries
    /// initially it was a singleton, now we're accessing to it from the container and we've registered it there so that it always return the same instance
    /// </summary>
    public class DicBasedLanguageService: ILanguageService 
    {
    	private Dictionary<string,string> dictionary;
    	
    	public DicBasedLanguageService(Dictionary<string,string> dictionary)
    	{
    		this.dictionary = dictionary;
    	}
    	
    	public string Translate(string text)
    	{
    		if (this.dictionary.ContainsKey(text))
    		{
    			return this.dictionary[text];
    		}
    		else
    		{
    			return text + " (MT)"; //MT = Missing Translation
    		}
    	}
    }
}
