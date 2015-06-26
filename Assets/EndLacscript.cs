using UnityEngine;
using System.Collections;

public class EndLacscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	aniSprite Animator = GetComponent<aniSprite>();
		//***********************************animation**************************
		//int columnSize, int rowSize, int colFrameStart, int rowFrameStart, int totalFrames, int framesPerSecond
										
       									Animator.Animate(2, 1, 0, 0, 2, 1) ;
	}
}
