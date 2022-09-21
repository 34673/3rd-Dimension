namespace ThirdDimension.Engine{
	public struct Matrix4x4{
		public float[,] elements;
		public Matrix4x4(bool dummyParameter = true){
			this.elements = new float[4,4];
		}
		public static Vector3 Multiply(Vector3 vector,Matrix4x4 matrix){
			float w = vector.x * matrix.elements[0,3] + vector.y * matrix.elements[1,3] + vector.z * matrix.elements[2,3] + matrix.elements[3,3];
			vector.x = vector.x * matrix.elements[0,0] + vector.y * matrix.elements[1,0] + vector.z * matrix.elements[2,0] + matrix.elements[3,0];
			vector.y = vector.x * matrix.elements[0,1] + vector.y * matrix.elements[1,1] + vector.z * matrix.elements[2,1] + matrix.elements[3,1];
			vector.z = vector.x * matrix.elements[0,2] + vector.y * matrix.elements[1,2] + vector.z * matrix.elements[2,2] + matrix.elements[3,2];
			if(w != 0f){
				vector.x /= w;
				vector.y /= w;
				vector.z /= w;
			}
			return vector;
		}
	}
}
