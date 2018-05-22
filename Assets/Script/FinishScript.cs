using UnityEngine;
using System.Collections;

public class FinishScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//escボタンで終了させる
		if (Input.GetKey(KeyCode.Escape)) {
			Application.Quit();
		}
	}
}
