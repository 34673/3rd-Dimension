using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDimension.Engine.Renderer{
	public static class DrawTools{
		public static void DrawCharacter(Vector2Int position,char character = '█',ConsoleColor color = ConsoleColor.Magenta){
			if(position.x >= 0 && position.x < Properties.width.value &&
				position.y >= 0 && position.y < Properties.height.value
			){
				//Color needs to be set as a CHAR_INFO attribute
				Properties.renderBuffer[position.y * Properties.width.value + position.x] = character;
			}
		}
		public static void DrawLine(
			Vector2Int startingPosition,Vector2Int endingPosition,
			char character = '█',ConsoleColor color = ConsoleColor.Magenta
		){
			var delta = new Vector2Int(endingPosition.x - startingPosition.x,endingPosition.y - startingPosition.y);
			var deltaError = delta.x == 0 ? 0 : delta.y / delta.x;
			var y = startingPosition.y;
			for(var x=startingPosition.x;x<endingPosition.x;x++){
			   DrawTools.DrawCharacter(new Vector2Int(x,y),character,color);
			   y += deltaError;
			}
		}
	}
}
