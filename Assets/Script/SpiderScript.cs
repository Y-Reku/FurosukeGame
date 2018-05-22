using UnityEngine;
using System.Collections;

public class SpiderScript : MonoBehaviour {

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
		//指定したポジションを往復する(上下運動)
		transform.position = new Vector3(start_Pos.x, start_Pos.y + Mathf.PingPong(Time.time * 0.5f, 1.5f), z_Pos);

		transform.rotation = Quaternion.Euler(0, 0, 0);

	}
}
