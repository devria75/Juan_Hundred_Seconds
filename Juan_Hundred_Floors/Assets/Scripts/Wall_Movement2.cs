using UnityEngine;
using System.Collections;

public class Wall_Movement2 : MonoBehaviour {

	public Vector3 endPosition = new Vector3(0.308f, 0.9840001f, -0.8533344f);
	public float speed;

	public GameObject button1;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//THIS IS SOME MOTHERFUCKING DEBUG CODE YOU BITCHES
		//THIS IS ALSO THE *BETTER* VERSION OF OnMouseDown
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				Debug.Log ("Name = " + hit.collider.name);
				Debug.Log ("Tag = " + hit.collider.tag);
				Debug.Log ("------------------");
			}
		}
		if (button1.GetComponent<button1pressed>().isFlashing == false) {
			transform.localPosition = Vector3.Lerp (transform.localPosition, endPosition, Time.deltaTime * speed);
		} else {
			transform.localPosition = Vector3.Lerp (transform.localPosition, new Vector3(-0.3670709f, 1.07f, -0.8533344f) , Time.deltaTime * speed);
		}
	}
}