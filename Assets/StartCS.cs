using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartCS : MonoBehaviour {
	public Canvas myCanvas;
	public Button button;

	// Use this for initialization
	void Start () {
	/*	hideCanvas();
		WaitToShow();
	*/
	}

	IEnumerator WaitToShow(){
		yield return new WaitForSeconds(600f);
		showCanvas();
	}

	void hideCanvas(){
		myCanvas.gameObject.SetActive(false);
	}

	void showCanvas(){
		myCanvas.gameObject.SetActive(true);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
}
