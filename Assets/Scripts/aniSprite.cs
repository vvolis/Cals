using UnityEngine;
using System.Collections;

public class aniSprite : MonoBehaviour {


	public void Animate (int columnSize, int rowSize, int colFrameStart, int rowFrameStart, int totalFrames, int framesPerSecond) 
	{
		
		int index = Mathf.RoundToInt(Time.time * framesPerSecond); //timecontrol fps
		index = index % totalFrames;  //modulate
		
		
		Vector2 size = new Vector2(1.0f / columnSize, 1.0f / rowSize); //scale
		float u = index % columnSize;
		float v = index / columnSize;
		
		
		Vector2 offset =  new Vector2((u + colFrameStart) * size.x,(1 - size.y) - (v + rowFrameStart)* size.y); //offset
		
		GetComponent<Renderer>().material.mainTextureOffset = offset;
		GetComponent<Renderer>().material.mainTextureScale = size;
		
	}
}
