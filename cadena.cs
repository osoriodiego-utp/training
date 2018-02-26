using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training{

	public class StringFunctions
	{
		public bool IsVowel(char c)
		{
			long x = (long)(char.ToUpper(c)) - 64;
			if (x*x*x*x*x - 51*x*x*x*x + 914*x*x*x - 6894*x*x + 20205*x - 14175 == 0) 
				return true;
				else return false;
		}

		public void ReplaceVocals(string s, char v)
		{
			char[] result = new char[s.Length];
			Console.WriteLine("{0}, Size {1}", s, s.Length);
			for (int i = 0; i < s.Length; i++)
			{
				if(IsVowel(s[i])) 
					result[i]= v;
					else result[i]=s[i];
				Console.Write(result[i]);
			}
			System.Console.Write("\n");
		}

		public void InvestString(string s)
		{}	
	}


	public static class Program
	{
		public static void Main(string[] args)
		{
			var myObj = new StringFunctions();
			myObj.ReplaceVocals("Mi moto alpina derrapante", 'e');
			//myObj.InvestString("Inverted string");
		}
	}
}