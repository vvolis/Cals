using UnityEngine;
using System.Collections;

public class Calis : MonoBehaviour {
	private float distToGround;
	public GameObject urbis;
	public GameObject dimants;
	public GameObject jetPack;
	public GameObject snorkel;
	public GameObject rocketPart;
	
	private GameObject urbisClone;
	private GameObject  dimantsClone;
	private GameObject  jetPackClone;
	private GameObject  snorkelClone;
	private GameObject  rocketPartClone;
	public bool pjedestalactive = false;
	public bool rocketActive = false;
	public AudioClip step;
	public AudioClip jump;
	public AudioClip tink;
	public float audiowait;
	
	public bool inSpace = false;
	public float jumpForce = 40;
	
	// Use this for initialization
	void Start () {
		distToGround = GetComponent<Collider>().bounds.extents.y;
		
		
	}
	
	//ceck if on ground
	bool IsGrounded() {
			if (inSpace)
		{
			return true;
		}
		else
		{
  			return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
		}
			}
	
	// Update is called once per frame
	void Update () {
		
		audiowait =audiowait+ Time.deltaTime;
		
		
		
		aniSprite Animator = GetComponent<aniSprite>();
		if (Input.GetKey(KeyCode.W))
		{
			if(IsGrounded())
			{
		 	GetComponent<Rigidbody>().AddRelativeForce(0,jumpForce,0);
				GetComponent<AudioSource>().PlayOneShot(jump);
			}
		}
		
		if (Input.GetKey(KeyCode.W))
		{
			if(inSpace)
			{
		 	GetComponent<Rigidbody>().AddRelativeForce(0,0.4f,0);
			}
		}
		
		
				if (Input.GetKey(KeyCode.S))
		{
			if(inSpace)
			{
		 	GetComponent<Rigidbody>().AddRelativeForce(0,-0.4f,0);
			}
		}
		
					if (Input.GetKey(KeyCode.D))
					{
						if (inSpace)
							{
								transform.Rotate(Vector3.forward * Time.deltaTime*-30);
							}
						else
							{
								transform.Translate(Vector3.right * Time.deltaTime*5);
				//***********************************animation**************************
		//int columnSize, int rowSize, int colFrameStart, int rowFrameStart, int totalFrames, int framesPerSecond
										
       									Animator.Animate(4, 4, 0, 0, 3, 12) ;
							}
					}
		
					if (Input.GetKey(KeyCode.A))
					{
									if (inSpace)
							{
								transform.Rotate(Vector3.forward * Time.deltaTime*30);
							}
									else
							{
								//***********************************animation**************************
		//int columnSize, int rowSize, int colFrameStart, int rowFrameStart, int totalFrames, int framesPerSecond
										
       									Animator.Animate(4, 4, 0, 1, 3, 12) ;
										transform.Translate(Vector3.left * Time.deltaTime*5);
								}
					}
		
		//teleport for space.
		if (this.transform.position.x >50)
		{
			transform.position =new Vector3(-39,this.transform.position.y,0);
		}
				if (this.transform.position.x <-40)
		{
			transform.position =new Vector3(49,this.transform.position.y,0);
		}
				if (this.transform.position.y >30)
		{
			transform.position =new Vector3(this.transform.position.x,-34,0);
		}
				if (this.transform.position.y <-35)
		{
			transform.position =new Vector3(this.transform.position.x,29,0);
		}
		
		
		
		
		//walking sound
		if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.D))
		{
    			GetComponent<AudioSource>().clip = step;
    			GetComponent<AudioSource>().Play();
		}
		
				if (Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.D))
		{
    			GetComponent<AudioSource>().clip = step;
    			GetComponent<AudioSource>().Stop();
		}
	
	}
	
	//Teleportds
	private GameObject teleport;
	private float distx;
	private float disty;
	private int rot;
	private GameObject token;
	
	private bool urbisSpwn = false;
	private bool dimantsSpwn = false;
	private bool snorkelSpwn = false;
	public bool jetPackSpwn = false;
	private bool rocketpartSpwn = false;
	public GameObject swimdoor;
	public GameObject hackerDoor;
	public GameObject spaceLockdoor;
	
			private GameObject respawnPrefab;
    private Object respawns;
	
	IEnumerator OnTriggerEnter(Collider other) 

	{
		teleport = other.gameObject;
			rot = Mathf.FloorToInt(teleport.transform.rotation.eulerAngles.z);
		if(other.name == "Tele1")
		{	
		switch(rot)
			{
				case 0:
				distx =1;
				disty = -1;
				break;
				
				case 90:
				distx =1;
				disty =1;
				break;
				
				case 180:
				distx =-1;
				disty =1;
				break;
				
				case 270:
				distx =-1;
				disty =-1;
				break;
			}
		yield return new WaitForSeconds(0.3F);		
		transform.position =new Vector3(teleport.transform.position.x +distx,teleport.transform.position.y +disty,0);
		}
		
				if(other.name == "Tele2")
		{	
		switch(rot)
			{
				case 0:
				distx =1;
				disty = -3;
				break;
				
				case 90:
				distx =3;
				disty =1;
				break;
				
				case 180:
				distx =-1;
				disty =3;
				break;
				
				case 270:
				distx =-3;
				disty =-1;
				break;
			}
		yield return new WaitForSeconds(0.3F);		
		transform.position =new Vector3(teleport.transform.position.x +distx,teleport.transform.position.y +disty,0);
		}
		//spaaaaace
		if(other.name == "Tele3")
		{
			yield return new WaitForSeconds(0.3F);		
		transform.position =new Vector3(18,-7,0);
		}
		
				if(other.name == "SpaceEntry")
		{
			jumpForce = 2;
			inSpace = true;
			gameObject.GetComponent<Rigidbody>().useGravity = false;
		}
		
				if(other.name == "SpaceExit")
		{
			transform.rotation = Quaternion.identity;
			jumpForce = 40;
			inSpace = false;
			gameObject.GetComponent<Rigidbody>().useGravity = true;
		}
		
		//COLLLECTSHIT	


  

    
		
		
		
		
			if(other.name == "Urbis" && !urbisSpwn)
		{
			urbisClone =Instantiate (urbis, this.transform.position, this.transform.rotation) as GameObject;
				urbisClone.transform.parent = this.transform;
			Destroy(other.gameObject);
			urbisSpwn = true;
			GetComponent<AudioSource>().PlayOneShot(tink);
		}
		
				if(other.name == "dimants" && !dimantsSpwn)
		{
			dimantsClone =Instantiate (dimants, this.transform.position, this.transform.rotation) as GameObject;
				dimantsClone.transform.parent = this.transform;
			Destroy(other.gameObject);
			Destroy(urbisClone.gameObject);
			dimantsSpwn = true;
			GetComponent<AudioSource>().PlayOneShot(tink);
		}
		
				if(other.name == "snorkel" && !snorkelSpwn)
		{
			snorkelClone =Instantiate (snorkel, this.transform.position, this.transform.rotation) as GameObject;
				snorkelClone.transform.parent = this.transform;
			Destroy(other.gameObject);
			GetComponent<AudioSource>().PlayOneShot(tink);
			
			snorkelSpwn = true;
			Destroy (swimdoor);
		}
		
				if(other.name == "jetPack" && !jetPackSpwn)
		{
			jetPackClone =Instantiate (jetPack, this.transform.position, this.transform.rotation) as GameObject;
				jetPackClone.transform.parent = this.transform;
			Destroy(other.gameObject);
			Destroy(snorkelClone.gameObject);
			jetPackSpwn = true;
			Destroy(spaceLockdoor);
			GetComponent<AudioSource>().PlayOneShot(tink);
			
		}
		
				if(other.name == "rocketPart" && !rocketpartSpwn)
		{
			rocketPartClone =Instantiate (rocketPart, this.transform.position, this.transform.rotation) as GameObject;
				rocketPartClone.transform.parent = this.transform;
			Destroy(other.gameObject);
			rocketpartSpwn = true;
			GetComponent<AudioSource>().PlayOneShot(tink);
		}
		
		
						if(other.name == "Pjedestals" && dimantsSpwn)
		{
			Destroy(hackerDoor);
			Destroy(dimantsClone.gameObject);
			pjedestalactive = true;
			GetComponent<AudioSource>().PlayOneShot(tink);
		}
		
		
		
								if(other.name == "Rocket" && rocketpartSpwn)
		{
			Destroy(rocketPartClone.gameObject);
			rocketActive = true;
			GetComponent<AudioSource>().PlayOneShot(tink);
		}
		
		//zives
			if(other.name == "Zive")
		{	
	
		transform.position =new Vector3(10,-11,0);
		}
		
		
		


	}
	
}
