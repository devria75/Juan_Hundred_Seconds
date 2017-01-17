using UnityEngine;
using System.Collections;

public class button2pressed : MonoBehaviour {
	public GameObject Elevator;

	// Use this for initialization
	void OnMouseDown() {
		Elevator.GetComponent<Elevator_Behavior>().Drop();
	}

}
