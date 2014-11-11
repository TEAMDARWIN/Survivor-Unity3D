#pragma strict

function Start() {
	
}

function OnMouseDown () {

	if(this.name == "New Game"){
		// Load the level named "Level1".
		Application.LoadLevel ("Level1");
		Screen.showCursor = false;
	}

	if(this.name == "Options"){
		// Load the level named "Options".
		// Application.LoadLevel ("Level1");
	}

	if(this.name == "Quit"){
		// Load the level named "HighScore".
		Application.Quit();
	}
	else{
		print("This is not New Game Button");
	}
}

function OnMouseEnter(){
	GetComponent(TextMesh).fontSize = 80;
}

function OnMouseExit () {
	GetComponent(TextMesh).fontSize = 75;
}
