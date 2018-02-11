using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	
	public Text text;
	public int count;
	public int maxGuesses = 10;
	
	int max;
	int min;
	int guess;
	
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	void StartGame() {
		
		max = 10000;
		min = 1;
		guess = Random.Range(min, max);
		//guess = (max + min) / 2;
		
		text.text = "Is your number: " + guess + "?";
		
		count = 1;
		
	}
	
	public void GuessHigher() {
		
		min = guess;
		NextGuess();
		
	}
	
	public void GuessLower() {
		
		max = guess;
		NextGuess();
		
	}
	
	void NextGuess() {
		
		guess = Random.Range(min, max);
		// guess = (max + min) / 2
		
		text.text = "Is your number: " + guess + "?";
		
		maxGuesses = maxGuesses - 1;
		if (maxGuesses <= 0) {
			Application.LoadLevel("Win");
		}
		
		count = count + 1;
		
	}
	
}
