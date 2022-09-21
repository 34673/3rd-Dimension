using System;
using System.Runtime.InteropServices;
using ThirdDimension.Engine.Core;
namespace ThirdDimension.Engine.Renderer{
	public static class RenderBuffer{
		public static IntPtr Create(Vector2Int size){
			var handle = Interoperability.CreateConsoleScreenBuffer(
				(uint)Core.Interoperability.dwDesiredAccess.GENERIC_READWRITE,
				0,IntPtr.Zero,
				(uint)Core.Interoperability.CONSOLE_TEXTMODE_BUFFER,
				IntPtr.Zero
			);
			var screenRect = new Interoperability.SMALL_RECT(0,0,(short)(Properties.width.value-1),(short)(Properties.height.value-1));
			//if(!Interoperability.SetConsoleWindowInfo(handle,true,ref screenRect)){
			//	Log.Error("Fucking Window Size");
			//}
			Interoperability.SetConsoleScreenBufferSize(handle,new Interoperability.COORD((short)size.x,(short)size.y));
			return handle;
		}
		public static IntPtr Get(int bufferIndex){
			return Interoperability.GetStdHandle(bufferIndex);
		}
		public static IntPtr Set(IntPtr handle){
			Core.Interoperability.SetConsoleActiveScreenBuffer(handle);
			return handle;
		}
		public static Interoperability.CONSOLE_FONT_INFOEX GetCurrentFontData(){
			Interoperability.CONSOLE_FONT_INFOEX fontData = new Interoperability.CONSOLE_FONT_INFOEX();
			Core.Interoperability.GetCurrentConsoleFontEx(Properties.currentBufferHandle,false,ref fontData);
			return fontData;
		}
		public static Interoperability.CONSOLE_FONT_INFOEX SetCurrentFontData(Interoperability.COORD size,string name = "Consolas"){
			Interoperability.CONSOLE_FONT_INFOEX fontData = new Interoperability.CONSOLE_FONT_INFOEX();
			fontData.cbSize = (uint)Marshal.SizeOf(fontData);
			fontData.FaceName = name;
			fontData.dwFontSize.X = size.X;
			fontData.dwFontSize.X = size.Y;
			//if(Core.Interoperability.SetCurrentConsoleFontEx(EnvironmentVariables.currentBufferHandle,false,ref fontData) == 0){
			//	Log.Error("SetCurrentFontData:",1);
			//}
			return fontData;
		}
	}
}
