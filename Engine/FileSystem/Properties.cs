using System;
namespace ThirdDimension.Engine.FileSystem{
	public static class Properties{
		public static string executablePath = AppDomain.CurrentDomain.BaseDirectory;
		private const string defaultDataDirectory = "Base";
		public static string defaultDataPath = executablePath + defaultDataDirectory;
		public static string lastDataPath = null;
		public static string currentDataPath = null;
	}
}
