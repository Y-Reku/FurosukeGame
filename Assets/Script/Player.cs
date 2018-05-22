using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class Player : MonoBehaviour {


	public GameObject mainCamera;
	private Animator anim;
	public FadeManager fade;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {


		anim.SetBool ("Wait", true);
		transform.rotation = Quaternion.Euler(0, 180, 0);
		if (Input.GetKey (KeyCode.Space)) {
			anim.SetTrigger ("Jump");

			transform.position += new Vector3 (0.0f, 8.0f, 0.0f) * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position += new Vector3 (4.0f, 0.0f, 0.0f) * Time.deltaTime;
			anim.SetTrigger ("Walk");
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position += new Vector3 (-4.0f, 0.0f, 0.0f) * Time.deltaTime;
			anim.SetBool ("Walk", true);

		} else {
			anim.SetBool ("Wait", true);
		}

		//画面中央から左に4移動した位置をキャラクターが超えたら
		if (transform.position.x > mainCamera.transform.position.x - 7) {
			//カメラの位置を取得
			Vector3 cameraPos = mainCamera.transform.position;
			//キャラクターの位置から右に4移動した位置を画面中央にする
			cameraPos.x = transform.position.x + 7;
			mainCamera.transform.position = cameraPos;
		}
		//カメラ表示領域の左下をワールド座標に変換
		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
		//カメラ表示領域の右上をワールド座標に変換
		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
		//ユニティちゃんのポジションを取得
		Vector2 pos = transform.position;
		//ユニティちゃんのx座標の移動範囲をClampメソッドで制限
		pos.x = Mathf.Clamp(pos.x, min.x + 0.5f, max.x);
		//transform.position = pos;
	
	}
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Enemy") {
			SceneManager.LoadScene ("GameOver");
		}else if (collision.gameObject.tag == "GOAL") {
			SceneManager.LoadScene ("COMINGSOON");
		}
	}
}
