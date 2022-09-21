using System;
using System.Runtime.InteropServices;
namespace ThirdDimension.Engine.Core{
	public static class Interoperability{
		[DllImport("kernel32.dll",SetLastError = true)]
		public static extern IntPtr GetStdHandle(int nStdHandle);
		public enum dwDesiredAccess : long{
			GENERIC_READ = 0x80000000L,
			GENERIC_WRITE = 0x40000000L,
			//created for convenience
			GENERIC_READWRITE = GENERIC_READ | GENERIC_WRITE
		}
		public static readonly long CONSOLE_TEXTMODE_BUFFER = 0x00000001L;
		[DllImport("kernel32.dll",SetLastError = true)]
		public static extern IntPtr CreateConsoleScreenBuffer(
			uint dwDesiredAccess,
			uint dwShareMode, 
			IntPtr lpSecurityAttributes, 
			uint dwFlags,
			IntPtr lpScreenBufferData
		);
		[DllImport("kernel32.dll",SetLastError = true)]
	    public static extern bool SetConsoleActiveScreenBuffer(IntPtr hConsoleOutput);
		[DllImport("kernel32.dll",SetLastError = true)]
		public static extern bool SetConsoleScreenBufferSize(IntPtr hConsoleOutput,COORD dwSize);
		[DllImport("kernel32.dll",SetLastError = true)]
		public static extern bool WriteConsoleOutputCharacter(
			IntPtr hConsoleOutput,
			string lpCharacter,
			uint nLength,
			COORD dwWriteCoord,
			out uint lpNumberOfCharsWritten
		);
		public enum FamilyFont{
			FF_DONTCARE = 0x00,
			FF_ROMAN = 0x01,
			FF_SWISS = 0x02,
			FF_MODERN = 0x03,
			FF_SCRIPT = 0x04,
			FF_DECORATIVE = 0x05
		}
		public static readonly uint FW_NORMAL = 400;
		[StructLayout(LayoutKind.Sequential)]
		public struct COORD{
		    public short X;
		    public short Y;
	        public COORD(short X, short Y){
				this.X = X;
				this.Y = Y;
	        }
	    };
		[StructLayout(LayoutKind.Sequential,CharSet = CharSet.Unicode)]
		public struct CONSOLE_FONT_INFOEX{
			public ulong cbSize;
			public int nFont;
			public COORD dwFontSize;
			public uint FontFamily;
			public uint FontWeight;
			[MarshalAs(UnmanagedType.ByValTStr,SizeConst = 32)]
			public string FaceName;
		}
		[DllImport("kernel32.dll",CharSet = CharSet.Unicode,SetLastError = true)]
		public static extern bool GetCurrentConsoleFontEx(IntPtr hConsoleOutput,bool bMaximumWindow,ref CONSOLE_FONT_INFOEX lpConsoleCurrentFont);
		[DllImport("kernel32.dll",SetLastError = true)]
		public static extern Int32 SetCurrentConsoleFontEx(IntPtr ConsoleOutput,bool MaximumWindow,ref CONSOLE_FONT_INFOEX ConsoleCurrentFontEx);
		[DllImport("kernel32.dll",SetLastError = true)]
	    public static extern bool SetConsoleWindowInfo(IntPtr hConsoleOutput,bool bAbsolute,[In] ref SMALL_RECT lpConsoleWindow);
		public struct SMALL_RECT{
			public SMALL_RECT(short left,short top,short right,short bottom){
				this.Left = left;
				this.Top = top;
				this.Right = right;
				this.Bottom = bottom;
			}
			short Left;
			short Top;
			short Right;
			short Bottom;
		}
		[DllImport("kernel32.dll",SetLastError = true)]
		public static extern COORD GetLargestConsoleWindowSize([In] IntPtr hConsoleOutput);
	}
}
