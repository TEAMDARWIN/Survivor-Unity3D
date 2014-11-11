#pragma strict

var dayLight : Gradient;
var dayTime : float = 0.0;
var morning : Material;
var day1 : Material;
var day2 : Material;
var night : Material;
var sunTarget : GameObject;

function Start () {

	
	dayTime = Random.Range(0.0, 1.0);

}

function Update () {

	// AmbientLight Light

	sunTarget.light.color = dayLight.Evaluate(dayTime);

	// Day cycl

		if(dayTime > 0.8 & dayTime < 0.95) RenderSettings.skybox = morning;

		if(dayTime > 0.0 & dayTime < 0.25) RenderSettings.skybox = day1;

		if(dayTime > 0.25 & dayTime < 0.65) RenderSettings.skybox = day2;

		if(dayTime > 0.6 & dayTime < 0.8) RenderSettings.skybox = night;

		if(dayTime == 1.0) dayTime = 0.0;

	// ---------

	// Increase dayTime

	dayTime = Mathf.MoveTowards(dayTime, 1.0, Time.deltaTime/300);



}