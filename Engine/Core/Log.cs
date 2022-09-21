using System;
using System.Runtime.InteropServices;
namespace ThirdDimension.Engine.Core{
	public static class Log{
		public static void Information(string format,int scope = 0,params object[] parameters){
			var lastColor = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Gray;
			Log.Message(format,scope,parameters);
			Console.ForegroundColor = lastColor;
		}
		public static void Validation(string format,int scope = 0,params object[] parameters){
			var lastColor = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Green;
			Log.Message(format,scope,parameters);
			Console.ForegroundColor = lastColor;
		}
		public static void Warning(string format,int scope = 0,params object[] parameters){
			var lastColor = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Log.Message(format,scope,parameters);
			Console.Beep(440,250);
			Console.Beep(440,250);
			Console.ForegroundColor = lastColor;
		}
		public static void Error(string format,int scope = 0,params object[] parameters){
			var lastColor = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Red;
			Log.Message(format,scope,parameters);
			Console.Beep(880,1000);
			Log.Message("Marshal.GetLastWin32Error(): " + Marshal.GetLastWin32Error().ToString(),scope,parameters);
			Console.ReadKey();
			Environment.Exit(1);
		}
		private static void Message(string format,int scope = 0,params object[] parameters){
			var tab = "";
			for(var i=0;i<scope;i++){tab += "\t";}
			Console.WriteLine(tab + format,parameters);
		}
	}
}
