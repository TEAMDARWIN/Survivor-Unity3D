using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnClick : MonoBehaviour {

	private float startZPozition;
	private GameObject selectedMenu;

	private GameObject panelHero;
	private GameObject panelCredits;
	private GameObject panelOptions;
	private bool keu;


	// Use this for initialization
	void Awake(){

		}

	void Start () {
	
		startZPozition = this.transform.position.z;
		keu = false;



		SetPanelVisibilityToFalse ();




	}
	

	void Update () {


	}

	void OnMouseUp()
	{
		this.transform.position=new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z -1);
	}

	void OnMouseDown()
	{
		selectedMenu= GameObject.FindGameObjectsWithTag("selectedMenu")[0] ;	
		Text temp=selectedMenu.GetComponent<Text>();
		Text[] tex=   this.GetComponentsInChildren<Text>();
		temp.text=tex[0].text;
		this.transform.position=new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + 1);
		//switchPanels (tex [0].text);
	
		foreach (var o in GameObject.FindGameObjectsWithTag("start"))
		{
			o.SetActive(false);
			//o.SetActive(false);//o.SetActive(false);
			
		}



		if(tex [0].text=="c r e d i t s"){

		
			panelOptions.SetActive(false);
			panelHero.SetActive(false);
			panelCredits.SetActive (true);
		
		
		}

		if(tex [0].text=="o p t i o n s"){
			

			panelCredits.SetActive(false);
			panelHero.SetActive(false);
			panelOptions.SetActive (true);
		

		}

		if(tex [0].text=="h e r o"){
			

			panelCredits.SetActive(false);
			panelOptions.SetActive(false);
			panelHero.SetActive (true);
		;
			
		}



	}

	private void SetPanelVisibilityToFalse(){



		foreach (var o in GameObject.FindGameObjectsWithTag("credits"))
		{
			panelCredits=o;
			//o.SetActive(false);//o.SetActive(false);
		
		}
		foreach (var o in GameObject.FindGameObjectsWithTag("hero"))
		{
			panelHero=o;
			//o.SetActive(false);//o.SetActive(false);
		}
		
		foreach (var o in GameObject.FindGameObjectsWithTag("options"))
		{
			
			panelOptions=o;
			//o.SetActive(false);//o.SetActive(false);
		}

	}

	private void setPanel(string str)
	{
		SetPanelVisibilityToFalse ();
		switch(str)
		{
		
		case "hero":panelHero.SetActive (true);break;
		case "credits":panelCredits.SetActive (true);break;
		case "options":panelOptions.SetActive (true);break;
		}
	//	panelCredits.SetActive (true);

	}

	private void switchPanels(string str)
	{


		switch(str)
		{
		
		case "c r e d i t s": setPanel(str.Replace(" ", string.Empty));break;
	    case "h e r o": setPanel(str.Replace(" ", string.Empty));break;
		case "o p t i o n s": setPanel(str.Replace(" ", string.Empty)); break;
		}
	}

	private void getObject(string name, GameObject obj)
	{
	

	}


}
