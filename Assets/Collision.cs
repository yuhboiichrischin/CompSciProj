using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {
	public bool tags;
	// Use this for initialization
	void OnTriggerEnter (Collider collision) {
		//Debug.LogType("stuff");
		if (tags == true)
			tags = false;
		if (tags == false)
			tags = true;
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
