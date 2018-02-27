using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training
{
	public class StringFunctions
	{
		public bool IsVowel(char ch)
		{
			long x = (long)(char.ToUpper(ch)) - 64;
			if (x*x*x*x*x - 51*x*x*x*x + 914*x*x*x - 6894*x*x + 20205*x - 14175 == 0) 
				return true;
				else return false;
		}

		public void ReplaceVocals(string phrase, char vowel)
		{
			char[] result = new char[phrase.Length];
			for (int i = 0; i < phrase.Length; i++)
				{
				if(IsVowel(phrase[i])) 
					{
						result[i]= vowel;
					}
					else
					{
						result[i]=phrase[i];
					}
				}
			Console.WriteLine("Original: {0}\n Changed: {1}\n ", phrase, new string(result));
		}

		public void ReplaceVocalsAppend(string phrase, char vowel)
		{
			System.Text.StringBuilder result = new System.Text.StringBuilder();
			foreach (var ch in phrase)
				if(IsVowel(ch))
					{
						result.Append(vowel);
					}
					else
					{
						result.Append(ch);
					}
			Console.WriteLine("Original: {0}\n Changed: {1}\n ", phrase, result);
		}

		public void ReplaceVocalReplace(string phrase, char vowel)
		{
			//System.Text.StringBuilder result = new System.Text.StringBuilder();
			var result= "";		//String result;
			result = phrase.Replace('a', vowel).Replace('e', vowel).Replace('i', vowel).Replace('o', vowel).Replace('u', vowel);
			Console.WriteLine("Original: {0}\n Changed: {1}\n ", phrase, result);
		}

		public void InvestString(string phrase)
		{
			Console.WriteLine("{0}, Size {1}", phrase, phrase.Length);
			for (int i = 0; i < phrase.Length; i++)
				{
					  Console.Write(phrase[phrase.Length - i - 1]);
				}
		}	
	}


	public static class MainClass
	{
		public static void Main(string[] args)
		{
			var myObj = new StringFunctions();
			myObj.ReplaceVocals("Mi moto alpina", 'a');
			myObj.ReplaceVocalsAppend("Mi moto alpina", 'e');
			myObj.ReplaceVocalReplace("Mi moto alpina", 'i');
		}
	}
}