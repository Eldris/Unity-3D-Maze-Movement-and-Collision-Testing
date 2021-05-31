using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour {

	private void OnTriggerEnter(){
		print("Congratulations! You Win!");
	}
	/*When the rigidbody enters through the linked collider a message will be displayed. */
}
