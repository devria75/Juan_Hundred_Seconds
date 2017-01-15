using UnityEngine;
using System.Collections;

public class Tween_Mover_Easy : MonoBehaviour {
	[Range(0f,1f)]
	public float tVal;
	public Transform target; // b = startPosition + offset
	public AnimationCurve curve;

	public Color startColor, endColor;

	private Material mat;

	public float scale = 1f;

	public float duration = 5f;

	public Vector3 startPosition; // a
	private Vector3 targetPosition;

	public float elapsed = 0f;

	void Start () {
		mat = this.GetComponent<MeshRenderer>().material;
	}


	void Update () {
		tVal = elapsed / duration;
		elapsed += Time.deltaTime;
		targetPosition = target.position;
		//		Vector3 actualPosition = startPosition + scale * tVal * (targetPosition - startPosition);// A + t * (B - A)
		Vector3 actualPosition = Vector3.Lerp(startPosition, targetPosition, curve.Evaluate(tVal));
		mat.color = Color.Lerp(startColor, endColor, curve.Evaluate(tVal));
		transform.position = actualPosition;
	}
}
