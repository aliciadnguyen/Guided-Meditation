#pragma strict

function Start () {
	yield WaitForSeconds(5);
		Destroy(gameObject);
		//Fade.use.Alpha(GetComponent(TextMesh).GetComponent.<Renderer>().material, 0.0, 1.0, 2.0);
}

function Update () {
	/*if(!faded && Input.GetKeyDown(KeyCode.A)){
		faded = true;
		Fade.use.Alpha(GetComponent.<GUIText>().material, 1.0, 0.0, 1.0);
	}*/
}

