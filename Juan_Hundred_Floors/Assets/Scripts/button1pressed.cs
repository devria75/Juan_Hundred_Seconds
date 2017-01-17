using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class button1pressed : MonoBehaviour {
	public GameObject elevatorLight;
	GameObject wall;

	float randomThreshold;
	float minThreshold = 0.5f; // min time between flashes
	float maxThreshold = 3.0f; // max time between flashes

	float timer; //don't touch
	public bool isFlashing; //don't touch

	int randomFlashes; //don't touch
	int minFlashes = 3; //min number of flashes
	int maxFlashes = 5; //max number of flashes (max is exclusive)

	float timeBetweenFlashes = 0.1f;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isFlashing == false) {
			timer += Time.deltaTime;
		}
	}

	//when mouse clicks the button
	void OnMouseDown(){
		//turn the lights on and off
		//set thresholds and ranges
		randomThreshold = Random.Range(minThreshold, maxThreshold);
		randomFlashes = Random.Range(minFlashes, maxFlashes);

		if (timer > randomThreshold) {
			timer = 0.0f;
			StartCoroutine(FlashingLights());
		}

	}

	IEnumerator FlashingLights(){
		isFlashing = true;
		Debug.Log ("Function is go.");

		for (int x = 0; x < randomFlashes; x++) {
			elevatorLight.GetComponent<Light>().enabled = false;
			yield return new WaitForSeconds(timeBetweenFlashes);
			elevatorLight.GetComponent<Light>().enabled = true;
			yield return new WaitForSeconds(timeBetweenFlashes);
		}

		//reset variables for the next flashing section
		randomThreshold = Random.Range(minThreshold, maxThreshold);
		randomFlashes = Random.Range(minFlashes, maxFlashes);

		isFlashing = false;
	}
		
}
