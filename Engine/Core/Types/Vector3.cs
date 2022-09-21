namespace ThirdDimension.Engine{
	public struct Vector3{
		public float x;
		public float y;
		public float z;
		public Vector3(float x=0f,float y=0f,float z=0f){
			this.x = x;
			this.y = y;
			this.z = z;
		}
		public static Vector3 operator +(Vector3 vectorA,Vector3 vectorB){
			Vector3 result;
			result.x = vectorA.x + vectorB.x;
			result.y = vectorA.y + vectorB.y;
			result.z = vectorA.z + vectorB.z;
			return result;
		}
		public static Vector3 operator -(Vector3 vectorA,Vector3 vectorB){
			Vector3 result;
			result.x = vectorA.x - vectorB.x;
			result.y = vectorA.y - vectorB.y;
			result.z = vectorA.z - vectorB.z;
			return result;
		}
		public static Vector3 operator *(Vector3 vector,float scale){
			vector.x *= scale;
			vector.y *= scale;
			vector.z *= scale;
			return vector;
		}
		public static Vector3 operator *(Vector3 vectorA,Vector3 vectorB){
			Vector3 result;
			result.x = vectorA.x * vectorB.x;
			result.y = vectorA.y * vectorB.y;
			result.z = vectorA.z * vectorB.z;
			return result;
		}
		public static Vector3 operator /(Vector3 vectorA,Vector3 vectorB){
			Vector3 result;
			result.x = vectorA.x / vectorB.x;
			result.y = vectorA.y / vectorB.y;
			result.z = vectorA.z / vectorB.z;
			return result;
		}
		public static Vector3 operator %(Vector3 vectorA,Vector3 vectorB){
			Vector3 result;
			result.x = vectorA.x % vectorB.x;
			result.y = vectorA.y % vectorB.y;
			result.z = vectorA.z % vectorB.z;
			return result;
		}
	}
}
