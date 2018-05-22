using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 
public class SceneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (SceneManager.GetActiveScene ().name == "Title") {
			if (Input.GetKeyDown (KeyCode.Space)) {
				FadeManager.Instance.LoadLevel ("Prologue", 2.0f);
			}
		}
		if (SceneManager.GetActiveScene ().name == "Prologue") {
			if (Input.GetKeyDown (KeyCode.Space)) {
				FadeManager.Instance.LoadLevel ("Main", 2.0f);
			}
		}
		if (SceneManager.GetActiveScene ().name == "Main") {
			if (Input.GetKeyDown (KeyCode.Space)) {
				FadeManager.Instance.LoadLevel ("Stage1(forest)", 2.0f);
			}
		}
		if (SceneManager.GetActiveScene ().name == "GameOver") {
			if (Input.GetKeyDown (KeyCode.Space)) {
				FadeManager.Instance.LoadLevel ("Title", 2.0f);
			}
		}if (SceneManager.GetActiveScene ().name == "COMINGSOON") {
			if (Input.GetKeyDown (KeyCode.Space)) {
				FadeManager.Instance.LoadLevel ("Title", 2.0f);
			}
		}

	}
}
