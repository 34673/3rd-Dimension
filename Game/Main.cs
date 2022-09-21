using System;
using ThirdDimension.Engine;
using ThirdDimension.Engine.Renderer;
namespace ThirdDimension.Game{
	public static class Main{
		public static bool Initialize(){
			var testCube = new Cube();
			var camera = new Camera();
			Engine.Renderer.Properties.currentCamera = camera;
			camera.position = new Vector3(0f,0f,-30f);
			testCube.Populate();
			camera.objectBuffer.Add(testCube);
			return true;
		}
		public static void Update(){
		}
	}
}
