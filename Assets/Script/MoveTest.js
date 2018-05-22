#pragma strict
private var animator : Animator;
private var cCon : CharacterController;
private var x : float;
private var y : float;
private var velocity : Vector3;
public var jumpPower : float;
function Start () {
 animator = GetComponent(Animator);
 cCon = GetComponent(CharacterController);
 velocity = Vector3.zero;
}
function Update () {
 if(cCon.isGrounded) {
  velocity = Vector3.zero;
  x = Input.GetAxis("Horizontal");
  //y = Input.GetAxis("Vertical");
  var input = Vector3(x, 0, 0);
//　方向キーが多少押されている
  if(input.magnitude > 0.1f) {
   animator.SetFloat("Speed", input.magnitude);
   transform.LookAt(transform.position + input);
   velocity += input.normalized * 2;
//　キーの押しが小さすぎる場合は移動しない
  } else {
   animator.SetFloat("Speed", 0);
  }
  if(Input.GetButtonDown("Jump")) {
   velocity.y += jumpPower;
  }
 }
 velocity.y += Physics.gravity.y * Time.deltaTime;
 cCon.Move(velocity * Time.deltaTime);
}