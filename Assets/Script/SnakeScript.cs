using UnityEngine;
using System.Collections;

public class SnakeScript : MonoBehaviour {

	private Vector3 start_Pos;
	private const float z_Pos= 0;

	//private Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
		start_Pos = transform.position;
		//const float pos = transform.position.x;
	}

	// Update is called once per frame
	void Update () {

		//rigidbody.constraints = RigidbodyConstraints.FreezePositionX;
		transform.position = new Vector3(start_Pos.x + Mathf.PingPong(Time.time * 0.5f, 1.5f), start_Pos.y, z_Pos);

		transform.rotation = Quaternion.Euler(0, 180, 0);

	}
}