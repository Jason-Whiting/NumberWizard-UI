using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string level) {
		Debug.Log("Level Load Requested for " + level);
		Application.LoadLevel(level);
	}
	
	public void Quit() {
		Debug.Log("Quit Requested.");
		Application.Quit();
	}
	
}
