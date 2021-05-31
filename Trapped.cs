using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trapped : MonoBehaviour {

	public GameObject Trap; 
	/* calls upon a gameobject, that will be linked in Unity. */
	private void OnTriggerExit(){
		Trap.SetActive(true);
		print("You are now Trapped, enjoy your Prize!");
	} /*When the rigidbody leave the linked collider it causes an unactive 
		object to become active and visable */
}
