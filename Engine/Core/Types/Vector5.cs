namespace ThirdDimension.Engine{
	public struct Vector5{
		public float x;
		public float y;
		public float z;
		public float w;
		public float h;
		public Vector5(float x=0f,float y=0f,float z=0f,float w=0f,float h=0f){
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
			this.h = h;
		}
		public static Vector5 operator +(Vector5 vectorA,Vector5 vectorB){
			Vector5 result;
			result.x = vectorA.x + vectorB.x;
			result.y = vectorA.y + vectorB.y;
			result.z = vectorA.z + vectorB.z;
			result.w = vectorA.w + vectorB.w;
			result.h = vectorA.h + vectorB.h;
			return result;
		}
		public static Vector5 operator -(Vector5 vectorA,Vector5 vectorB){
			Vector5 result;
			result.x = vectorA.x - vectorB.x;
			result.y = vectorA.y - vectorB.y;
			result.z = vectorA.z - vectorB.z;
			result.w = vectorA.w - vectorB.w;
			result.h = vectorA.h - vectorB.h;
			return result;
		}
		public static Vector5 operator *(Vector5 vector,float scale){
			vector.x *= scale;
			vector.y *= scale;
			vector.z *= scale;
			vector.w *= scale;
			vector.h *= scale;
			return vector;
		}
		public static Vector5 operator *(Vector5 vectorA,Vector5 vectorB){
			Vector5 result;
			result.x = vectorA.x * vectorB.x;
			result.y = vectorA.y * vectorB.y;
			result.z = vectorA.z * vectorB.z;
			result.w = vectorA.w * vectorB.w;
			result.h = vectorA.h * vectorB.h;
			return result;
		}
		public static Vector5 operator /(Vector5 vectorA,Vector5 vectorB){
			Vector5 result;
			result.x = vectorA.x / vectorB.x;
			result.y = vectorA.y / vectorB.y;
			result.z = vectorA.z / vectorB.z;
			result.w = vectorA.w / vectorB.w;
			result.h = vectorA.h / vectorB.h;
			return result;
		}
		public static Vector5 operator %(Vector5 vectorA,Vector5 vectorB){
			Vector5 result;
			result.x = vectorA.x % vectorB.x;
			result.y = vectorA.y % vectorB.y;
			result.z = vectorA.z % vectorB.z;
			result.w = vectorA.w % vectorB.w;
			result.h = vectorA.h % vectorB.h;
			return result;
		}
	}
}
