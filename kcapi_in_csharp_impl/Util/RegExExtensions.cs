using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace kcapi_in_csharp_impl.Util {

	static class RegexExtensions {

		static Dictionary<string, Regex> regexDict;

		static Regex get( string key ) {

			if ( regexDict == null ) {
				regexDict = new Dictionary<string, Regex>();
			}

			if ( regexDict.ContainsKey( key ) ) {
				return regexDict[key];
			}

			var regex = new Regex( key, RegexOptions.Compiled );
			regexDict.Add( key, regex );

			return regex;
		}

		public static string s( this string pattern, string str ) {
			return get( pattern ).Match( str ).Value;
		}

		public static int i( this string pattern, int value ) {
			return int.Parse( get( pattern ).Match( value.ToString() ).Value );
		}

		public static string substr(this string str, int start, int length ) {
			return str.Substring( ( start < 0 ? start + str.Length : start ), length );
		}

	}

}
