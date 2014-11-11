#pragma strict

static var sensetivy : Number = 5;
var mouseSensetivy : int = 10;
var MoveSpeed : Number = 10;
var firepoint : Transform;
var ammo : GameObject;
var spawnObject : Transform;
var flashlight : Light;
var firePower : int = 10;


function Update () {


	// Turn off/on Flashlight
	if(flashlight){
		if(Input.GetKeyDown("f")) flashlight.enabled = !flashlight.enabled;
	}

	if(Input.GetKeyDown("escape")){
		Application.Quit();
		print("escape is pressed");
	}
}

function FixedUpdate () {
	
	// Move Player forward
	this.rigidbody.velocity = transform.TransformDirection(Vector3(Input.GetAxis("Horizontal")*MoveSpeed,rigidbody.velocity.y,Input.GetAxis("Vertical")*MoveSpeed));
	
	// Rotate Player 
	transform.Rotate(Vector3(0,Input.GetAxis("Mouse X")*Time.deltaTime*mouseSensetivy,0));


}