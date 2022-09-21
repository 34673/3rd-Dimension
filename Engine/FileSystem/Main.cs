using System.IO;
using ThirdDimension.Engine.Core;
namespace ThirdDimension.Engine.FileSystem{
	public static class Main{
		public static bool Initialize(){
			var defaultDataPath = Properties.defaultDataPath;
			var configurationFilePath = defaultDataPath + "/Configuration.cfg";
			var logScope = 0;
			string lastDataPath = null;
			Log.Information("Engine.FileSystem.Main.Initialize():");
			logScope++;
			if(!Directory.Exists(defaultDataPath)){
				Log.Error("Missing default data directory '{0}'.",logScope,defaultDataPath);
				return false;
			}
			else if(!File.Exists(configurationFilePath)){
				//TODO: warn, create file and set to hardcoded default settings
			}
			//TODO: load this from default config file
			Properties.lastDataPath = Properties.executablePath + "Kappa";
			lastDataPath = Properties.lastDataPath;
			if(!Directory.Exists(lastDataPath)){
				Log.Warning("Missing last data directory: '{0}' -- current is now default.",logScope,lastDataPath);
				Properties.currentDataPath = defaultDataPath;
			}
			else{
				Log.Validation("Current data directory set to previously used: '{0}'.",logScope,lastDataPath);
				Properties.currentDataPath = lastDataPath;
			}
			configurationFilePath = Properties.currentDataPath + "\\Configuration.cfg";
			if(!File.Exists(configurationFilePath)){
				Log.Warning("Missing configuration file -- keeping default data directory settings.",logScope);
			}
			else{
				Log.Validation("Opening '{0}' for parse:",logScope,Properties.currentDataPath+"\\Configuration.cfg");
				logScope++;
				//Call parser
			}
			logScope--;
			Log.Validation("Completed.",logScope);
			return true;
		}
	}
}
