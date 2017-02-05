using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayButton : MonoBehaviour {
	public Animator ani;
	public GameObject playButton;
	public GameObject infoButton;

	public void GoTOGame () {
		Debug.Log ("Im GO");
		ani.SetTrigger("CloseDS");
		Invoke("StartGame",1.2f);
		infoButton.SetActive (false);
		playButton.SetActive (false);
	}
	void StartGame(){
		
		SceneManager.LoadScene("scene4");
	}
}
