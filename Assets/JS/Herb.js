#pragma strict
private var dist : int = 10;

var gameInfo : GameObject;

private var Player : GameObject;


function Start () {
	Player = GameObject.Find("Player");
}

function Update () {

	if (Player) {

		var dist = Vector3.Distance(Player.transform.position, transform.position);

		if (dist <= 2) {
			
			if(Input.GetKeyDown("g")){

				Inventory.herbCount+=1;

				var item : GameObject = Instantiate(gameInfo,Vector3(0.5,0.5,0),Quaternion.identity);

				item.guiText.text = "You Get 1 herb material !";

				Destroy(gameObject);
				Destroy(item, 5);
			}	
		}
	}

}
