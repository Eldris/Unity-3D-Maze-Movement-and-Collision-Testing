using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMove : MonoBehaviour {
public float HorSpeed = 150.0f;
	public float VerSpeed = 30.0f;
//	public float JumpHeight = 1000.0f;
	/*@param HorSpeed is the settable speed for the character movement to the left and the right.
	  @param VerSpeed is the settable speed for the character movement while moving forward or backward.
	  @param JumpHeight sets the height of the jump. 
	*/
	public float CameraSpeedHor = 5.0f;
	public float CameraSpeedVer = 5.0f;
	/*@param CameraSpeedHor sets the sensitivity of the Camera Mouse Movement for up and down.
	  @param CameraSpeedVer sets the sensitivity of the Camera Mouse Movement for left and right.
	*/

	private float MouseLR = 0.0f;
	private float MouseUD = 0.0f;
	/*The two param's are used to track the movement if the and apply it into later code */

	// Use this for initialization
	void Start () {
		print("Ready to Move!");
	}
	
	// Update is called once per frame
	void Update () {
		var FB = Input.GetAxis("Horizontal") * Time.deltaTime * HorSpeed;
		/*Sets a veriable for Left/Right movement. Then gets the unity presets for Horizontal movement
		then multiples by deltatime so movement is done via seconds rather than frames.
		Then multiplies by the set HorSpeed */
        var LR = Input.GetAxis("Vertical") * Time.deltaTime * VerSpeed;
		/*Does the same as above but for the Vertical movement. */

        transform.Translate(-LR, 0, 0);
		/*Applies the left and right movement calling upon the variable created above. */
        transform.Translate(0, 0, FB);
		/*Same as above but for forward and backward movement. */

	//if (Input.GetKeyDown(KeyCode.Space)){
	//		GetComponent<Rigidbody> ().AddForce (Vector3.up * JumpHeight);
	//	}
		/*Makes an if statement that looks for the Spacebar being pressed.
		if the spacebar is pressed it uses the Rigidbody component from unity
		to move up the Y Axis (Vector3) mutliplied by the JumpHeight variable.  */

	MouseLR += CameraSpeedHor * Input.GetAxis("Mouse X");
	MouseUD -= CameraSpeedVer * Input.GetAxis("Mouse Y");
	/*The two pieces of code above are for the camera look-around fucntion.
	They takes the private variables which are set to 0.0 and then are affected
	by the speed variable we have set mutliplied by the Unity Mouse presets. */
	transform.eulerAngles = new Vector3(0.0f, MouseLR, 0.0f);
	/*The two private variables are then used to transform the Euler Angles 
	(basically the camera movement arcs) using data created from the above code. */
	}
}

