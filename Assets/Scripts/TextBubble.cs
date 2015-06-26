using UnityEngine;
using System.Collections;

public class TextBubble : MonoBehaviour {
	
	public GameObject plane;
	public GameObject calis;
	public AudioClip blip;


	// Use this for initialization
	void Start () {
		plane.GetComponent<Renderer>().enabled = false;
	
	}
	
/*	// Update is called once per frame
	void Update () {
		if(calis.transform.position.x - this.transform.position.x <=1 && calis.transform.position.y - this.transform.position.y <=1)
		{
	plane.renderer.enabled = true;
		}
		else
		{
			plane.renderer.enabled = false;
		}
	}                */
	
	

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "Calis")
		{
			plane.GetComponent<Renderer>().enabled = true;
			GetComponent<AudioSource>().PlayOneShot(blip);
			Debug.Log("aaaa");
		}
		
	}
	
		void OnTriggerExit(Collider other)
	{
		if(other.gameObject.name == "Calis")
		{
			plane.GetComponent<Renderer>().enabled = false;
			Debug.Log("bbbb");
		}
		
	}
	
	
}
