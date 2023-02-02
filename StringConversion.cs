using System;
using System.Linq;
using System.Collections.Generic;

namespace Olymp
{
	public static class Itmo
	{
		public static void Main()
		{
			string s1 = Console.ReadLine(); //cantlieinfrontofthebulldozer
			string s2 = string.Empty;
			string s3 = string.Empty;
			
			int a = 0;
			int b = 0;
			
			while (a < s1.Length)
			{
				s2 += s1[a];
				if (a > 0)
				{
					int c = a;
					a += b;
					b = c;
				}
				else
					a++;
			}
			
			int[] arr = Enumerable.Repeat(0, 26).ToArray();
			for (int i = 0; i < s2.Length; i++)
			{
				int d = Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char)c).TakeWhile(x => x != s2[i]).Count();
				d = (d + i) % 26;
				arr[d] += 1;
			}
			
			int j = 0;
			while (j < 26)
			{
				if (arr[j] > 0)
				{
					s3 += Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char)c).ElementAt(j);
					arr[j] -= 1;
				}
				else
					j++;
			}
			
			Console.WriteLine(s3); //ccnqttx
		}
	}
}