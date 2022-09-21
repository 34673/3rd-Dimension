namespace ThirdDimension.Engine{
	public struct Vector4{
		public float x;
		public float y;
		public float z;
		public float w;
		public Vector4(float x=0f,float y=0f,float z=0f,float w=0f){
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}
		public static Vector4 operator +(Vector4 vectorA,Vector4 vectorB){
			Vector4 result;
			result.x = vectorA.x + vectorB.x;
			result.y = vectorA.y + vectorB.y;
			result.z = vectorA.z + vectorB.z;
			result.w = vectorA.w + vectorB.w;
			return result;
		}
		public static Vector4 operator -(Vector4 vectorA,Vector4 vectorB){
			Vector4 result;
			result.x = vectorA.x - vectorB.x;
			result.y = vectorA.y - vectorB.y;
			result.z = vectorA.z - vectorB.z;
			result.w = vectorA.w - vectorB.w;
			return result;
		}
		public static Vector4 operator *(Vector4 vector,float scale){
			vector.x *= scale;
			vector.y *= scale;
			vector.z *= scale;
			vector.w *= scale;
			return vector;
		}
		public static Vector4 operator *(Vector4 vectorA,Vector4 vectorB){
			Vector4 result;
			result.x = vectorA.x * vectorB.x;
			result.y = vectorA.y * vectorB.y;
			result.z = vectorA.z * vectorB.z;
			result.w = vectorA.w * vectorB.w;
			return result;
		}
		public static Vector4 operator /(Vector4 vectorA,Vector4 vectorB){
			Vector4 result;
			result.x = vectorA.x / vectorB.x;
			result.y = vectorA.y / vectorB.y;
			result.z = vectorA.z / vectorB.z;
			result.w = vectorA.w / vectorB.w;
			return result;
		}
		public static Vector4 operator %(Vector4 vectorA,Vector4 vectorB){
			Vector4 result;
			result.x = vectorA.x % vectorB.x;
			result.y = vectorA.y % vectorB.y;
			result.z = vectorA.z % vectorB.z;
			result.w = vectorA.w % vectorB.w;
			return result;
		}
	}
}
