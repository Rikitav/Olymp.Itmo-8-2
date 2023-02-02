using System;
using System.Linq;
using System.Collections.Generic;

namespace Olymp
{
	public static class Itmo
	{
		public static void Main()
		{
			Console.Clear();
			Console.CursorVisible = false;
			IEnumerable<char> X = "ohamft";
			IEnumerable<char> Y = "monim";

			int K = 0;
			while (!X.IsM())
			{
				X = X.Reverse();
				X = X.Concat(Y);
				Y = Y.Reverse();
				K++;
			}
			Console.SetCursorPosition(0, 0);
			Console.WriteLine(K);
			Console.WriteLine(string.Join(string.Empty, X));
		}
	
		public static bool IsM(this IEnumerable<char> str)
		{
			try
			{
				return str.ElementAt(109) == 'm';
			}
			catch
			{
				return false;
			}
		}
	}
}