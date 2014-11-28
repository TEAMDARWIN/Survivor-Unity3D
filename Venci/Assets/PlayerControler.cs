using UnityEngine;
using System.Collections;

public class PlayerControler : MonoBehaviour {
    static int sensetivy = 5;
    int mouseSensetivy = 10;
    int MoveSpeed = 10;
    Transform firepoint;
    GameObject ammo;
    Transform spawnObject;
    Light flashlight;
    int firePower = 10;
    int woodCount = 0;
    int foodCount = 0;
    public int herbCount = 0;

    public int HerbCount
    {
        get { return herbCount; }
        set { herbCount = value; }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    // Turn off/on Flashlight
	    if(flashlight){
		    if(Input.GetKeyDown("f")) flashlight.enabled = !flashlight.enabled;
	    }

	    if(Input.GetKeyDown("escape")){
		    Application.Quit();
		    print("escape is pressed");
	    }
        Debug.Log(herbCount);
    }
    
    void FixedUpdate () {
	
	    // Move Player forward
	    this.rigidbody.velocity = transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal")*MoveSpeed,rigidbody.velocity.y,Input.GetAxis("Vertical")*MoveSpeed));
	
	    // Rotate Player 
	    transform.Rotate(new Vector3(0,Input.GetAxis("Mouse X")*Time.deltaTime*mouseSensetivy,0));


    }
}
