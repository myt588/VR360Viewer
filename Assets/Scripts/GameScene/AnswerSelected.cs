using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnswerSelected : MonoBehaviour {


	public Text buttonText;
	public ShowQuestionPanel panel;
	public ChangeSkybox change;
	public Animator check;
	public Animator cross;
	public Text score;
	public void selected()
	{
//		Debug.Log (GameConfig.stages[GameConfig.currentStage, 0]);
		Debug.Log (buttonText.text);
		if (buttonText.text == GameConfig.stages_tokyo [GameConfig.currentStage, 0]) {
			GameConfig.score += 10;
			score.text = "Score: " + GameConfig.score.ToString ();
			check.SetTrigger ("appear");
		} else {
			cross.SetTrigger ("appear");
		}
		panel.showPanel ();
		change.changeSkybox ();
	}
}
