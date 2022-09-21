namespace ThirdDimension.Engine{
	public struct Vector3Int{
		public int x;
		public int y;
		public int z;
		public Vector3Int(int x=0,int y=0,int z=0){
			this.x = x;
			this.y = y;
			this.z = z;
		}
		public static Vector3Int operator +(Vector3Int vectorA,Vector3Int vectorB){
			Vector3Int result;
			result.x = vectorA.x + vectorB.x;
			result.y = vectorA.y + vectorB.y;
			result.z = vectorA.z + vectorB.z;
			return result;
		}
		public static Vector3Int operator -(Vector3Int vectorA,Vector3Int vectorB){
			Vector3Int result;
			result.x = vectorA.x - vectorB.x;
			result.y = vectorA.y - vectorB.y;
			result.z = vectorA.z - vectorB.z;
			return result;
		}
		public static Vector3Int operator *(Vector3Int vector,int scale){
			vector.x *= scale;
			vector.y *= scale;
			vector.z *= scale;
			return vector;
		}
		public static Vector3Int operator *(Vector3Int vectorA,Vector3Int vectorB){
			Vector3Int result;
			result.x = vectorA.x * vectorB.x;
			result.y = vectorA.y * vectorB.y;
			result.z = vectorA.z * vectorB.z;
			return result;
		}
		public static Vector3Int operator /(Vector3Int vectorA,Vector3Int vectorB){
			Vector3Int result;
			result.x = vectorA.x / vectorB.x;
			result.y = vectorA.y / vectorB.y;
			result.z = vectorA.z / vectorB.z;
			return result;
		}
		public static Vector3Int operator %(Vector3Int vectorA,Vector3Int vectorB){
			Vector3Int result;
			result.x = vectorA.x % vectorB.x;
			result.y = vectorA.y % vectorB.y;
			result.z = vectorA.z % vectorB.z;
			return result;
		}
	}
}
