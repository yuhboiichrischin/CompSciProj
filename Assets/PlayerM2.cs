using UnityEngine;
using System.Collections;

public class PlayerM2 : MonoBehaviour {
	CharacterController controller; 
	Vector3 VM2;
	public float MSp = 5f;
	
	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		VM2 = new Vector3();

		if (Input.GetKey ("i"))
			VM2.z = 1;
		if (Input.GetKey ("j"))
			VM2.x = 1;
		if (Input.GetKey ("k"))
			VM2.z = -1;
		if (Input.GetKey ("l"))
			VM2.x = -1;

		
		VM2.Normalize ();
		
		controller.Move (VM2* MSp * Time.deltaTime);
	}
}
