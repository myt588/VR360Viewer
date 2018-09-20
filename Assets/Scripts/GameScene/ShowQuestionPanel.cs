using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowQuestionPanel : MonoBehaviour {

	public GameObject panel;
	public Text buttonText;
	public void showPanel() {
//		Debug.Log ("test");
		if (panel.activeInHierarchy) {
			panel.SetActive (false);
			buttonText.text = "Show Question";
		} else {
			panel.SetActive (true);
			buttonText.text = "Hide Question";
		}
	}
}
