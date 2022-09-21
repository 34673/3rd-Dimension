namespace ThirdDimension.Engine{
	public struct Vector4Int{
		public int x;
		public int y;
		public int z;
		public int w;
		public Vector4Int(int x=0,int y=0,int z=0,int w=0){
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}
		public static Vector4Int operator +(Vector4Int vectorA,Vector4Int vectorB){
			Vector4Int result;
			result.x = vectorA.x + vectorB.x;
			result.y = vectorA.y + vectorB.y;
			result.z = vectorA.z + vectorB.z;
			result.w = vectorA.w + vectorB.w;
			return result;
		}
		public static Vector4Int operator -(Vector4Int vectorA,Vector4Int vectorB){
			Vector4Int result;
			result.x = vectorA.x - vectorB.x;
			result.y = vectorA.y - vectorB.y;
			result.z = vectorA.z - vectorB.z;
			result.w = vectorA.w - vectorB.w;
			return result;
		}
		public static Vector4Int operator *(Vector4Int vector,int scale){
			vector.x *= scale;
			vector.y *= scale;
			vector.z *= scale;
			vector.w *= scale;
			return vector;
		}
		public static Vector4Int operator *(Vector4Int vectorA,Vector4Int vectorB){
			Vector4Int result;
			result.x = vectorA.x * vectorB.x;
			result.y = vectorA.y * vectorB.y;
			result.z = vectorA.z * vectorB.z;
			result.w = vectorA.w * vectorB.w;
			return result;
		}
		public static Vector4Int operator /(Vector4Int vectorA,Vector4Int vectorB){
			Vector4Int result;
			result.x = vectorA.x / vectorB.x;
			result.y = vectorA.y / vectorB.y;
			result.z = vectorA.z / vectorB.z;
			result.w = vectorA.w / vectorB.w;
			return result;
		}
		public static Vector4Int operator %(Vector4Int vectorA,Vector4Int vectorB){
			Vector4Int result;
			result.x = vectorA.x % vectorB.x;
			result.y = vectorA.y % vectorB.y;
			result.z = vectorA.z % vectorB.z;
			result.w = vectorA.w % vectorB.w;
			return result;
		}
	}
}
