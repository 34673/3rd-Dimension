namespace ThirdDimension.Engine{
	public struct Vector2{
		public float x;
		public float y;
		public Vector2(float x=0f,float y=0f){
			this.x = x;
			this.y = y;
		}
		public static Vector2 operator +(Vector2 vectorA,Vector2 vectorB){
			Vector2 result;
			result.x = vectorA.x + vectorB.x;
			result.y = vectorA.y + vectorB.y;
			return result;
		}
		public static Vector2 operator -(Vector2 vectorA,Vector2 vectorB){
			Vector2 result;
			result.x = vectorA.x - vectorB.x;
			result.y = vectorA.y - vectorB.y;
			return result;
		}
		public static Vector2 operator *(Vector2 vector,float scale){
			vector.x *= scale;
			vector.y *= scale;
			return vector;
		}
		public static Vector2 operator *(Vector2 vectorA,Vector2 vectorB){
			Vector2 result;
			result.x = vectorA.x * vectorB.x;
			result.y = vectorA.y * vectorB.y;
			return result;
		}
		public static Vector2 operator /(Vector2 vectorA,Vector2 vectorB){
			Vector2 result;
			result.x = vectorA.x / vectorB.x;
			result.y = vectorA.y / vectorB.y;
			return result;
		}
		public static Vector2 operator %(Vector2 vectorA,Vector2 vectorB){
			Vector2 result;
			result.x = vectorA.x % vectorB.x;
			result.y = vectorA.y % vectorB.y;
			return result;
		}
	}
}
