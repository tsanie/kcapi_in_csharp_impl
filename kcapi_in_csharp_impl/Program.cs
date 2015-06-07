using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using kcapi_in_csharp_impl.Util;

namespace kcapi_in_csharp_impl {
	static class Program {
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() {
			//Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault( false );
			//Application.Run( new Form1() );


			//Console.WriteLine( string.Join( ", ", connection.api_port.PortAPI.Il ) );
			//Console.WriteLine( "abcdefg".substr( -2, 2 ) );

			Console.Write( "enter your member id: " );
			int memberId = int.Parse( Console.ReadLine() );
			Console.Write( "output lines: " );
			int lines = int.Parse( Console.ReadLine() );

			var port = new connection.api_port.PortAPI();

			Console.WriteLine();
			for ( int i = 0; i < lines; i++ ) {
				Console.WriteLine( port.GetApiPort( memberId ) );
			}


			Console.Write( "done." );
			Console.ReadKey( true );

		}
	}
}
