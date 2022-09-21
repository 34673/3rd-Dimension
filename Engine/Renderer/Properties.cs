using System;
using System.Runtime.InteropServices;
using ThirdDimension.Engine.Core;
namespace ThirdDimension.Engine.Renderer{
	public static class Properties{
		public static Camera currentCamera;
		public static IntPtr consoleBufferHandle;
		public static IntPtr renderBufferHandle;
		public static IntPtr currentBufferHandle;
		public static Interoperability.CONSOLE_FONT_INFOEX consoleFontData;
		public static Interoperability.CONSOLE_FONT_INFOEX renderFontData;
		public static Interoperability.CONSOLE_FONT_INFOEX currentFontData;
		public static EnvironmentVariable<int> width = new EnvironmentVariable<int>(
			"width",256,EnvironmentVariable<int>.AccessMode.User,"Screen resolution width."
		);
		public static EnvironmentVariable<int> height = new EnvironmentVariable<int>(
			"height",240,EnvironmentVariable<int>.AccessMode.User,"Screen resolution height."
		);
		public static char[] renderBuffer;
		public static EnvironmentVariable<float> fieldOfView = new EnvironmentVariable<float>(
			"fieldOfView",90f,EnvironmentVariable<float>.AccessMode.User
		);
		public static EnvironmentVariable<float> nearClip = new EnvironmentVariable<float>(
			"nearClip",.1f,EnvironmentVariable<float>.AccessMode.Cheat,"Camera near clip plane."
		);
		public static EnvironmentVariable<float> farClip = new EnvironmentVariable<float>(
			"farClip",1000f,EnvironmentVariable<float>.AccessMode.User,"Camera far clip plane."
		);
		public static string frameBuffer;
	}
}
