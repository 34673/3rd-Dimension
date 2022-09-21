using ThirdDimension.Engine.Core;
namespace ThirdDimension.Engine.Renderer{
	public static class Main{
		public static bool Initialize(){
			var logScope = 0;
			var fontSize = new Interoperability.COORD(8,8);
			Log.Information("Engine.Renderer.Main.Initialize():");
			logScope++;
			Properties.width.value = 256;
			Properties.height.value = 240;
			Properties.renderBuffer = new char[Properties.width.value * Properties.height.value];
			Properties.consoleFontData = RenderBuffer.GetCurrentFontData();
			Properties.consoleBufferHandle = RenderBuffer.Get(-11);
			Properties.currentBufferHandle = Properties.consoleBufferHandle;
			Properties.currentFontData = Properties.consoleFontData;
			Properties.renderBufferHandle = RenderBuffer.Create(new Vector2Int(Properties.width.value,Properties.height.value));
			Properties.renderFontData = RenderBuffer.SetCurrentFontData(fontSize);
			Log.Validation("Completed. Switching render buffer.",logScope);
			System.Console.ReadKey();
			Properties.currentBufferHandle = RenderBuffer.Set(Properties.renderBufferHandle);
			return true;
		}
		public static void Update(){
			foreach(var mesh in Properties.currentCamera.objectBuffer){
				Camera.ProjectToWorld(mesh);
				Camera.RasterizeMeshToWireframe(mesh);
			}
			Main.Display(Properties.renderBuffer.ToString());
		}
		public static void Display(string pixelBuffer){
			//unused but required by WriteConsoleOutputCharacter
			var lpNumberOfCharWritten = 0u;
			Core.Interoperability.WriteConsoleOutputCharacter(
				Properties.renderBufferHandle,
				pixelBuffer,
				(uint)(Properties.width.value * Properties.height.value),
				new Interoperability.COORD(),
				out lpNumberOfCharWritten
			);
		}
	}
}
