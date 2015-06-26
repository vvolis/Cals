using UnityEngine;
using System.Collections;

public class Spacemove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public GameObject Calis;
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector3(Calis.transform.position.x*-2 + 40,Calis.transform.position.y*-2,4);
	
	}
}
