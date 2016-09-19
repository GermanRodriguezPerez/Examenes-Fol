/*
 * Created by SharpDevelop.
 * User: XoseLluis
 * Date: 18/07/2015
 * Time: 20:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Mecof.Infrastructure.Internationalization
{
	/// <summary>
	/// Description of ILanguageService.
	/// </summary>
	public interface ILanguageService
	{
		string Translate(string text);
	}
}
