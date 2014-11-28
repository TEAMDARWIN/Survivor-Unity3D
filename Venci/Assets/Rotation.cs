using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
    
    int dist = 0;
    public GameObject gameInfo;
    GameObject Player;
    float speed = 100;
    private Light light;
    bool isDestroy = false;
    float timerForDestroy = 1f;

    GameObject item;
    PlayerControler playerHealth;

	// Use this for initialization
	void Start () {

        Player = GameObject.Find("Player");
        playerHealth = Player.GetComponent<PlayerControler>();
        light = GetComponent<Light>();
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0F, 0f,Time.deltaTime*speed);

        if (Player) {
		    float dist = Vector3.Distance(Player.transform.position, transform.position);

		    if (dist <= 5) 
            {
			    if(Input.GetKeyDown("g"))
                {
                    item = (GameObject)Instantiate(gameInfo, new Vector3(0.5f, 0.5f, 0), Quaternion.identity);

                    if (playerHealth.HerbCount + 10 < 100)
                    {
                        playerHealth.HerbCount += 10;
                        
                        item.guiText.text = "You Get 1 herb material !";

                        isDestroy = true;
                    }
                    else
                    {
                        item.guiText.text = "You have max herbs !";
                    }
			    }
		    }

            if (dist <= 10) {
                light.enabled = true;
            }
            else
            {
                light.enabled = false;
            }

            if (isDestroy)
            {
                if(timerForDestroy>0)
                {
                    timerForDestroy -= Time.deltaTime;
                }
                else
                {
                    timerForDestroy = 0f;
                }

                transform.localScale = new Vector3(transform.localScale.x * timerForDestroy, transform.localScale.y * timerForDestroy, transform.localScale.z*timerForDestroy);
                if(timerForDestroy<=0)
                {
                    Destroy(item);
                    Destroy(gameObject);
                }
            }
	    }
	}
}
