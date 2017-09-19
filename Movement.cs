using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	//movement tools
	private bool wPressed;
	private bool sPressed;
	//rotation tools
	private bool aPressed;
	private bool dPressed;


	public int forceConst = 50; 

	private bool canJump; 
	private Rigidbody selfRigidbody; 



	// Use this for initialization
	void Start () {

		selfRigidbody = GetComponent<Rigidbody>();  

	}
	
	// Update is called once per frame
	void Update () {

		wPressed = Input.GetKey (KeyCode.W);
		sPressed = Input.GetKey (KeyCode.S);
		aPressed = Input.GetKey (KeyCode.A);
		dPressed = Input.GetKey (KeyCode.D);




	}

	private void FixedUpdate()
	{
		if (wPressed == true)
		{
			transform.position += transform.forward;

		}
		if (sPressed == true)
		{
			transform.position -= transform.forward;
		}
		if (dPressed == true)
		{
			transform.position += transform.right; 
		}
		if (aPressed == true)
		{
			transform.position += transform.left;
		}

	
		if(canJump){
			canJump = false;
			selfRigidbody.addForce(0, forceConst, 0, ForceMode.Impulse); 
		}
	}

	void Update(){
		if(Input.GetKeyUp(Keycode.space)){
			canJump = true; 
		}
	} 


	// the movement script is functional, jump function doesnt work

	// transform.left doesnt work
	// keycode.space doesnt work
	//addforce doesnt work


}
