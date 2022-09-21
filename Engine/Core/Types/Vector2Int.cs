namespace ThirdDimension.Engine{
	public struct Vector2Int{
		public int x;
		public int y;
		public Vector2Int(int x=0,int y=0){
			this.x = x;
			this.y = y;
		}
		public static Vector2Int operator +(Vector2Int vectorA,Vector2Int vectorB){
			Vector2Int result;
			result.x = vectorA.x + vectorB.x;
			result.y = vectorA.y + vectorB.y;
			return result;
		}
		public static Vector2Int operator -(Vector2Int vectorA,Vector2Int vectorB){
			Vector2Int result;
			result.x = vectorA.x - vectorB.x;
			result.y = vectorA.y - vectorB.y;
			return result;
		}
		public static Vector2Int operator *(Vector2Int vector,int scale){
			vector.x *= scale;
			vector.y *= scale;
			return vector;
		}
		public static Vector2Int operator *(Vector2Int vectorA,Vector2Int vectorB){
			Vector2Int result;
			result.x = vectorA.x * vectorB.x;
			result.y = vectorA.y * vectorB.y;
			return result;
		}
		public static Vector2Int operator /(Vector2Int vectorA,Vector2Int vectorB){
			Vector2Int result;
			result.x = vectorA.x / vectorB.x;
			result.y = vectorA.y / vectorB.y;
			return result;
		}
		public static Vector2Int operator %(Vector2Int vectorA,Vector2Int vectorB){
			Vector2Int result;
			result.x = vectorA.x % vectorB.x;
			result.y = vectorA.y % vectorB.y;
			return result;
		}
	}
}
