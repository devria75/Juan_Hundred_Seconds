using UnityEngine;
using System.Collections;

public class ConvoyPath : MonoBehaviour {

	public GameObject button;

	// put the points from unity interface
	public Transform[] wayPointList;

	public int currentWayPoint = 0; 
	public Transform targetWayPoint;

	public float rotateSpeed = 1f;
	public float moveSpeed = 4f; 

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// check if we have somewere to walk
		if(currentWayPoint < this.wayPointList.Length)
		{
			if(targetWayPoint == null)
				targetWayPoint = wayPointList[currentWayPoint];
			walk();
		}
	}

	void walk(){
		// rotate towards the target
		transform.forward = Vector3.RotateTowards(transform.forward, targetWayPoint.position - transform.position, rotateSpeed*Time.deltaTime, 0.0f);

		// move towards the target
		transform.position = Vector3.MoveTowards(transform.position, targetWayPoint.position,   moveSpeed*Time.deltaTime);

		if(transform.position == targetWayPoint.position)
		{
			currentWayPoint ++ ;
			targetWayPoint = wayPointList[currentWayPoint];
		}
	} 
		
}
