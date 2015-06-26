using UnityEngine;
using System.Collections;

public class EndSpaceflowScript : MonoBehaviour {
	public float downSpeed;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		downSpeed =50;
	transform.Translate(downSpeed * Time.deltaTime,0,0);
		
		if(transform.position.y <= 0)
		{
			transform.position = new Vector3(0,144,0);
		}

	}
}
