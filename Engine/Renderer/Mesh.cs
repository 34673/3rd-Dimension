namespace ThirdDimension.Engine.Renderer{
	public abstract class Mesh{
		public struct Vertex{
			public Vertex(bool dummyParameter){
				this.position = new Vector3();
			}
			public Vector3 position;
		}
		public struct Triangle{
			public Triangle(bool dummyParameter){
				this.vertices = new Vertex[3];
			}
			public Vertex[] vertices;
		}
		public Vertex[] vertexBuffer;
		public Triangle[] indexBuffer;
		public static void LoadFromFile(){}
	}
}
