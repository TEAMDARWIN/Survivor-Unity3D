using UnityEngine;
using System.Collections;

public class OnOver : MonoBehaviour {

	private int rotTime;
	private bool rollOver;

	// Use this for initialization
	void Start () {
		rotTime = 0;
		rollOver = false;
	}
	
	// Update is called once per frame
	void Update () {
	

		if (rollOver == false && rotTime > 0) {
						rotTime--;
			this.transform.Rotate (new Vector3 (0.0f, -0.53f, 0.0f));
		} 

		if (rotTime < 0) 
		{
			rotTime=0;
		}

	



	}

	void LateUpdate()
	{



		rollOver = false;
	}

	void OnMouseOver() {
		rollOver = true;
		rotTime++;
		if (  rotTime < 20) {
			
			this.transform.Rotate (new Vector3 (0.0f, 0.55f, 0.0f));
			
		}
		else 
		{
			rotTime=20;
		}



	}



}
