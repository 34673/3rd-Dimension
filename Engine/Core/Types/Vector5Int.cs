namespace ThirdDimension.Engine{
	public struct Vector5Int{
		public int x;
		public int y;
		public int z;
		public int w;
		public int h;
		public Vector5Int(int x=0,int y=0,int z=0,int w=0,int h=0){
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
			this.h = h;
		}
		public static Vector5Int operator +(Vector5Int vectorA,Vector5Int vectorB){
			Vector5Int result;
			result.x = vectorA.x + vectorB.x;
			result.y = vectorA.y + vectorB.y;
			result.z = vectorA.z + vectorB.z;
			result.w = vectorA.w + vectorB.w;
			result.h = vectorA.h + vectorB.h;
			return result;
		}
		public static Vector5Int operator -(Vector5Int vectorA,Vector5Int vectorB){
			Vector5Int result;
			result.x = vectorA.x - vectorB.x;
			result.y = vectorA.y - vectorB.y;
			result.z = vectorA.z - vectorB.z;
			result.w = vectorA.w - vectorB.w;
			result.h = vectorA.h - vectorB.h;
			return result;
		}
		public static Vector5Int operator *(Vector5Int vector,int scale){
			vector.x *= scale;
			vector.y *= scale;
			vector.z *= scale;
			vector.w *= scale;
			vector.h *= scale;
			return vector;
		}
		public static Vector5Int operator *(Vector5Int vectorA,Vector5Int vectorB){
			Vector5Int result;
			result.x = vectorA.x * vectorB.x;
			result.y = vectorA.y * vectorB.y;
			result.z = vectorA.z * vectorB.z;
			result.w = vectorA.w * vectorB.w;
			result.h = vectorA.h * vectorB.h;
			return result;
		}
		public static Vector5Int operator /(Vector5Int vectorA,Vector5Int vectorB){
			Vector5Int result;
			result.x = vectorA.x / vectorB.x;
			result.y = vectorA.y / vectorB.y;
			result.z = vectorA.z / vectorB.z;
			result.w = vectorA.w / vectorB.w;
			result.h = vectorA.h / vectorB.h;
			return result;
		}
		public static Vector5Int operator %(Vector5Int vectorA,Vector5Int vectorB){
			Vector5Int result;
			result.x = vectorA.x % vectorB.x;
			result.y = vectorA.y % vectorB.y;
			result.z = vectorA.z % vectorB.z;
			result.w = vectorA.w % vectorB.w;
			result.h = vectorA.h % vectorB.h;
			return result;
		}
	}
}
