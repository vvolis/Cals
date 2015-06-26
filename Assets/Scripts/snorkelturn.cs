using UnityEngine;
using System.Collections;

public class snorkelturn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public int turn;
	// Update is called once per frame
	void Update () {
		aniSprite Animator = GetComponent<aniSprite>();
		if (Input.GetKey(KeyCode.D))
			{turn =1;}
		if (Input.GetKey(KeyCode.A))
			{turn =0;}
		
		
		//int columnSize, int rowSize, int colFrameStart, int rowFrameStart, int totalFrames, int framesPerSecond
										
       									Animator.Animate(2, 1, turn, 0, 1, 1) ;
	
	}
}
