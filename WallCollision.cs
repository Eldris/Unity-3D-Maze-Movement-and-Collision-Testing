using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour {
	private bool touchingWall = false;
//Creates a Boolean for whether or not the walls are being touched. 
	void OnCollisionStay(Collision col){
		 touchingWall = true;
	} /*This piece of code states that when a rigidbody come in contact with the linked
	 object it changes the boolean to true*/

	void OnCollisionExit(Collision col){
		touchingWall = false;
	} /*Once the rigidbody leaves contact with the linked object the boolean returns to false */

	// Use this for initialization
	void Start () {
		
	} 
	
	// Update is called once per frame
	void Update () {
		
		if (touchingWall)
		{
			print("Get away from the wall now!");
		} /*calls upon the boolean in an if statement, when true a message will be printed */

	}
}
