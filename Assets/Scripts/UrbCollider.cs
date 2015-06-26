using UnityEngine;
using System.Collections;

public class UrbCollider : MonoBehaviour {
			private GameObject cube;
	public AudioClip drill;
	// Use this for initialization
			void OnTriggerEnter(Collider other) 

	{
		cube = other.gameObject;

	}
	
	void Update()
	{
				if(Input.GetKeyDown(KeyCode.Space))
		{
			Destroy (cube.gameObject);
			GetComponent<AudioSource>().PlayOneShot(drill);
		}
	}
	
}
