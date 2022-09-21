using System;
using System.Collections.Generic;
namespace ThirdDimension.Engine.Renderer{
	public class Camera{
		public Vector3 position;
		public List<Mesh> objectBuffer = new List<Mesh>();
		public static void ProjectToWorld(Mesh buffer){
			var aspectRatio = (float)Properties.height.value / (float)Properties.width.value;
			var fieldOfViewRadiant = 1f / (float)Math.Tan(Properties.fieldOfView.value * .5f / 180f * (float)Math.PI);
			var projectionMatrix = new Matrix4x4(true);
			projectionMatrix.elements[0,0] = aspectRatio * fieldOfViewRadiant;
			projectionMatrix.elements[1,1] = fieldOfViewRadiant;
			projectionMatrix.elements[2,2] = Properties.farClip.value / (Properties.farClip.value - Properties.nearClip.value);
			projectionMatrix.elements[3,2] = (-Properties.farClip.value * Properties.nearClip.value) / (Properties.farClip.value - Properties.nearClip.value);
			projectionMatrix.elements[2,3] = 1f;
			projectionMatrix.elements[3,3] = 0f; 
			for(var i=0;i<buffer.vertexBuffer.Length-1;i++){
				buffer.vertexBuffer[i].position = Matrix4x4.Multiply(buffer.vertexBuffer[i].position,projectionMatrix);
			}
		}
		public static void RasterizeMeshToWireframe(Mesh indexBuffer){
			for(var i=0;i<indexBuffer.indexBuffer.Length-1;i++){
				DrawTools.DrawLine(
					new Vector2Int(
						(int)indexBuffer.indexBuffer[i].vertices[0].position.x,
						(int)indexBuffer.indexBuffer[i].vertices[0].position.y
					),
					new Vector2Int(
						(int)indexBuffer.indexBuffer[i].vertices[1].position.x,
						(int)indexBuffer.indexBuffer[i].vertices[1].position.y
					)
				);
				DrawTools.DrawLine(
					new Vector2Int(
						(int)indexBuffer.indexBuffer[i].vertices[1].position.x,
						(int)indexBuffer.indexBuffer[i].vertices[1].position.y
					),
					new Vector2Int(
						(int)indexBuffer.indexBuffer[i].vertices[2].position.x,
						(int)indexBuffer.indexBuffer[i].vertices[2].position.y
					)
				);
				DrawTools.DrawLine(
					new Vector2Int(
						(int)indexBuffer.indexBuffer[i].vertices[2].position.x,
						(int)indexBuffer.indexBuffer[i].vertices[2].position.y
					),
					new Vector2Int(
						(int)indexBuffer.indexBuffer[i].vertices[0].position.x,
						(int)indexBuffer.indexBuffer[i].vertices[0].position.y
					)
				);
			}
		}
	}
}
