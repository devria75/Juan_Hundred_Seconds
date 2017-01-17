using UnityEngine;
using System.Collections;

public class button2pressed : MonoBehaviour {
	public GameObject Elevator;
	// Transform of the camera to shake. Grabs the gameObject's transform
	// if null.
	public Transform camTransform;
	public GameObject playerCam;

	// How long the object should shake for.
	public float shakeDuration; 

	// Amplitude of the shake. A larger value shakes the camera harder.
	public float shakeAmount = 0.7f;
	public float decreaseFactor = 1.0f;

	Vector3 originalPos;
	public AudioClip Rumble;
	private AudioSource audio;

	void Start () {
		audio = GetComponent<AudioSource> ();
	}

	// Use this for initialization
	void OnMouseDown() {
		shakeDuration = 20f;
		Camera camera = Camera.main;
		originalPos = camTransform.localPosition;
		audio.PlayOneShot (Rumble);
	}

	void Update()
	{
		if (shakeDuration > 0)
		{
			camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

			shakeDuration -= Time.deltaTime * decreaseFactor;
			shakeDuration = 0f;
		}
		else
		{
			shakeDuration = 0f;
			camTransform.localPosition = originalPos;
		}
	}

}
