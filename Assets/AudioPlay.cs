using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AudioPlay : MonoBehaviour {

	public AudioClip sound;

	private Button button { get { return GetComponent<Button>(); } }
	private AudioSource source { get { return GetComponent<AudioSource> (); } }
	bool startAudio = true;

	// Use this for initialization
	void Start () {
		gameObject.AddComponent<AudioSource> ();
		source.clip = sound;
		source.playOnAwake = false;

		button.onClick.AddListener (() => toggleStartButton ());
	}
	
	void PlaySound () {
		//source.PlayOneShot (sound);
		source.Play();
		toggleStartButton ();
	}

	void toggleStartButton(){
		if (startAudio) {
			source.Play ();
			startAudio = false;
			button.GetComponentInChildren<Text> ().text = "Pause";
		} else {

			if (button.GetComponentInChildren<Text> ().text == "Pause") {
				button.GetComponentInChildren<Text> ().text = "Start";
				source.Pause ();
			} else {
				button.GetComponentInChildren<Text> ().text = "Pause";
				source.UnPause ();
			}
		}
	}
		
}
