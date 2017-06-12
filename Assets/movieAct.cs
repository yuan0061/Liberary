using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class movieAct : MonoBehaviour {
	public MovieTexture movTexture; //電影材質
	private AudioSource movAudio; //影片音軌
	public Flowchart flowchart;
	int count=0;
	// Use this for initialization
	void Start(){
		
		GetComponent<Renderer>().material.mainTexture = movTexture;
		GetComponent<MeshRenderer> ().enabled = false;
		//movTexture.loop = true;
		movAudio = GetComponent<AudioSource>();


	}
	void Update(){
		if (count == 0 && flowchart.GetBooleanVariable ("start") == true) {
			GetComponent<MeshRenderer> ().enabled = true;
			movTexture.Play();
			movAudio.Play();
			count++;
		}
		
			//GetComponent<AudioSource>().Play();
			//movTexture.Play();
			//movAudio.Play();

}
}