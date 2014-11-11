#pragma strict

private var windowWidth : int = 0;
private var move : int = 0;
private var menu : GameObject;
private var cameraPosition : GameObject;
private var escapeOptions : GameObject;


function Start () {
	windowWidth = Screen.width;
	menu = GameObject.Find("Menu Holder");
	cameraPosition = GameObject.Find("Camera");
	escapeOptions = GameObject.Find("Escape Options");

	if(windowWidth <= 1024){
		menu.transform.position.x = cameraPosition.transform.position.x - 8;
	}

	else {
		menu.transform.position.x = cameraPosition.transform.position.x - 7;
	}

	

}

function Update () {

	// if(Input.GetKeyDown("escape")){
		
	// 	if(escapeOptions){
	// 		this.flag = false;
	// 		print("if");
	// 	}

	// 	else{
	// 		print("else");
	// 		this.flag = true;
	// 	}
	// }

}