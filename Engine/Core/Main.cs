using System;
namespace ThirdDimension.Engine.Core{
	public static class Main{
		public static void Initialize(){
			if(!Engine.FileSystem.Main.Initialize()){Environment.Exit(-1);}
			if(!Engine.Renderer.Main.Initialize()){Environment.Exit(-1);}
			if(!Game.Main.Initialize()){Environment.Exit(-1);}
			while(true){Core.Main.Update();}
		}
		public static void Update(){
			Game.Main.Update();
			//Engine.Renderer.Main.Update();
		}
	}
}
