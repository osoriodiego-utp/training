using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Files
{
	public class FilesFunctions
	{
		public void WriteFile(string FileName)
		{
			try 
				{
					StreamWriter file = new StreamWriter(FileName, true, Encoding.ASCII);	// Open/Create the File called "FileName"
					Console.WriteLine("Input text to save: ");
					file.Write("\n" + Console.ReadLine());		// Writing text read by keyboard
					file.Close();							// close the file
				}
			catch(Exception e)
				{ Console.WriteLine("Exception: " + e.Message); }
			finally 
				{ Console.WriteLine("[WriteFile] Updated and Saved file..."); }
		}

		public void ReadFile(string FileName)
		{
			String line;
			try 
				{
					StreamReader file = new StreamReader(FileName);	//Pass the file path and file name to the StreamReader constructor
					line = file.ReadLine();		//Read the first line of text
					while (line != null) 			// ||
					{								// || Continue reading until find end of file
						Console.WriteLine(line); 	// write currentline of file in console
						line = file.ReadLine();		// Read the next line
					}
					file.Close();
					Console.ReadLine();
				}
			catch(Exception e)
				{ Console.WriteLine("Exception: " + e.Message); }
			finally 
				{ Console.WriteLine("[ReadFile] File closed..."); }


		}
	}

	public static class MainClass
	{
		public static void Main(string[] args)
		{
			var clase= new FilesFunctions();
			clase.WriteFile("example.txt");
			clase.ReadFile("example.txt");

		}
	}
}