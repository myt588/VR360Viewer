using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndSetup : MonoBehaviour {

	public Text titleText;
	public Text scoreText;
	// Use this for initialization
	void Start () {
		scoreText.text = "Score: " + GameConfig.score.ToString ();
		if (GameConfig.score == 0) {
			titleText.text = "You really don't know anything!! HAHAHAHA";
		} 
		if (GameConfig.score == 10) {
			titleText.text = "My grandma can do better than you man!! HAHAHAHA";
		} 
		if (GameConfig.score == 20) {
			titleText.text = "2 out of 10, not bad, huh";
		} 
		if (GameConfig.score == 30) {
			titleText.text = "Unbeliveable!";
		} 
		if (GameConfig.score == 40) {
			titleText.text = "You are getting there";
		} 
		if (GameConfig.score == 50) {
			titleText.text = "Half Half";
		} 
		if (GameConfig.score == 60) {
			titleText.text = "Ok you passed";
		} 
		if (GameConfig.score == 70) {
			titleText.text = "You really know these places";
		} 
		if (GameConfig.score == 80) {
			titleText.text = "Oh God, you so good";
		} 
		if (GameConfig.score == 90) {
			titleText.text = "No way, which one did you miss?";
		} 
		if (GameConfig.score == 100) {
			titleText.text = "God is playing this game.";
		} 

	}

}
