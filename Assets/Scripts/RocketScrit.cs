using UnityEngine;
using System.Collections;

public class RocketScrit : MonoBehaviour {
	public GameObject calencals;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			
		
		Calis otherScript = calencals.GetComponent<Calis>();
		aniSprite Animator = GetComponent<aniSprite>();
					//***********************************animation**************************
		//int columnSize, int rowSize, int colFrameStart, int rowFrameStart, int totalFrames, int framesPerSecond
				if (otherScript.rocketActive){				
       				Animator.Animate(2, 1, 0, 0, 1, 1);
			
		}
		else
		{
			Animator.Animate(2, 1, 1, 0, 1, 1);
			CameraFade.StartAlphaFade( Color.white, false, 4f, 4f, () => { Application.LoadLevel(2); } );
			
		}
	
	}
}
