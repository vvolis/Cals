using UnityEngine;
using System.Collections;

public class Endtitle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	aniSprite Animator = GetComponent<aniSprite>();
		//***********************************animation**************************
		//int columnSize, int rowSize, int colFrameStart, int rowFrameStart, int totalFrames, int framesPerSecond
										
       									Animator.Animate(5, 1, 0, 4, 2, 3) ;
		
	}
}
