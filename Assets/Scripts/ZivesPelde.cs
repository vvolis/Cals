using UnityEngine;
using System.Collections;

public class ZivesPelde : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

		void OnTriggerEnter(Collider other) 

	{
		if(other.name == "DirectionLeft")
		{
			transform.Rotate(Vector3.forward * -90, Space.Self);
			//transform.rotation.z = transform.rotation.z +90;
			//transform.RotateAroundLocal(Vector3.forward,90);
		}
				if(other.name == "DirectionRight")
		{
			transform.Rotate(Vector3.forward * 90, Space.Self);
			//transform.rotation.z = transform.rotation.z +90;
			//transform.RotateAroundLocal(Vector3.forward,90);
		}

	}
	
	void Update()
	{
		transform.Translate(Vector3.right * Time.deltaTime*3);
		
	}

}
