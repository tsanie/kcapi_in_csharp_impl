using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kcapi_in_csharp_impl.Util {

	static class DateExtensions {

		private static readonly long origin = new DateTime( 1970, 1, 1, 0, 0, 0 ).Ticks;

		public static double getTime( this DateTime time ) {
			return ( time.ToUniversalTime().Ticks - origin ) / 10000;
		}

	}

}
