using ThirdDimension.Engine;
using ThirdDimension.Engine.Renderer;
public class Cube : Mesh{
	public void Populate(){
		this.vertexBuffer = new Vertex[8];
		this.vertexBuffer[0].position = new Vector3(0f,0f,0f);
		this.vertexBuffer[1].position = new Vector3(0f,0f,1f);
		this.vertexBuffer[2].position = new Vector3(0f,1f,0f);
		this.vertexBuffer[3].position = new Vector3(0f,1f,1f);
		this.vertexBuffer[4].position = new Vector3(1f,0f,0f);
		this.vertexBuffer[5].position = new Vector3(1f,0f,1f);
		this.vertexBuffer[6].position = new Vector3(1f,1f,0f);
		this.vertexBuffer[7].position = new Vector3(1f,1f,1f);
		this.indexBuffer = new Triangle[12];
		for(var i=0;i<indexBuffer.Length;i++){indexBuffer[i].vertices = new Vertex[3];}
		//South
		this.indexBuffer[0].vertices[0] = this.vertexBuffer[0];
		this.indexBuffer[0].vertices[1] = this.vertexBuffer[2];
		this.indexBuffer[0].vertices[2] = this.vertexBuffer[6];
		this.indexBuffer[1].vertices[0] = this.vertexBuffer[0];
		this.indexBuffer[1].vertices[1] = this.vertexBuffer[6];
		this.indexBuffer[1].vertices[2] = this.vertexBuffer[4];
		//East
		this.indexBuffer[2].vertices[0] = this.vertexBuffer[4];
		this.indexBuffer[2].vertices[1] = this.vertexBuffer[6];
		this.indexBuffer[2].vertices[2] = this.vertexBuffer[7];
		this.indexBuffer[3].vertices[0] = this.vertexBuffer[4];
		this.indexBuffer[3].vertices[1] = this.vertexBuffer[7];
		this.indexBuffer[3].vertices[2] = this.vertexBuffer[5];
		//North
		this.indexBuffer[4].vertices[0] = this.vertexBuffer[5];
		this.indexBuffer[4].vertices[1] = this.vertexBuffer[7];
		this.indexBuffer[4].vertices[2] = this.vertexBuffer[3];
		this.indexBuffer[5].vertices[0] = this.vertexBuffer[5];
		this.indexBuffer[5].vertices[1] = this.vertexBuffer[3];
		this.indexBuffer[5].vertices[2] = this.vertexBuffer[1];
		//West
		this.indexBuffer[6].vertices[0] = this.vertexBuffer[1];
		this.indexBuffer[6].vertices[1] = this.vertexBuffer[3];
		this.indexBuffer[6].vertices[2] = this.vertexBuffer[2];
		this.indexBuffer[7].vertices[0] = this.vertexBuffer[1];
		this.indexBuffer[7].vertices[1] = this.vertexBuffer[2];
		this.indexBuffer[7].vertices[2] = this.vertexBuffer[0];
		//Top
		this.indexBuffer[8].vertices[0] = this.vertexBuffer[2];
		this.indexBuffer[8].vertices[1] = this.vertexBuffer[3];
		this.indexBuffer[8].vertices[2] = this.vertexBuffer[7];
		this.indexBuffer[9].vertices[0] = this.vertexBuffer[2];
		this.indexBuffer[9].vertices[1] = this.vertexBuffer[7];
		this.indexBuffer[9].vertices[2] = this.vertexBuffer[6];
		//Bottom
		this.indexBuffer[10].vertices[0] = this.vertexBuffer[5];
		this.indexBuffer[10].vertices[1] = this.vertexBuffer[1];
		this.indexBuffer[10].vertices[2] = this.vertexBuffer[0];
		this.indexBuffer[11].vertices[0] = this.vertexBuffer[5];
		this.indexBuffer[11].vertices[1] = this.vertexBuffer[0];
		this.indexBuffer[11].vertices[2] = this.vertexBuffer[4];
	}
}