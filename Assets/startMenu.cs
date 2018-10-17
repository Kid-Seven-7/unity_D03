using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class startMenu : MonoBehaviour {

	public Button play, exit;
	
	// Update is called once per frame
	void Update (){
		play.onClick.AddListener(playOnClick);
		exit.onClick.AddListener(exitOnClick);
	}

	void playOnClick(){
		SceneManager.LoadScene("ex01");
	}

	void exitOnClick(){
		Application.Quit();
	}
}
