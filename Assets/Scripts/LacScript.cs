using UnityEngine;
using System.Collections;

public class LacScript : MonoBehaviour {
	public int columns;
	public int rows;
	public int colst1;
	public int rowst1;
	public int colst2;
	public int rowst2;
	public GameObject calis;

	
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		aniSprite Animator = GetComponent<aniSprite>();
					//***********************************animation**************************
		//int columnSize, int rowSize, int colFrameStart, int rowFrameStart, int totalFrames, int framesPerSecond
				if (this.transform.position.x < calis.transform.position.x){				
       									Animator.Animate(columns, rows, colst1, rowst1, 1, 1);
		}
		else
		{
			Animator.Animate(columns, rows, colst2, rowst2, 1, 1);
		}
	}
}
