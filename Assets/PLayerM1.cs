using UnityEngine;
using System.Collections;

public class PLayerM1 : MonoBehaviour {
	CharacterController controller; 
	Vector3 VM1;
	public float MSp = 5f;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		VM1 = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

		VM1.Normalize ();

		controller.Move (VM1* MSp * Time.deltaTime);
	}
}
