using UnityEngine;
using System.Collections;

public class Wall_Movement : MonoBehaviour {
	public Vector3 endPosition = new Vector3(2.077929f, 1.07f, -0.8533344f);
	public float speed;

	public GameObject button1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (button1.GetComponent<button1pressed>().isFlashing == false) {
			transform.localPosition = Vector3.Lerp (transform.localPosition, endPosition, Time.deltaTime * speed);
		} else {
			transform.localPosition = Vector3.Lerp (transform.localPosition, new Vector3(2.252929f, 1.07f, -0.8533344f) , Time.deltaTime * speed);
		}
	}
}
