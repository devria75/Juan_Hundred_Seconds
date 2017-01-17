using UnityEngine;
using System.Collections;

public class Elevator_Behavior : MonoBehaviour {

	public float tVal;
	public Transform target; // b = startPosition + offset
	public AnimationCurve curve;
	public float scale = 20f;
	public float duration = 1f;
	public Vector3 startPosition; // a
	private Vector3 targetPosition;
	public float elapsed = 0f;
	// Use this for initialization
	void Start () {
	
	}

	public void Drop () {
		tVal = elapsed / duration;
		elapsed += Time.deltaTime;
		targetPosition = target.position;
		Vector3 actualPosition = Vector3.Lerp(startPosition, targetPosition, curve.Evaluate(tVal));
		transform.position = actualPosition;
	}
}
